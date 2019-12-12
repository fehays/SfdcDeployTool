using Salesforce;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Deployment.Application;
using System.Runtime.InteropServices;

namespace SfdcDeployTool
{
    public partial class MainForm : Form
    {
        public string _packageRootFolder = "";

        bool _cancelled = false;

        public Dictionary<string, UserEnvSettings> _settings = new Dictionary<string, UserEnvSettings>();

        public MainForm()
        {
            InitializeComponent();

            Bitmap bmp = Properties.Resources.cloudupload;
            this.Icon = Icon.FromHandle(bmp.GetHicon());

            LoadSettings();
            PopulateSettingsDropDown();
            PopulateTestLevels();
            ResetStatusNumbers();

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                statusStripLabel.Text = string.Format("Sfdc Deploy Tool - v{0}", ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4));
            }
        }

        private void LoadSettings()
        {
            string appDataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string settingsPath = Path.Combine(appDataFolderPath, "SfdcDeployTool");
            var settingsFile = Path.Combine(settingsPath, "SfdcDeployTool.settings");
            if (File.Exists(settingsFile))
            {
                string settingsJson = Decrypt(File.ReadAllText(settingsFile));
                _settings = JsonConvert.DeserializeObject<Dictionary<string, UserEnvSettings>>(settingsJson);
            }
            else
            {
                //default the url endpoints
                txtSourceUrl.Text = "https://test.salesforce.com/services/Soap/u/38.0";
                txtTargetUrl.Text = "https://test.salesforce.com/services/Soap/u/38.0";
            }
        }

        private void PopulateSettingsDropDown()
        {
            if (_settings.Count > 0)
            {
                ddEnvSettings.Items.Clear();
                foreach (string key in _settings.Keys)
                {
                    ddEnvSettings.Items.Add(key);
                }
            }
        }

        private void PopulateTestLevels()
        {
            cbTestLevel.DataSource = Enum.GetValues(typeof(Salesforce.MetadataService.TestLevel));
        }

        private void btnDeleteSetting_Click(object sender, EventArgs e)
        {
            DeleteSetting();
        }

        private void DeleteSetting()
        {
            string appDataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string settingsPath = Path.Combine(appDataFolderPath, "SfdcDeployTool");
            if (!Directory.Exists(settingsPath))
            {
                Directory.CreateDirectory(settingsPath);
            }
            var settingsFile = Path.Combine(settingsPath, "SfdcDeployTool.settings");
            string settingName = null;
            if (!string.IsNullOrWhiteSpace(ddEnvSettings.Text))
                settingName = ddEnvSettings.Text.Trim();
            if (!string.IsNullOrWhiteSpace(settingName))
            {
                if (_settings.ContainsKey(settingName))
                    _settings.Remove(settingName);

                string json = JsonConvert.SerializeObject(_settings, Formatting.Indented);

                File.WriteAllText(settingsFile, Encrypt(json));
                PopulateSettingsDropDown();
            }
        }

        private void SaveSettings()
        {
            string appDataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string settingsPath = Path.Combine(appDataFolderPath, "SfdcDeployTool");
            if (!Directory.Exists(settingsPath))
            {
                Directory.CreateDirectory(settingsPath);
            }
            var settingsFile = Path.Combine(settingsPath, "SfdcDeployTool.settings");
            string settingName = null;
            if (!string.IsNullOrWhiteSpace(ddEnvSettings.Text))
                settingName = ddEnvSettings.Text.Trim();
            if (!string.IsNullOrWhiteSpace(settingName))
            {
                if (_settings.ContainsKey(settingName))
                    _settings.Remove(settingName);
                _settings.Add(settingName, new UserEnvSettings()
                {
                    SettingName = settingName
                    , SourceUrl = txtSourceUrl.Text.Trim()
                    , SourcePassword = txtSourcePassword.Text
                    , SourceUsername = txtSourceUsername.Text.Trim()
                    , TargetUrl = txtTargetUrl.Text.Trim()
                    , TargetPassword = txtTargetPassword.Text
                    , TargetUsername = txtTargetUsername.Text
                    , PackageRootPath = txtPackagePath.Text.Trim()
                    , ValidateOnly = cbCheckOnly.Checked
                    , CleanProfiles = cbCleanProfiles.Checked
                });
                string json = JsonConvert.SerializeObject(_settings, Formatting.Indented);
                File.WriteAllText(settingsFile, Encrypt(json));
                PopulateSettingsDropDown();
            }
        }

        private string Encrypt(string text)
        {
            return Convert.ToBase64String(
                ProtectedData.Protect(Encoding.Unicode.GetBytes(text), null, DataProtectionScope.CurrentUser)
            );
        }

        private string Decrypt(string text)
        {
            return Encoding.Unicode.GetString(
                ProtectedData.Unprotect(Convert.FromBase64String(text), null, DataProtectionScope.CurrentUser)
            );
        }

        private void btnSelectPackage_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadPackages(folderBrowserDialog1.SelectedPath);
            }
        }

        private void btnGetSource_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
            ResetStatusNumbers();
            GetSource();
        }

        private void btnGetBackup_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
            ResetStatusNumbers();
            GetBackup();
        }

        private void btnDeployToTarget_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
            ResetStatusNumbers();
            DeployToTarget();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void ddEnvSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFormFromSettings(ddEnvSettings.Text);
        }

        private async void GetSource()
        {
            string packageName = ddPackages.Text;
            if (string.IsNullOrEmpty(packageName))
            {
                MessageBox.Show("You must select a package");
                return;
            }
            ToggleGroupBoxEnabled(false);
            var task = Task.Factory.StartNew(() =>
            {
                var sfMetadata = GetSourceMetadataHelper();
                sfMetadata.RetrievePackageFolder(_packageRootFolder + Path.DirectorySeparatorChar + packageName, "source", ProcessCallback, true, cbCleanProfiles.Checked);
                return true;
            });

            bool completed = await task;

            ToggleGroupBoxEnabled(completed);
        }

        private async void GetBackup()
        {
            string packageName = ddPackages.Text;
            if (string.IsNullOrEmpty(packageName))
            {
                MessageBox.Show("You must select a package");
                return;
            }
            ToggleGroupBoxEnabled(false);
            var task = Task.Factory.StartNew(() =>
            {
                var sfMetadata = GetTargetMetadataHelper();
                sfMetadata.RetrievePackageFolder(_packageRootFolder + Path.DirectorySeparatorChar + packageName, "backup", ProcessCallback, true, cbCleanProfiles.Checked);
                return true;
            });

            bool completed = await task;

            ToggleGroupBoxEnabled(completed);
        }

        private async void DeployToTarget()
        {            
            
            string packageName = ddPackages.Text;
            string testMethods = Regex.Replace(txtSpecificTests.Text, @"\s+", "");
            bool checkOnly = cbCheckOnly.Checked;
            if (string.IsNullOrEmpty(packageName))
            {
                MessageBox.Show("You must select a package");
                return;
            }
            btnCancel.Visible = true;
            ToggleGroupBoxEnabled(false);
            Salesforce.MetadataService.TestLevel testLevel;
            Enum.TryParse<Salesforce.MetadataService.TestLevel>(cbTestLevel.SelectedValue.ToString(), out testLevel);
            var task = Task.Factory.StartNew(() =>
            {
                var sfMetadata = GetTargetMetadataHelper();                
                sfMetadata.DeployOptions.testLevel = testLevel;
                sfMetadata.DeployPackageFolder(_packageRootFolder + Path.DirectorySeparatorChar + packageName, "source", ProcessCallback, testMethods, checkOnly);
                return true;
            });

            bool completed = await task;
            btnCancel.Visible = false;
            btnCancel.Enabled = true;
            ToggleGroupBoxEnabled(completed);
        }

        private void LoadPackages(string rootPath)
        {
            txtPackagePath.Text = rootPath;
            _packageRootFolder = rootPath;
            var dirs = Directory.GetDirectories(_packageRootFolder).Select(Path.GetFileName);
            ddPackages.Items.Clear();
            foreach (string dir in dirs)
            {
                ddPackages.Items.Add(dir);
            }
        }

        private void ToggleGroupBoxEnabled(bool enabled)
        {
            gbSettings.Enabled = enabled;
            gbSource.Enabled = enabled;
            gbTarget.Enabled = enabled;
            gbOptions.Enabled = enabled;
            gbCommand.Enabled = enabled;
        }

        private SfdcMetadataHelper GetTargetMetadataHelper()
        {
            string sfUrl = txtTargetUrl.Text;
            string sfUser = txtTargetUsername.Text;
            string sfPwd = txtTargetPassword.Text;
            var sfMetadata = new SfdcMetadataHelper();
            sfMetadata.SetServiceUrl(sfUrl);
            sfMetadata.SetLoginCredentials(sfUser, sfPwd);

            return sfMetadata;
        }

        private SfdcMetadataHelper GetSourceMetadataHelper()
        {
            string sfUrl = txtSourceUrl.Text;
            string sfUser = txtSourceUsername.Text;
            string sfPwd = txtSourcePassword.Text;
            var sfMetadata = new SfdcMetadataHelper();
            sfMetadata.SetServiceUrl(sfUrl);
            sfMetadata.SetLoginCredentials(sfUser, sfPwd);

            return sfMetadata;
        }

        private delegate bool UpdateLogDelegate(SfdcMetadataHelper.ProgressInfo progressInfo);
        public bool ProcessCallback(SfdcMetadataHelper.ProgressInfo progressInfo)
        {
            if (this.txtLog.InvokeRequired)
            {
                this.Invoke(new UpdateLogDelegate(this.ProcessCallback), progressInfo);
                return true;
            }
            string now = DateTime.Now.ToString("yyyy-dd-M HH:mm:ss");
            int componentsCompleted = progressInfo.NumberComponentsDeployed + progressInfo.NumberComponentErrors;
            txtLog.AppendText(now + " - " + progressInfo.Message + Environment.NewLine);
            if (progressInfo.Command == SfdcMetadataHelper.MetadataCommand.Deploy && !string.IsNullOrEmpty(progressInfo.CommandSfId) && _cancelled)
            {
                CancelDeploy(progressInfo.CommandSfId);
            }

            if (progressInfo.Status == SfdcMetadataHelper.ProgressStatus.InProgress)
                UpdateDeployStatus(progressInfo);

            if (progressInfo.Status == SfdcMetadataHelper.ProgressStatus.Cancelled)
                ResetStatusNumbers();

            return true;
        }

        private void UpdateDeployStatus(SfdcMetadataHelper.ProgressInfo progressInfo)
        {
            pbDeployComponents.Maximum = progressInfo.NumberComponentsTotal;

            int compCompleted = progressInfo.NumberComponentsDeployed + progressInfo.NumberComponentErrors;
            lblCompTotal.Text = string.Format("{0}/{1}", progressInfo.NumberComponentsDeployed, progressInfo.NumberComponentsTotal);
            lblCompErrors.Text = progressInfo.NumberComponentErrors.ToString();
            pbDeployComponents.Value = compCompleted;
            
            pbRunApexTests.Maximum = progressInfo.NumberTestsTotal;

            int testCompleted = progressInfo.NumberTestsCompleted + progressInfo.NumberTestErrors;
            lblTestTotal.Text = string.Format("{0}/{1}", progressInfo.NumberTestsCompleted, progressInfo.NumberTestsTotal);
            lblTestErrors.Text = progressInfo.NumberTestErrors.ToString();
            pbRunApexTests.Value = testCompleted;
        }

        private void ResetStatusNumbers()
        {
            lblCompTotal.Text = "0/0";
            lblCompErrors.Text = "0";
            lblTestTotal.Text = "0/0";
            lblTestErrors.Text = "0";
            pbRunApexTests.Maximum = 0;
            pbRunApexTests.Value = 0;
            pbDeployComponents.Maximum = 0;
            pbDeployComponents.Value = 0;
        }

        private async void CancelDeploy(string commandId)
        {
            _cancelled = true;            
            var task = Task.Factory.StartNew(() =>
            {
                var sfMetadata = GetTargetMetadataHelper();
                sfMetadata.CancelDeploy(commandId);
                return true;
            });
            bool completed = await task;            
            _cancelled = false;            
        }
        
        private void LoadFormFromSettings(string settingName)
        {
            UserEnvSettings userSettings = _settings[settingName];
            txtSourceUrl.Text = userSettings.SourceUrl;
            txtSourceUsername.Text = userSettings.SourceUsername;
            txtSourcePassword.Text = userSettings.SourcePassword;
            txtTargetUrl.Text = userSettings.TargetUrl;
            txtTargetUsername.Text = userSettings.TargetUsername;
            txtTargetPassword.Text = userSettings.TargetPassword;
            cbCheckOnly.Checked = userSettings.ValidateOnly;
            cbCleanProfiles.Checked = userSettings.CleanProfiles;
            txtPackagePath.Text = userSettings.PackageRootPath;
            if (!String.IsNullOrEmpty(txtPackagePath.Text))
            {
                LoadPackages(userSettings.PackageRootPath);
            }            
        }

        private void viewUserSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(_settings, Formatting.Indented);
            UserSettings frm = new UserSettings();
            frm.textBox1.Text = json;
            frm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.btnCancel.Enabled = false;
            _cancelled = true;
        }

        // progress bar color solution: http://stackoverflow.com/questions/778678/how-to-change-the-color-of-progressbar-in-c-sharp-net-3-5
    }
}

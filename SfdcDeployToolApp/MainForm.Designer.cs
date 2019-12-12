namespace SfdcDeployTool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUserSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbTarget = new System.Windows.Forms.GroupBox();
            this.txtTargetPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTargetUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTargetUrl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbSource = new System.Windows.Forms.GroupBox();
            this.txtSourcePassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSourceUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSourceUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.ddPackages = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPackagePath = new System.Windows.Forms.TextBox();
            this.txtSpecificTests = new System.Windows.Forms.TextBox();
            this.btnSelectPackage = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCleanProfiles = new System.Windows.Forms.CheckBox();
            this.cbCheckOnly = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbCommand = new System.Windows.Forms.GroupBox();
            this.btnDeployToTarget = new System.Windows.Forms.Button();
            this.btnGetBackup = new System.Windows.Forms.Button();
            this.btnGetSource = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.btnDeleteSetting = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.ddEnvSettings = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.lblTestErrors = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pbRunApexTests = new System.Windows.Forms.ProgressBar();
            this.lblCompTotal = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCompErrors = new System.Windows.Forms.Label();
            this.lblTestTotal = new System.Windows.Forms.Label();
            this.pbDeployComponents = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label12 = new System.Windows.Forms.Label();
            this.cbTestLevel = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbTarget.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbSource.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gbCommand.SuspendLayout();
            this.panel5.SuspendLayout();
            this.gbLog.SuspendLayout();
            this.panel6.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(48, 17);
            this.statusStripLabel.Text = "Version:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewUserSettingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewUserSettingsToolStripMenuItem
            // 
            this.viewUserSettingsToolStripMenuItem.Name = "viewUserSettingsToolStripMenuItem";
            this.viewUserSettingsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.viewUserSettingsToolStripMenuItem.Text = "View User Settings";
            this.viewUserSettingsToolStripMenuItem.Click += new System.EventHandler(this.viewUserSettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbStatus, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 684);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.gbTarget);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(507, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 117);
            this.panel2.TabIndex = 3;
            // 
            // gbTarget
            // 
            this.gbTarget.AutoSize = true;
            this.gbTarget.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbTarget.Controls.Add(this.txtTargetPassword);
            this.gbTarget.Controls.Add(this.label4);
            this.gbTarget.Controls.Add(this.txtTargetUsername);
            this.gbTarget.Controls.Add(this.label5);
            this.gbTarget.Controls.Add(this.txtTargetUrl);
            this.gbTarget.Controls.Add(this.label6);
            this.gbTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTarget.Location = new System.Drawing.Point(0, 0);
            this.gbTarget.Name = "gbTarget";
            this.gbTarget.Size = new System.Drawing.Size(498, 117);
            this.gbTarget.TabIndex = 0;
            this.gbTarget.TabStop = false;
            this.gbTarget.Text = "Target";
            // 
            // txtTargetPassword
            // 
            this.txtTargetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetPassword.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetPassword.Location = new System.Drawing.Point(106, 74);
            this.txtTargetPassword.Name = "txtTargetPassword";
            this.txtTargetPassword.Size = new System.Drawing.Size(374, 23);
            this.txtTargetPassword.TabIndex = 5;
            this.txtTargetPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTargetUsername
            // 
            this.txtTargetUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetUsername.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetUsername.Location = new System.Drawing.Point(106, 48);
            this.txtTargetUsername.Name = "txtTargetUsername";
            this.txtTargetUsername.Size = new System.Drawing.Size(374, 23);
            this.txtTargetUsername.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Username";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTargetUrl
            // 
            this.txtTargetUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTargetUrl.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetUrl.Location = new System.Drawing.Point(106, 22);
            this.txtTargetUrl.Name = "txtTargetUrl";
            this.txtTargetUrl.Size = new System.Drawing.Size(374, 23);
            this.txtTargetUrl.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Url";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.gbSource);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 117);
            this.panel1.TabIndex = 2;
            // 
            // gbSource
            // 
            this.gbSource.AutoSize = true;
            this.gbSource.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbSource.Controls.Add(this.txtSourcePassword);
            this.gbSource.Controls.Add(this.label3);
            this.gbSource.Controls.Add(this.txtSourceUsername);
            this.gbSource.Controls.Add(this.label2);
            this.gbSource.Controls.Add(this.txtSourceUrl);
            this.gbSource.Controls.Add(this.label1);
            this.gbSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSource.Location = new System.Drawing.Point(0, 0);
            this.gbSource.Name = "gbSource";
            this.gbSource.Size = new System.Drawing.Size(498, 117);
            this.gbSource.TabIndex = 0;
            this.gbSource.TabStop = false;
            this.gbSource.Text = "Source";
            // 
            // txtSourcePassword
            // 
            this.txtSourcePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourcePassword.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourcePassword.Location = new System.Drawing.Point(106, 75);
            this.txtSourcePassword.Name = "txtSourcePassword";
            this.txtSourcePassword.Size = new System.Drawing.Size(374, 23);
            this.txtSourcePassword.TabIndex = 5;
            this.txtSourcePassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSourceUsername
            // 
            this.txtSourceUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceUsername.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceUsername.Location = new System.Drawing.Point(106, 49);
            this.txtSourceUsername.Name = "txtSourceUsername";
            this.txtSourceUsername.Size = new System.Drawing.Size(374, 23);
            this.txtSourceUsername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSourceUrl
            // 
            this.txtSourceUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceUrl.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceUrl.Location = new System.Drawing.Point(106, 23);
            this.txtSourceUrl.Name = "txtSourceUrl";
            this.txtSourceUrl.Size = new System.Drawing.Size(374, 23);
            this.txtSourceUrl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.gbOptions);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1002, 205);
            this.panel3.TabIndex = 4;
            // 
            // gbOptions
            // 
            this.gbOptions.AutoSize = true;
            this.gbOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbOptions.Controls.Add(this.cbTestLevel);
            this.gbOptions.Controls.Add(this.label12);
            this.gbOptions.Controls.Add(this.ddPackages);
            this.gbOptions.Controls.Add(this.label9);
            this.gbOptions.Controls.Add(this.txtPackagePath);
            this.gbOptions.Controls.Add(this.txtSpecificTests);
            this.gbOptions.Controls.Add(this.btnSelectPackage);
            this.gbOptions.Controls.Add(this.label7);
            this.gbOptions.Controls.Add(this.cbCleanProfiles);
            this.gbOptions.Controls.Add(this.cbCheckOnly);
            this.gbOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOptions.Location = new System.Drawing.Point(0, 0);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(1002, 205);
            this.gbOptions.TabIndex = 0;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Deployment Options";
            // 
            // ddPackages
            // 
            this.ddPackages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddPackages.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddPackages.FormattingEnabled = true;
            this.ddPackages.Location = new System.Drawing.Point(182, 51);
            this.ddPackages.Name = "ddPackages";
            this.ddPackages.Size = new System.Drawing.Size(290, 23);
            this.ddPackages.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Select Package";
            // 
            // txtPackagePath
            // 
            this.txtPackagePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPackagePath.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackagePath.Location = new System.Drawing.Point(182, 19);
            this.txtPackagePath.Name = "txtPackagePath";
            this.txtPackagePath.ReadOnly = true;
            this.txtPackagePath.Size = new System.Drawing.Size(802, 23);
            this.txtPackagePath.TabIndex = 5;
            // 
            // txtSpecificTests
            // 
            this.txtSpecificTests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpecificTests.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecificTests.Location = new System.Drawing.Point(182, 80);
            this.txtSpecificTests.Name = "txtSpecificTests";
            this.txtSpecificTests.Size = new System.Drawing.Size(802, 23);
            this.txtSpecificTests.TabIndex = 5;
            // 
            // btnSelectPackage
            // 
            this.btnSelectPackage.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelectPackage.Image = global::SfdcDeployTool.Properties.Resources.openfolder16;
            this.btnSelectPackage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectPackage.Location = new System.Drawing.Point(9, 19);
            this.btnSelectPackage.Name = "btnSelectPackage";
            this.btnSelectPackage.Size = new System.Drawing.Size(162, 25);
            this.btnSelectPackage.TabIndex = 4;
            this.btnSelectPackage.Text = "Select Package Root Path";
            this.btnSelectPackage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectPackage.UseVisualStyleBackColor = true;
            this.btnSelectPackage.Click += new System.EventHandler(this.btnSelectPackage_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Specified Tests (CSV)";
            // 
            // cbCleanProfiles
            // 
            this.cbCleanProfiles.Location = new System.Drawing.Point(6, 169);
            this.cbCleanProfiles.Name = "cbCleanProfiles";
            this.cbCleanProfiles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbCleanProfiles.Size = new System.Drawing.Size(190, 17);
            this.cbCleanProfiles.TabIndex = 2;
            this.cbCleanProfiles.Text = "Clean Profiles";
            this.cbCleanProfiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbCleanProfiles.UseVisualStyleBackColor = true;
            // 
            // cbCheckOnly
            // 
            this.cbCheckOnly.Checked = true;
            this.cbCheckOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCheckOnly.Location = new System.Drawing.Point(6, 143);
            this.cbCheckOnly.Name = "cbCheckOnly";
            this.cbCheckOnly.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbCheckOnly.Size = new System.Drawing.Size(190, 17);
            this.cbCheckOnly.TabIndex = 1;
            this.cbCheckOnly.Text = "Check Only";
            this.cbCheckOnly.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbCheckOnly.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.panel4, 2);
            this.panel4.Controls.Add(this.gbCommand);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 406);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1002, 71);
            this.panel4.TabIndex = 5;
            // 
            // gbCommand
            // 
            this.gbCommand.AutoSize = true;
            this.gbCommand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbCommand.Controls.Add(this.btnDeployToTarget);
            this.gbCommand.Controls.Add(this.btnGetBackup);
            this.gbCommand.Controls.Add(this.btnGetSource);
            this.gbCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCommand.Location = new System.Drawing.Point(0, 0);
            this.gbCommand.Name = "gbCommand";
            this.gbCommand.Size = new System.Drawing.Size(1002, 71);
            this.gbCommand.TabIndex = 5;
            this.gbCommand.TabStop = false;
            this.gbCommand.Text = "Command";
            // 
            // btnDeployToTarget
            // 
            this.btnDeployToTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDeployToTarget.Image = global::SfdcDeployTool.Properties.Resources.cloudupload16;
            this.btnDeployToTarget.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeployToTarget.Location = new System.Drawing.Point(205, 22);
            this.btnDeployToTarget.Name = "btnDeployToTarget";
            this.btnDeployToTarget.Size = new System.Drawing.Size(115, 30);
            this.btnDeployToTarget.TabIndex = 5;
            this.btnDeployToTarget.Text = "Deploy to Target";
            this.btnDeployToTarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeployToTarget.UseVisualStyleBackColor = true;
            this.btnDeployToTarget.Click += new System.EventHandler(this.btnDeployToTarget_Click);
            // 
            // btnGetBackup
            // 
            this.btnGetBackup.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetBackup.Image = global::SfdcDeployTool.Properties.Resources.clouddownload16;
            this.btnGetBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetBackup.Location = new System.Drawing.Point(105, 22);
            this.btnGetBackup.Name = "btnGetBackup";
            this.btnGetBackup.Size = new System.Drawing.Size(94, 30);
            this.btnGetBackup.TabIndex = 4;
            this.btnGetBackup.Text = "Get Backup";
            this.btnGetBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetBackup.UseVisualStyleBackColor = true;
            this.btnGetBackup.Click += new System.EventHandler(this.btnGetBackup_Click);
            // 
            // btnGetSource
            // 
            this.btnGetSource.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetSource.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGetSource.Image = global::SfdcDeployTool.Properties.Resources.clouddownload16;
            this.btnGetSource.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetSource.Location = new System.Drawing.Point(9, 22);
            this.btnGetSource.Name = "btnGetSource";
            this.btnGetSource.Size = new System.Drawing.Size(90, 30);
            this.btnGetSource.TabIndex = 3;
            this.btnGetSource.Text = "Get Source";
            this.btnGetSource.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetSource.UseVisualStyleBackColor = true;
            this.btnGetSource.Click += new System.EventHandler(this.btnGetSource_Click);
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.panel5, 2);
            this.panel5.Controls.Add(this.gbLog);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 571);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1002, 110);
            this.panel5.TabIndex = 6;
            // 
            // gbLog
            // 
            this.gbLog.AutoSize = true;
            this.gbLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbLog.Controls.Add(this.txtLog);
            this.gbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLog.Location = new System.Drawing.Point(0, 0);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(1002, 110);
            this.gbLog.TabIndex = 4;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "Log";
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(3, 16);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(996, 91);
            this.txtLog.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.panel6, 2);
            this.panel6.Controls.Add(this.gbSettings);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1002, 63);
            this.panel6.TabIndex = 7;
            // 
            // gbSettings
            // 
            this.gbSettings.AutoSize = true;
            this.gbSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbSettings.Controls.Add(this.btnDeleteSetting);
            this.gbSettings.Controls.Add(this.btnSaveSettings);
            this.gbSettings.Controls.Add(this.ddEnvSettings);
            this.gbSettings.Controls.Add(this.label8);
            this.gbSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSettings.Location = new System.Drawing.Point(0, 0);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(1002, 63);
            this.gbSettings.TabIndex = 6;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // btnDeleteSetting
            // 
            this.btnDeleteSetting.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteSetting.Image = global::SfdcDeployTool.Properties.Resources.trash16;
            this.btnDeleteSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteSetting.Location = new System.Drawing.Point(478, 19);
            this.btnDeleteSetting.Name = "btnDeleteSetting";
            this.btnDeleteSetting.Size = new System.Drawing.Size(101, 25);
            this.btnDeleteSetting.TabIndex = 8;
            this.btnDeleteSetting.Text = "Delete Setting";
            this.btnDeleteSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteSetting.UseVisualStyleBackColor = true;
            this.btnDeleteSetting.Click += new System.EventHandler(this.btnDeleteSetting_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveSettings.Image = global::SfdcDeployTool.Properties.Resources.floppy16;
            this.btnSaveSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSettings.Location = new System.Drawing.Point(371, 19);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(101, 25);
            this.btnSaveSettings.TabIndex = 7;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // ddEnvSettings
            // 
            this.ddEnvSettings.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddEnvSettings.FormattingEnabled = true;
            this.ddEnvSettings.Location = new System.Drawing.Point(163, 19);
            this.ddEnvSettings.Name = "ddEnvSettings";
            this.ddEnvSettings.Size = new System.Drawing.Size(202, 23);
            this.ddEnvSettings.TabIndex = 1;
            this.ddEnvSettings.SelectedIndexChanged += new System.EventHandler(this.ddEnvSettings_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Saved Environment Settings";
            // 
            // gbStatus
            // 
            this.gbStatus.AutoSize = true;
            this.gbStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.gbStatus, 2);
            this.gbStatus.Controls.Add(this.lblTestErrors);
            this.gbStatus.Controls.Add(this.label11);
            this.gbStatus.Controls.Add(this.label10);
            this.gbStatus.Controls.Add(this.pbRunApexTests);
            this.gbStatus.Controls.Add(this.lblCompTotal);
            this.gbStatus.Controls.Add(this.btnCancel);
            this.gbStatus.Controls.Add(this.lblCompErrors);
            this.gbStatus.Controls.Add(this.lblTestTotal);
            this.gbStatus.Controls.Add(this.pbDeployComponents);
            this.gbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbStatus.Location = new System.Drawing.Point(3, 483);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(1002, 82);
            this.gbStatus.TabIndex = 8;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Deploy Status";
            // 
            // lblTestErrors
            // 
            this.lblTestErrors.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestErrors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTestErrors.Image = global::SfdcDeployTool.Properties.Resources.error16;
            this.lblTestErrors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTestErrors.Location = new System.Drawing.Point(451, 24);
            this.lblTestErrors.Name = "lblTestErrors";
            this.lblTestErrors.Size = new System.Drawing.Size(36, 15);
            this.lblTestErrors.TabIndex = 16;
            this.lblTestErrors.Text = "0";
            this.lblTestErrors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(266, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "2. Run Apex Tests";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "1. Deploy Components";
            // 
            // pbRunApexTests
            // 
            this.pbRunApexTests.Location = new System.Drawing.Point(266, 40);
            this.pbRunApexTests.Maximum = 0;
            this.pbRunApexTests.Name = "pbRunApexTests";
            this.pbRunApexTests.Size = new System.Drawing.Size(232, 23);
            this.pbRunApexTests.TabIndex = 13;
            // 
            // lblCompTotal
            // 
            this.lblCompTotal.AutoSize = true;
            this.lblCompTotal.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompTotal.Location = new System.Drawing.Point(133, 23);
            this.lblCompTotal.Name = "lblCompTotal";
            this.lblCompTotal.Size = new System.Drawing.Size(28, 15);
            this.lblCompTotal.TabIndex = 1;
            this.lblCompTotal.Text = "0/0";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Image = global::SfdcDeployTool.Properties.Resources.close16;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(513, 38);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 25);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCompErrors
            // 
            this.lblCompErrors.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompErrors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCompErrors.Image = global::SfdcDeployTool.Properties.Resources.error16;
            this.lblCompErrors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCompErrors.Location = new System.Drawing.Point(191, 23);
            this.lblCompErrors.Name = "lblCompErrors";
            this.lblCompErrors.Size = new System.Drawing.Size(36, 15);
            this.lblCompErrors.TabIndex = 5;
            this.lblCompErrors.Text = "0";
            this.lblCompErrors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTestTotal
            // 
            this.lblTestTotal.AutoSize = true;
            this.lblTestTotal.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestTotal.Location = new System.Drawing.Point(390, 24);
            this.lblTestTotal.Name = "lblTestTotal";
            this.lblTestTotal.Size = new System.Drawing.Size(28, 15);
            this.lblTestTotal.TabIndex = 7;
            this.lblTestTotal.Text = "0/0";
            // 
            // pbDeployComponents
            // 
            this.pbDeployComponents.Location = new System.Drawing.Point(9, 40);
            this.pbDeployComponents.Maximum = 0;
            this.pbDeployComponents.Name = "pbDeployComponents";
            this.pbDeployComponents.Size = new System.Drawing.Size(232, 23);
            this.pbDeployComponents.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Test Level";
            // 
            // cbTestLevel
            // 
            this.cbTestLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTestLevel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTestLevel.FormattingEnabled = true;
            this.cbTestLevel.Location = new System.Drawing.Point(182, 109);
            this.cbTestLevel.Name = "cbTestLevel";
            this.cbTestLevel.Size = new System.Drawing.Size(290, 23);
            this.cbTestLevel.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Sfdc Deploy Tool";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbTarget.ResumeLayout(false);
            this.gbTarget.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbSource.ResumeLayout(false);
            this.gbSource.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.gbCommand.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.gbLog.ResumeLayout(false);
            this.gbLog.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSourceUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSourceUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSourcePassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTargetUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTargetUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTargetPassword;
        private System.Windows.Forms.GroupBox gbTarget;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.CheckBox cbCleanProfiles;
        private System.Windows.Forms.CheckBox cbCheckOnly;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSpecificTests;
        private System.Windows.Forms.Button btnGetSource;
        private System.Windows.Forms.Button btnSelectPackage;
        private System.Windows.Forms.TextBox txtPackagePath;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.GroupBox gbCommand;
        private System.Windows.Forms.Button btnGetBackup;
        private System.Windows.Forms.Button btnDeployToTarget;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ddEnvSettings;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.ComboBox ddPackages;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDeleteSetting;
        private System.Windows.Forms.ToolStripMenuItem viewUserSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.Label lblCompTotal;
        private System.Windows.Forms.Label lblCompErrors;
        private System.Windows.Forms.Label lblTestTotal;
        private System.Windows.Forms.ProgressBar pbDeployComponents;
        private System.Windows.Forms.ProgressBar pbRunApexTests;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTestErrors;
        private System.Windows.Forms.ComboBox cbTestLevel;
        private System.Windows.Forms.Label label12;
    }
}
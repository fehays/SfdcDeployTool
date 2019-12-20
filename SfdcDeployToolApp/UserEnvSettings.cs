using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfdcDeployTool
{
    [Serializable]
    public class UserEnvSettings
    {
        public string SourceUrl { get; set; }
        public string TargetUrl { get; set; }
        public string SourceUsername { get; set; }
        public string TargetUsername { get; set; }
        public string SourcePassword { get; set; }
        public string TargetPassword { get; set; }
        public bool ValidateOnly { get; set; }
        public bool CleanProfiles { get; set; }
        public string PackageRootPath { get; set; }
        public string SettingName { get; set; }    
    }
}

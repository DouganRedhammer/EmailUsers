using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailUsers
{
    public class Config
    {
        public string domain { get; set; }
        public string ou { get; set; }
        public string dotSuffix { get; set; }
        public string mailServer { get; set; }
        public int mailServerPort { get; set; }
        public string adminEmailAddress { get; set; }
        public string adminEmailPassword { get; set; }

        public Config()
        {
        }

        public Config(string d, string o, string s, string m, int p, string a, string password)
        {
            this.domain = d;
            this.ou = o;
            this.dotSuffix = s;
            this.mailServer = m;
            this.mailServerPort = p;
            this.adminEmailAddress = a;
            this.adminEmailPassword = password;
        }
    }
}

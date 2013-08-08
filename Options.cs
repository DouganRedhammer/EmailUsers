using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailUsers
{
    public partial class Options : Form
    {
        Config configuration;
        public Options()
        {
            InitializeComponent();
        }
        
        public Options(Config currentSettings)
        {
            InitializeComponent();
            this.configuration = currentSettings;
            this.domain_txt.Text = currentSettings.domain;
            this.dotSuffix_txt.Text = currentSettings.dotSuffix;
            this.ou_txt.Text = currentSettings.ou;
            this.mailServer_txt.Text = currentSettings.mailServer;
            this.port_txt.Text = currentSettings.mailServerPort.ToString();
            this.relayAddress_txt.Text = currentSettings.adminEmailAddress;
            this.relayPassword_txt.Text = currentSettings.adminEmailPassword;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            System.Xml.Serialization.XmlSerializer writer =
               new System.Xml.Serialization.XmlSerializer(configuration.GetType());
            System.IO.StreamWriter file =
               new System.IO.StreamWriter("config.xml");

            writer.Serialize(file, configuration);
            file.Close();
        }
        
    }
}

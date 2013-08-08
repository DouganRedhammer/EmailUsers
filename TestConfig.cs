using DomainToolBox;
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
    public partial class TestConfig : Form
    {
        Config configuration;
        DomainTools adminTask;

        public TestConfig(Config currentConfig)
        {
            InitializeComponent();           
            this.configuration = currentConfig;
            adminTask = new DomainTools(configuration.domain, configuration.dotSuffix, configuration.ou);

        }

        private void testDomainSetting()
        {
            if (adminTask.testADConnection())
            {
                testOutput_txt.AppendText("Domain and OU settings are good." + Environment.NewLine);
            }
            else
                testOutput_txt.AppendText("Domain or OU settings are invalid." + Environment.NewLine);
        }

        private void testMailServerSetting()
        {
            if (adminTask.canPingWorkstation(configuration.mailServer))
            {
                testOutput_txt.AppendText("Mail server " + configuration.mailServer + " is reachable." + Environment.NewLine);
            }
            else
                testOutput_txt.AppendText("Unable to reach mail server " + configuration.mailServer + "." + Environment.NewLine);
        }



        private void TestConfig_Load(object sender, EventArgs e)
        {

        }

        private void testStart_btn_Click(object sender, EventArgs e)
        {
            testDomainSetting();
            testMailServerSetting();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

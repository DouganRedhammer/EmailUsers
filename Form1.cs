using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using DomainToolBox;

/*
 *  Need to loop through the Reciepient listbox and email them
 */
namespace EmailUsers
{
    public partial class Form1 : Form
    {
        DomainTools adminTasks;
        List<string> emailAddresses;
        List<Config> settings;
        Config domainSettings;
        public Form1()
        {
            InitializeComponent();
            loadConfig();
            adminTasks = new DomainTools(domainSettings.domain, domainSettings.dotSuffix, domainSettings.ou);
            
           
            

            // Test the OU string
            if (adminTasks.testADConnection())
            {
                emailAddresses = adminTasks.ListDomainUsersEmailAddress();
                removeEmptyCells();
                populateAllEmailAddressesListbox();
                toolStripStatusLabel1.Text = "Ready";
            }
            else
                toolStripStatusLabel1.Text = "No such object in AD";


        }

        private void removeEmptyCells()
        {
            emailAddresses = emailAddresses.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().OrderBy(s=>s).ToList();
        }

        private void populateAllEmailAddressesListbox()
        {
           // allEmailAddresses_listbox.DataSource = emailAddresses;
            foreach (var item in emailAddresses)
            {
                allEmailAddresses_listbox.Items.Add(item);
            }
            allEmailAddresses_listbox.Sorted = true;
        }

        private void addItems()
        {
            foreach (var item in allEmailAddresses_listbox.SelectedItems)
            {
               recipient_listbox.Items.Add(item);
            }
            recipient_listbox.Sorted = true;
        }

        private void removeItems()
        {
            /*
             * note to self without assigning the selected item to a separate list and removing straight from the listbox will cause
             * an Enumeration exception.
             */
            var selectedItems = recipient_listbox.SelectedItems.Cast<String>().ToList();
            foreach (var item in selectedItems)
                recipient_listbox.Items.Remove(item);
           
        }

        private void removeAllEmailAddressItems()
        {
            /*
             * note to self without assigning the selected item to a separate list and removing straight from the listbox will cause
             * an Enumeration exception.
             */
            var allItems = allEmailAddresses_listbox.Items.Cast<String>().ToList();
            foreach (var item in allItems)
                allEmailAddresses_listbox.Items.Remove(item);

        }


        private void loadConfig()
        {
            // Declare a new XML Document
            XmlDocument XmlDoc = new XmlDocument();

            // Try to open the XML file
            try
            {
                XmlDoc.Load("config.xml");
            }
            // Catch "File Not Found" errors
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("No file found!");
            }
            // Catch Argument Exceptions
            catch (System.ArgumentException)
            {
                Console.WriteLine("Invalid path detected!");
            }
            // Catach all other errors, and print them to console.
            catch (Exception err)
            {
                Console.WriteLine("An Exception has been caught:");
            }

            // Declare the xpath for finding objects inside the XML file
            //XmlNodeList XmlDocNodes = XmlDoc.SelectNodes("/Configuration/Settings");
            XmlNodeList XmlDocNodes = XmlDoc.SelectNodes("/Config");
            // Define a new List, to store the objects we pull out of the XML
            settings = new List<Config>();

            // Loop through the nodes, extracting Person information.
            // We can then define a person object and add it to the list.
            foreach (XmlNode node in XmlDocNodes)
            {
                int port = int.Parse(node["mailServerPort"].InnerText);

                domainSettings = new Config(node["domain"].InnerText, node["ou"].InnerText,
                    node["dotSuffix"].InnerText, node["mailServer"].InnerText, port,
                     node["adminEmailAddress"].InnerText, node["adminEmailPassword"].InnerText);
            }

        }


        private void allEmailAddresses_listbox_Entered(object sender, EventArgs e)
        {
            recipient_listbox.ClearSelected();
        }

        private void recipient_listbox_Entered(object sender, EventArgs e)
        {
            allEmailAddresses_listbox.ClearSelected();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addItems();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void subject_lbl_Click(object sender, EventArgs e)
        {

        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            removeItems();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void emailRecipients()
        {
            
            var selectedItems = recipient_listbox.Items.Cast<String>().ToList();
            int numOfselectedItems = selectedItems.Count;
            toolStripProgressBar1.Maximum = numOfselectedItems;
            int counter = 0;
            foreach (var address in selectedItems)
            {
                counter++;
                adminTasks.SendEmail(domainSettings.mailServer, domainSettings.mailServerPort, domainSettings.adminEmailAddress,
                    address, subject_txt.Text, message_txt.Text, domainSettings.adminEmailPassword);
                toolStripStatusLabel1.Text = "Message Sent to:" + address;
                toolStripProgressBar1.Increment( counter);
                toolStripProgressBar1.PerformStep();
            }     
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            int addressCount = recipient_listbox.Items.Count;
            if (addressCount >= 10)
            {
                DialogResult msgResult = MessageBox.Show("Click yes to send the email(s). Are you sure you want to email these "+addressCount + " addresses?", "Important Query",
                                      MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(msgResult == DialogResult.Yes)
                    emailRecipients();
            }
            else
                emailRecipients();
            
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options opts = new Options(domainSettings);
            opts.Show();
        }

        private void addAll_btn_Click(object sender, EventArgs e)
        {
            var allItems = allEmailAddresses_listbox.Items.Cast<String>().ToList();
            foreach (var item in allItems)
                recipient_listbox.Items.Add(item);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            var allItems = recipient_listbox.Items.Cast<String>().ToList();
            foreach (var item in allItems)
                recipient_listbox.Items.Remove(item);
        }

        private void clearAll_btn_Click(object sender, EventArgs e)
        {
            subject_txt.Clear();
            message_txt.Clear();
            recipient_listbox.Items.Clear();
            toolStripProgressBar1.Value = 0;
            toolStripStatusLabel1.Text = "Ready";

        }

        public void updateConfig(Config newConfig)
        {
            domainSettings = newConfig;
            removeAllEmailAddressItems();
            populateAllEmailAddressesListbox();
        }

        private void testConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestConfig configTest = new TestConfig(this.domainSettings);
            configTest.Show();
        }

    }
}

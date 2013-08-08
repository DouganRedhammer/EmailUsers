namespace EmailUsers
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.allEmailAddresses_listbox = new System.Windows.Forms.ListBox();
            this.removeItem = new System.Windows.Forms.Button();
            this.recipient_listbox = new System.Windows.Forms.ListBox();
            this.addItem = new System.Windows.Forms.Button();
            this.allAddresses_lbl = new System.Windows.Forms.Label();
            this.recipient_lbl = new System.Windows.Forms.Label();
            this.subject_lbl = new System.Windows.Forms.Label();
            this.subject_txt = new System.Windows.Forms.TextBox();
            this.message_lbl = new System.Windows.Forms.Label();
            this.message_txt = new System.Windows.Forms.TextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.addAll_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.clearAll_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // allEmailAddresses_listbox
            // 
            this.allEmailAddresses_listbox.FormattingEnabled = true;
            this.allEmailAddresses_listbox.Location = new System.Drawing.Point(13, 44);
            this.allEmailAddresses_listbox.Name = "allEmailAddresses_listbox";
            this.allEmailAddresses_listbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.allEmailAddresses_listbox.Size = new System.Drawing.Size(172, 160);
            this.allEmailAddresses_listbox.TabIndex = 0;
            this.allEmailAddresses_listbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.allEmailAddresses_listbox.Enter += new System.EventHandler(this.allEmailAddresses_listbox_Entered);
            // 
            // removeItem
            // 
            this.removeItem.Location = new System.Drawing.Point(198, 98);
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(63, 23);
            this.removeItem.TabIndex = 1;
            this.removeItem.Text = "<<";
            this.removeItem.UseVisualStyleBackColor = true;
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // recipient_listbox
            // 
            this.recipient_listbox.FormattingEnabled = true;
            this.recipient_listbox.Location = new System.Drawing.Point(275, 44);
            this.recipient_listbox.Name = "recipient_listbox";
            this.recipient_listbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.recipient_listbox.Size = new System.Drawing.Size(175, 160);
            this.recipient_listbox.TabIndex = 2;
            this.recipient_listbox.UseTabStops = false;
            this.recipient_listbox.Enter += new System.EventHandler(this.recipient_listbox_Entered);
            // 
            // addItem
            // 
            this.addItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addItem.Location = new System.Drawing.Point(198, 69);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(63, 23);
            this.addItem.TabIndex = 3;
            this.addItem.Text = ">>";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // allAddresses_lbl
            // 
            this.allAddresses_lbl.AutoSize = true;
            this.allAddresses_lbl.Location = new System.Drawing.Point(13, 29);
            this.allAddresses_lbl.Name = "allAddresses_lbl";
            this.allAddresses_lbl.Size = new System.Drawing.Size(70, 13);
            this.allAddresses_lbl.TabIndex = 4;
            this.allAddresses_lbl.Text = "All Addresses";
            this.allAddresses_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // recipient_lbl
            // 
            this.recipient_lbl.AutoSize = true;
            this.recipient_lbl.Location = new System.Drawing.Point(273, 29);
            this.recipient_lbl.Name = "recipient_lbl";
            this.recipient_lbl.Size = new System.Drawing.Size(79, 13);
            this.recipient_lbl.TabIndex = 5;
            this.recipient_lbl.Text = "Mail Recipients";
            // 
            // subject_lbl
            // 
            this.subject_lbl.AutoSize = true;
            this.subject_lbl.Location = new System.Drawing.Point(10, 214);
            this.subject_lbl.Name = "subject_lbl";
            this.subject_lbl.Size = new System.Drawing.Size(43, 13);
            this.subject_lbl.TabIndex = 6;
            this.subject_lbl.Text = "Subject";
            this.subject_lbl.Click += new System.EventHandler(this.subject_lbl_Click);
            // 
            // subject_txt
            // 
            this.subject_txt.Location = new System.Drawing.Point(12, 229);
            this.subject_txt.Name = "subject_txt";
            this.subject_txt.Size = new System.Drawing.Size(438, 20);
            this.subject_txt.TabIndex = 7;
            this.subject_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // message_lbl
            // 
            this.message_lbl.AutoSize = true;
            this.message_lbl.Location = new System.Drawing.Point(10, 252);
            this.message_lbl.Name = "message_lbl";
            this.message_lbl.Size = new System.Drawing.Size(50, 13);
            this.message_lbl.TabIndex = 8;
            this.message_lbl.Text = "Message";
            // 
            // message_txt
            // 
            this.message_txt.Location = new System.Drawing.Point(12, 268);
            this.message_txt.Multiline = true;
            this.message_txt.Name = "message_txt";
            this.message_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.message_txt.Size = new System.Drawing.Size(438, 114);
            this.message_txt.TabIndex = 9;
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(374, 388);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(75, 23);
            this.send_btn.TabIndex = 10;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(347, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(464, 22);
            this.statusStrip.TabIndex = 11;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // addAll_btn
            // 
            this.addAll_btn.Location = new System.Drawing.Point(198, 127);
            this.addAll_btn.Name = "addAll_btn";
            this.addAll_btn.Size = new System.Drawing.Size(63, 23);
            this.addAll_btn.TabIndex = 12;
            this.addAll_btn.Text = "Add All";
            this.addAll_btn.UseVisualStyleBackColor = true;
            this.addAll_btn.Click += new System.EventHandler(this.addAll_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(198, 156);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(63, 23);
            this.clear_btn.TabIndex = 13;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // clearAll_btn
            // 
            this.clearAll_btn.Location = new System.Drawing.Point(305, 388);
            this.clearAll_btn.Name = "clearAll_btn";
            this.clearAll_btn.Size = new System.Drawing.Size(63, 23);
            this.clearAll_btn.TabIndex = 14;
            this.clearAll_btn.Text = "Clear All";
            this.clearAll_btn.UseVisualStyleBackColor = true;
            this.clearAll_btn.Click += new System.EventHandler(this.clearAll_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(464, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.testConfigToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Visible = false;
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // testConfigToolStripMenuItem
            // 
            this.testConfigToolStripMenuItem.Name = "testConfigToolStripMenuItem";
            this.testConfigToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testConfigToolStripMenuItem.Text = "Test Config";
            this.testConfigToolStripMenuItem.Click += new System.EventHandler(this.testConfigToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.clearAll_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.addAll_btn);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.message_txt);
            this.Controls.Add(this.message_lbl);
            this.Controls.Add(this.subject_txt);
            this.Controls.Add(this.subject_lbl);
            this.Controls.Add(this.recipient_lbl);
            this.Controls.Add(this.allAddresses_lbl);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.recipient_listbox);
            this.Controls.Add(this.removeItem);
            this.Controls.Add(this.allEmailAddresses_listbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Domain Emailer";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox allEmailAddresses_listbox;
        private System.Windows.Forms.Button removeItem;
        private System.Windows.Forms.ListBox recipient_listbox;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Label allAddresses_lbl;
        private System.Windows.Forms.Label recipient_lbl;
        private System.Windows.Forms.Label subject_lbl;
        private System.Windows.Forms.TextBox subject_txt;
        private System.Windows.Forms.Label message_lbl;
        private System.Windows.Forms.TextBox message_txt;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button addAll_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button clearAll_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testConfigToolStripMenuItem;
    }
}


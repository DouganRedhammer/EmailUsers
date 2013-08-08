namespace EmailUsers
{
    partial class Options
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
            this.label1 = new System.Windows.Forms.Label();
            this.domain_txt = new System.Windows.Forms.TextBox();
            this.dotSuffix_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ou_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mailServer_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.relayAddress_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.port_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.relayPassword_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domain";
            // 
            // domain_txt
            // 
            this.domain_txt.Location = new System.Drawing.Point(114, 45);
            this.domain_txt.Name = "domain_txt";
            this.domain_txt.Size = new System.Drawing.Size(226, 20);
            this.domain_txt.TabIndex = 1;
            // 
            // dotSuffix_txt
            // 
            this.dotSuffix_txt.Location = new System.Drawing.Point(114, 78);
            this.dotSuffix_txt.Name = "dotSuffix_txt";
            this.dotSuffix_txt.Size = new System.Drawing.Size(226, 20);
            this.dotSuffix_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DotSuffix";
            // 
            // ou_txt
            // 
            this.ou_txt.Location = new System.Drawing.Point(114, 111);
            this.ou_txt.Name = "ou_txt";
            this.ou_txt.Size = new System.Drawing.Size(226, 20);
            this.ou_txt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "OU";
            // 
            // mailServer_txt
            // 
            this.mailServer_txt.Location = new System.Drawing.Point(114, 144);
            this.mailServer_txt.Name = "mailServer_txt";
            this.mailServer_txt.Size = new System.Drawing.Size(226, 20);
            this.mailServer_txt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mail Server";
            // 
            // relayAddress_txt
            // 
            this.relayAddress_txt.Location = new System.Drawing.Point(114, 210);
            this.relayAddress_txt.Name = "relayAddress_txt";
            this.relayAddress_txt.Size = new System.Drawing.Size(226, 20);
            this.relayAddress_txt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Relay EmailAddress";
            // 
            // port_txt
            // 
            this.port_txt.Location = new System.Drawing.Point(114, 177);
            this.port_txt.Name = "port_txt";
            this.port_txt.Size = new System.Drawing.Size(226, 20);
            this.port_txt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Port";
            // 
            // relayPassword_txt
            // 
            this.relayPassword_txt.Location = new System.Drawing.Point(114, 243);
            this.relayPassword_txt.Name = "relayPassword_txt";
            this.relayPassword_txt.Size = new System.Drawing.Size(226, 20);
            this.relayPassword_txt.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Password";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(252, 284);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(88, 23);
            this.save_btn.TabIndex = 14;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(159, 284);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(88, 23);
            this.cancel_btn.TabIndex = 15;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 329);
            this.ControlBox = false;
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.relayPassword_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.port_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.relayAddress_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mailServer_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ou_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dotSuffix_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.domain_txt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.ShowInTaskbar = false;
            this.Text = "Options";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox domain_txt;
        private System.Windows.Forms.TextBox dotSuffix_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ou_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mailServer_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox relayAddress_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox port_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox relayPassword_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}
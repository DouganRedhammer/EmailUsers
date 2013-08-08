namespace EmailUsers
{
    partial class TestConfig
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
            this.testOutput_txt = new System.Windows.Forms.TextBox();
            this.testStart_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testOutput_txt
            // 
            this.testOutput_txt.BackColor = System.Drawing.SystemColors.Info;
            this.testOutput_txt.Location = new System.Drawing.Point(23, 41);
            this.testOutput_txt.Multiline = true;
            this.testOutput_txt.Name = "testOutput_txt";
            this.testOutput_txt.ReadOnly = true;
            this.testOutput_txt.Size = new System.Drawing.Size(330, 126);
            this.testOutput_txt.TabIndex = 0;
            this.testOutput_txt.WordWrap = false;
            // 
            // testStart_btn
            // 
            this.testStart_btn.Location = new System.Drawing.Point(278, 173);
            this.testStart_btn.Name = "testStart_btn";
            this.testStart_btn.Size = new System.Drawing.Size(75, 23);
            this.testStart_btn.TabIndex = 1;
            this.testStart_btn.Text = "Start Test";
            this.testStart_btn.UseVisualStyleBackColor = true;
            this.testStart_btn.Click += new System.EventHandler(this.testStart_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(197, 173);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 2;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // TestConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 251);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.testStart_btn);
            this.Controls.Add(this.testOutput_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TestConfig";
            this.ShowInTaskbar = false;
            this.Text = "TestConfig";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TestConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox testOutput_txt;
        private System.Windows.Forms.Button testStart_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}
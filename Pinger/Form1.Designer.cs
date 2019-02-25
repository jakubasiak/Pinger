namespace Pinger
{
    partial class pinger
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
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblPingFrequency = new System.Windows.Forms.Label();
            this.txtPingFrequency = new System.Windows.Forms.TextBox();
            this.txtLastUpdate = new System.Windows.Forms.TextBox();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.checkAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(26, 22);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(29, 13);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "URL";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(119, 19);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(143, 20);
            this.txtUrl.TabIndex = 2;
            // 
            // lblPingFrequency
            // 
            this.lblPingFrequency.AutoSize = true;
            this.lblPingFrequency.Location = new System.Drawing.Point(26, 53);
            this.lblPingFrequency.Name = "lblPingFrequency";
            this.lblPingFrequency.Size = new System.Drawing.Size(78, 13);
            this.lblPingFrequency.TabIndex = 3;
            this.lblPingFrequency.Text = "Ping frequency";
            // 
            // txtPingFrequency
            // 
            this.txtPingFrequency.Location = new System.Drawing.Point(119, 50);
            this.txtPingFrequency.Name = "txtPingFrequency";
            this.txtPingFrequency.Size = new System.Drawing.Size(143, 20);
            this.txtPingFrequency.TabIndex = 4;
            this.txtPingFrequency.Text = "1000";
            // 
            // txtLastUpdate
            // 
            this.txtLastUpdate.Location = new System.Drawing.Point(119, 83);
            this.txtLastUpdate.Name = "txtLastUpdate";
            this.txtLastUpdate.Size = new System.Drawing.Size(143, 20);
            this.txtLastUpdate.TabIndex = 6;
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.Location = new System.Drawing.Point(26, 86);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(63, 13);
            this.lblLastUpdate.TabIndex = 5;
            this.lblLastUpdate.Text = "Last update";
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(297, 19);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(490, 400);
            this.webBrowser.TabIndex = 7;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(29, 117);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(119, 117);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // checkAlwaysOnTop
            // 
            this.checkAlwaysOnTop.AutoSize = true;
            this.checkAlwaysOnTop.Location = new System.Drawing.Point(29, 405);
            this.checkAlwaysOnTop.Name = "checkAlwaysOnTop";
            this.checkAlwaysOnTop.Size = new System.Drawing.Size(92, 17);
            this.checkAlwaysOnTop.TabIndex = 10;
            this.checkAlwaysOnTop.Text = "Always on top";
            this.checkAlwaysOnTop.UseVisualStyleBackColor = true;
            this.checkAlwaysOnTop.CheckedChanged += new System.EventHandler(this.checkAlwaysOnTop_CheckedChanged);
            // 
            // pinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkAlwaysOnTop);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.txtLastUpdate);
            this.Controls.Add(this.lblLastUpdate);
            this.Controls.Add(this.txtPingFrequency);
            this.Controls.Add(this.lblPingFrequency);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.Name = "pinger";
            this.Text = "Pinger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblPingFrequency;
        private System.Windows.Forms.TextBox txtPingFrequency;
        private System.Windows.Forms.TextBox txtLastUpdate;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox checkAlwaysOnTop;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Pinger
{
    public partial class pinger : Form
    {
        private bool isRunning = false;
        private string webContent = string.Empty;
        public pinger()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            this.Text = "Pinger - Nothing hanged";
            this.BackColor = SystemColors.Control;

            int frequency = 1000;
            Int32.TryParse(this.txtPingFrequency.Text, out frequency);
            this.isRunning = true;
            var url = this.txtUrl.Text;
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Navigate(url);

            using (HttpClient client = new HttpClient())
            {
                while (this.isRunning)
                {
                    try
                    {
                        HttpResponseMessage response = await client.GetAsync(url);
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();
                        this.txtLastUpdate.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

                        if (!string.IsNullOrEmpty(this.webContent))
                        {
                            if (string.Equals(this.webContent, responseBody))
                            {
                                this.isRunning = false;
                                this.Text = "Pinger - Something changed";
                                this.BackColor = Color.Red;
                                this.webBrowser.Refresh();
                            }
                        }
                        else
                        {
                            this.webContent = responseBody;
                        }

                        Thread.Sleep(frequency);
                    }
                    catch (HttpRequestException err)
                    {
                        this.webBrowser.Text = err.Message;
                        this.Text = "Pinger";
                        this.BackColor = SystemColors.Control;
                    }
                }
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.isRunning = false;
            this.Text = "Pinger";
            this.BackColor = SystemColors.Control;
        }

        private void checkAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkAlwaysOnTop.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }
    }
}

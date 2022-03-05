using System;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Artifacts_Downloader
{
    public partial class redmW : Form
    {
        public redmW()
        {
            InitializeComponent();
            updateTextVersion("recommended");
            updateTextVersion("optional");
            updateTextVersion("latest");
            updateTextVersion("critical");
        }

        private void btnRecommended_Click(object sender, EventArgs e)
        {
            artifactsDownload("recommended_download");
        }

        private void btnOptional_Click(object sender, EventArgs e)
        {
            artifactsDownload("optional_download");
        }

        private void btnLatest_Click(object sender, EventArgs e)
        {
            artifactsDownload("latest_download");
        }

        private void btnCritical_Click(object sender, EventArgs e)
        {
            artifactsDownload("critical_download");
        }

        private void artifactsDownload(string file)
        {
            buttonsBlock(false);
            pgsDownload.Value = 0;
            tProgress.Start();

            WebClient client = new WebClient();
            string url = client.DownloadString("https://changelogs-live.fivem.net/api/changelog/versions/win32/server");
            dynamic dynamic = JsonConvert.DeserializeObject<dynamic>(url);
            string temp = dynamic[file];
            if (Directory.Exists("artifacts"))
            {
                Directory.Delete("artifacts", true);
                Directory.CreateDirectory("artifacts");
            }
            else
            {
                Directory.CreateDirectory("artifacts");
            }
            client.DownloadFile(temp, $@"artifacts\{file}.zip");

            string zipFilePath = $@"artifacts\{file}.zip";
            string extractionPath = @"artifacts";
            ZipFile.ExtractToDirectory(zipFilePath, extractionPath);
            File.Delete(zipFilePath);
        }

        private void updateTextVersion(string file)
        {
            WebClient client = new WebClient();
            string url = client.DownloadString("https://changelogs-live.fivem.net/api/changelog/versions/win32/server");
            dynamic dynamic = JsonConvert.DeserializeObject<dynamic>(url);
            string temp = dynamic[file];

            if (file == "recommended")
            {
                txtRecommended.Text = temp;
            }
            else if (file == "optional")
            {
                txtOptional.Text = temp;
            }
            else if (file == "latest")
            {
                txtLatest.Text = temp;
            }
            else if (file == "critical")
            {
                txtCritical.Text = temp;
            }
        }

        private void tProgress_Tick(object sender, EventArgs e)
        {
            if (pgsDownload.Value < 100)
            {
                pgsDownload.Value += 20;
            }
            else
            {
                tProgress.Stop();
                MessageBox.Show("Download and Extracted completed.", "Warning");
                buttonsBlock(true);
            }
        }

        private void buttonsBlock(bool status)
        {
            btnRecommended.Enabled = status;
            btnOptional.Enabled = status;
            btnLatest.Enabled = status;
            btnCritical.Enabled = status;
        }
    }
}

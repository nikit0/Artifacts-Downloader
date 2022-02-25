using System;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Artifacts_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRecommended_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = client.DownloadString("https://changelogs-live.fivem.net/api/changelog/versions/win32/server");
            dynamic dynamic = JsonConvert.DeserializeObject<dynamic>(url);
            string temp = dynamic["recommended_download"].ToString();
            if (Directory.Exists("artifacts"))
            {
                Directory.Delete("artifacts", true);
                Directory.CreateDirectory("artifacts");
            } else
            {
                Directory.CreateDirectory("artifacts");
            }
            client.DownloadFile(temp, @"artifacts\recommended.zip");
            MessageBox.Show("Download completed.");

            string zipFilePath = @"artifacts\recommended.zip";
            string extractionPath = @"artifacts";
            ZipFile.ExtractToDirectory(zipFilePath, extractionPath);
            MessageBox.Show("Extracted successfully.");
            File.Delete(zipFilePath);
        }

        private void btnOptional_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = client.DownloadString("https://changelogs-live.fivem.net/api/changelog/versions/win32/server");
            dynamic dynamic = JsonConvert.DeserializeObject<dynamic>(url);
            string temp = dynamic["optional_download"].ToString();
            if (Directory.Exists("artifacts"))
            {
                Directory.Delete("artifacts", true);
                Directory.CreateDirectory("artifacts");
            }
            else
            {
                Directory.CreateDirectory("artifacts");
            }
            client.DownloadFile(temp, @"artifacts\optional.zip");
            MessageBox.Show("Download completed.");

            string zipFilePath = @"artifacts\optional.zip";
            string extractionPath = @"artifacts";
            ZipFile.ExtractToDirectory(zipFilePath, extractionPath);
            MessageBox.Show("Extracted successfully.");
            File.Delete(zipFilePath);
        }

        private void btnLatest_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = client.DownloadString("https://changelogs-live.fivem.net/api/changelog/versions/win32/server");
            dynamic dynamic = JsonConvert.DeserializeObject<dynamic>(url);
            string temp = dynamic["latest_download"].ToString();
            if (Directory.Exists("artifacts"))
            {
                Directory.Delete("artifacts", true);
                Directory.CreateDirectory("artifacts");
            }
            else
            {
                Directory.CreateDirectory("artifacts");
            }
            client.DownloadFile(temp, @"artifacts\latest.zip");
            MessageBox.Show("Download completed.");

            string zipFilePath = @"artifacts\latest.zip";
            string extractionPath = @"artifacts";
            ZipFile.ExtractToDirectory(zipFilePath, extractionPath);
            MessageBox.Show("Extracted successfully.");
            File.Delete(zipFilePath);
        }

        private void btnCritical_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string url = client.DownloadString("https://changelogs-live.fivem.net/api/changelog/versions/win32/server");
            dynamic dynamic = JsonConvert.DeserializeObject<dynamic>(url);
            string temp = dynamic["critical_download"].ToString();
            if (Directory.Exists("artifacts"))
            {
                Directory.Delete("artifacts", true);
                Directory.CreateDirectory("artifacts");
            }
            else
            {
                Directory.CreateDirectory("artifacts");
            }
            client.DownloadFile(temp, @"artifacts\critical.zip");
            MessageBox.Show("Download completed.");

            string zipFilePath = @"artifacts\critical.zip";
            string extractionPath = @"artifacts";
            ZipFile.ExtractToDirectory(zipFilePath, extractionPath);
            MessageBox.Show("Extracted successfully.");
            File.Delete(zipFilePath);
        }

        private void pgsDownload_Click(object sender, EventArgs e)
        {
            
        }
    }
}
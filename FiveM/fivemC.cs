using System;
using System.IO;
using System.Windows.Forms;

namespace Artifacts_Downloader
{
    public partial class fivemC : Form
    {
        public fivemC()
        {
            InitializeComponent();
        }

        private void btnCacheC_Click(object sender, EventArgs e)
        {
            clearCache("cache");
        }

        private void btnGameC_Click(object sender, EventArgs e)
        {
            clearCache("game-storage");
        }

        private void btnNuiC_Click(object sender, EventArgs e)
        {
            clearCache("nui-storage");
        }

        private void btnServerC_Click(object sender, EventArgs e)
        {
            clearCache("server-cache");
            clearCache("server-cache-priv");
        }

        private void btnCacheS_Click(object sender, EventArgs e)
        {
            clearCache("cache");
        }

        private void clearCache(string folder)
        {
            buttonsBlock(false);
            pgsDownload.Value = 0;
            tProgress.Start();

            string pathC = Environment.ExpandEnvironmentVariables($@"C:\Users\%USERNAME%\AppData\Local\FiveM\FiveM.app\data\{folder}");
            string pathS = Environment.ExpandEnvironmentVariables($@".\{folder}");

            if (Directory.Exists(pathC))
            {
                Directory.Delete(pathC, true);
            }

            if (Directory.Exists(pathS))
            {
                Directory.Delete(pathS, true);
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
                buttonsBlock(true);
            }
        }

        private void buttonsBlock(bool status)
        {
            btnCacheC.Enabled = status;
            btnGameC.Enabled = status;
            btnNuiC.Enabled = status;
            btnServerC.Enabled = status;
            btnCacheS.Enabled = status;
        }
    }
}
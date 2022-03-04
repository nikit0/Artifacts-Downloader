using System;
using System.IO;
using System.Windows.Forms;

namespace Artifacts_Downloader
{
    public partial class cache : Form
    {
        public cache()
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
    }
}
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Artifacts_Downloader
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void menuFivemW_Click(object sender, EventArgs e)
        {
            openChildForm(new fivemW());
        }

        private void menuFivemL_Click(object sender, EventArgs e)
        {
            openChildForm(new fivemL());
        }

        private void menuRedmW_Click(object sender, EventArgs e)
        {
            openChildForm(new redmW());
        }

        private void menuChangelogs_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/nikit0/Artifacts-Downloader/commits/master");
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/nikit0/Artifacts-Downloader#readme");
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pIndex.Controls.Add(childForm);
            pIndex.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
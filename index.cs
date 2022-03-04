using System;
using System.Windows.Forms;

namespace Artifacts_Downloader
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void menuWindows_Click(object sender, EventArgs e)
        {
            openChildForm(new fivemW());
        }

        private void menuLinux_Click(object sender, EventArgs e)
        {
            openChildForm(new fivemL());
        }

        private void menuClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuRedM_Click(object sender, EventArgs e)
        {
            openChildForm(new redmW());
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
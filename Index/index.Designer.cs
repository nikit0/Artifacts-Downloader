namespace Artifacts_Downloader
{
    partial class index
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.tProgress = new System.Windows.Forms.Timer(this.components);
            this.menuIndex = new System.Windows.Forms.MenuStrip();
            this.menuFiveM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFivemW = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFivemL = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorFivem = new System.Windows.Forms.ToolStripSeparator();
            this.menuFivemC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRedM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRedmW = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorRedm = new System.Windows.Forms.ToolStripSeparator();
            this.menuRedmC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChangelogs = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorHelp = new System.Windows.Forms.ToolStripSeparator();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pIndex = new System.Windows.Forms.Panel();
            this.signature = new System.Windows.Forms.Label();
            this.fx = new System.Windows.Forms.PictureBox();
            this.menuIndex.SuspendLayout();
            this.pIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fx)).BeginInit();
            this.SuspendLayout();
            // 
            // menuIndex
            // 
            this.menuIndex.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFiveM,
            this.menuRedM,
            this.menuHelp});
            this.menuIndex.Location = new System.Drawing.Point(0, 0);
            this.menuIndex.Name = "menuIndex";
            this.menuIndex.Size = new System.Drawing.Size(604, 24);
            this.menuIndex.TabIndex = 11;
            this.menuIndex.Text = "menuIndex";
            // 
            // menuFiveM
            // 
            this.menuFiveM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFivemW,
            this.menuFivemL,
            this.separatorFivem,
            this.menuFivemC});
            this.menuFiveM.Image = ((System.Drawing.Image)(resources.GetObject("menuFiveM.Image")));
            this.menuFiveM.Name = "menuFiveM";
            this.menuFiveM.Size = new System.Drawing.Size(67, 20);
            this.menuFiveM.Text = "FiveM";
            // 
            // menuFivemW
            // 
            this.menuFivemW.Image = ((System.Drawing.Image)(resources.GetObject("menuFivemW.Image")));
            this.menuFivemW.Name = "menuFivemW";
            this.menuFivemW.Size = new System.Drawing.Size(123, 22);
            this.menuFivemW.Text = "Windows";
            this.menuFivemW.Click += new System.EventHandler(this.menuFivemW_Click);
            // 
            // menuFivemL
            // 
            this.menuFivemL.Image = ((System.Drawing.Image)(resources.GetObject("menuFivemL.Image")));
            this.menuFivemL.Name = "menuFivemL";
            this.menuFivemL.Size = new System.Drawing.Size(123, 22);
            this.menuFivemL.Text = "Linux";
            this.menuFivemL.Click += new System.EventHandler(this.menuFivemL_Click);
            // 
            // separatorFivem
            // 
            this.separatorFivem.Name = "separatorFivem";
            this.separatorFivem.Size = new System.Drawing.Size(120, 6);
            // 
            // menuFivemC
            // 
            this.menuFivemC.Image = ((System.Drawing.Image)(resources.GetObject("menuFivemC.Image")));
            this.menuFivemC.Name = "menuFivemC";
            this.menuFivemC.Size = new System.Drawing.Size(123, 22);
            this.menuFivemC.Text = "Cache";
            this.menuFivemC.Click += new System.EventHandler(this.menuFivemC_Click);
            // 
            // menuRedM
            // 
            this.menuRedM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRedmW,
            this.separatorRedm,
            this.menuRedmC});
            this.menuRedM.Image = ((System.Drawing.Image)(resources.GetObject("menuRedM.Image")));
            this.menuRedM.Name = "menuRedM";
            this.menuRedM.Size = new System.Drawing.Size(66, 20);
            this.menuRedM.Text = "RedM";
            // 
            // menuRedmW
            // 
            this.menuRedmW.Image = ((System.Drawing.Image)(resources.GetObject("menuRedmW.Image")));
            this.menuRedmW.Name = "menuRedmW";
            this.menuRedmW.Size = new System.Drawing.Size(123, 22);
            this.menuRedmW.Text = "Windows";
            this.menuRedmW.Click += new System.EventHandler(this.menuRedmW_Click);
            // 
            // separatorRedm
            // 
            this.separatorRedm.Name = "separatorRedm";
            this.separatorRedm.Size = new System.Drawing.Size(120, 6);
            // 
            // menuRedmC
            // 
            this.menuRedmC.Image = ((System.Drawing.Image)(resources.GetObject("menuRedmC.Image")));
            this.menuRedmC.Name = "menuRedmC";
            this.menuRedmC.Size = new System.Drawing.Size(123, 22);
            this.menuRedmC.Text = "Cache";
            this.menuRedmC.Click += new System.EventHandler(this.menuRedmC_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChangelogs,
            this.separatorHelp,
            this.menuAbout});
            this.menuHelp.Image = ((System.Drawing.Image)(resources.GetObject("menuHelp.Image")));
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(60, 20);
            this.menuHelp.Text = "Help";
            // 
            // menuChangelogs
            // 
            this.menuChangelogs.Image = ((System.Drawing.Image)(resources.GetObject("menuChangelogs.Image")));
            this.menuChangelogs.Name = "menuChangelogs";
            this.menuChangelogs.Size = new System.Drawing.Size(180, 22);
            this.menuChangelogs.Text = "Changelogs";
            this.menuChangelogs.Click += new System.EventHandler(this.menuChangelogs_Click);
            // 
            // separatorHelp
            // 
            this.separatorHelp.Name = "separatorHelp";
            this.separatorHelp.Size = new System.Drawing.Size(177, 6);
            // 
            // menuAbout
            // 
            this.menuAbout.Image = ((System.Drawing.Image)(resources.GetObject("menuAbout.Image")));
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(180, 22);
            this.menuAbout.Text = "About...";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // pIndex
            // 
            this.pIndex.Controls.Add(this.signature);
            this.pIndex.Controls.Add(this.fx);
            this.pIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pIndex.Location = new System.Drawing.Point(0, 24);
            this.pIndex.Name = "pIndex";
            this.pIndex.Size = new System.Drawing.Size(604, 396);
            this.pIndex.TabIndex = 12;
            // 
            // signature
            // 
            this.signature.AutoSize = true;
            this.signature.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signature.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signature.Location = new System.Drawing.Point(3, 364);
            this.signature.Name = "signature";
            this.signature.Size = new System.Drawing.Size(119, 23);
            this.signature.TabIndex = 29;
            this.signature.Text = "Created by nikit0";
            // 
            // fx
            // 
            this.fx.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fx.ErrorImage = null;
            this.fx.Image = ((System.Drawing.Image)(resources.GetObject("fx.Image")));
            this.fx.Location = new System.Drawing.Point(235, 132);
            this.fx.Name = "fx";
            this.fx.Size = new System.Drawing.Size(128, 128);
            this.fx.TabIndex = 0;
            this.fx.TabStop = false;
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(604, 420);
            this.Controls.Add(this.pIndex);
            this.Controls.Add(this.menuIndex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuIndex;
            this.MaximizeBox = false;
            this.Name = "index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artifacts Downloader";
            this.menuIndex.ResumeLayout(false);
            this.menuIndex.PerformLayout();
            this.pIndex.ResumeLayout(false);
            this.pIndex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tProgress;
        private System.Windows.Forms.MenuStrip menuIndex;
        private System.Windows.Forms.ToolStripMenuItem menuFiveM;
        private System.Windows.Forms.ToolStripMenuItem menuFivemW;
        private System.Windows.Forms.ToolStripMenuItem menuFivemL;
        private System.Windows.Forms.ToolStripMenuItem menuRedM;
        private System.Windows.Forms.Panel pIndex;
        private System.Windows.Forms.PictureBox fx;
        private System.Windows.Forms.Label signature;
        private System.Windows.Forms.ToolStripMenuItem menuRedmW;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuChangelogs;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripSeparator separatorHelp;
        private System.Windows.Forms.ToolStripSeparator separatorFivem;
        private System.Windows.Forms.ToolStripMenuItem menuFivemC;
        private System.Windows.Forms.ToolStripSeparator separatorRedm;
        private System.Windows.Forms.ToolStripMenuItem menuRedmC;
    }
}


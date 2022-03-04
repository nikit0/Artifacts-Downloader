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
            this.menuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLinux = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRedM = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuRedM});
            this.menuIndex.Location = new System.Drawing.Point(0, 0);
            this.menuIndex.Name = "menuIndex";
            this.menuIndex.Size = new System.Drawing.Size(604, 24);
            this.menuIndex.TabIndex = 11;
            this.menuIndex.Text = "menuIndex";
            // 
            // menuFiveM
            // 
            this.menuFiveM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWindows,
            this.menuLinux,
            this.toolStripSeparator1,
            this.menuClose});
            this.menuFiveM.Name = "menuFiveM";
            this.menuFiveM.Size = new System.Drawing.Size(51, 20);
            this.menuFiveM.Text = "FiveM";
            // 
            // menuWindows
            // 
            this.menuWindows.Name = "menuWindows";
            this.menuWindows.Size = new System.Drawing.Size(180, 22);
            this.menuWindows.Text = "Windows";
            this.menuWindows.Click += new System.EventHandler(this.menuWindows_Click);
            // 
            // menuLinux
            // 
            this.menuLinux.Name = "menuLinux";
            this.menuLinux.Size = new System.Drawing.Size(180, 22);
            this.menuLinux.Text = "Linux";
            this.menuLinux.Click += new System.EventHandler(this.menuLinux_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuClose
            // 
            this.menuClose.Name = "menuClose";
            this.menuClose.Size = new System.Drawing.Size(180, 22);
            this.menuClose.Text = "Close";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // menuRedM
            // 
            this.menuRedM.Enabled = false;
            this.menuRedM.Name = "menuRedM";
            this.menuRedM.Size = new System.Drawing.Size(50, 20);
            this.menuRedM.Text = "RedM";
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
        private System.Windows.Forms.ToolStripMenuItem menuWindows;
        private System.Windows.Forms.ToolStripMenuItem menuLinux;
        private System.Windows.Forms.ToolStripMenuItem menuRedM;
        private System.Windows.Forms.Panel pIndex;
        private System.Windows.Forms.PictureBox fx;
        private System.Windows.Forms.Label signature;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
    }
}


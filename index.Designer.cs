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
            this.btnRecommended = new System.Windows.Forms.Button();
            this.btnOptional = new System.Windows.Forms.Button();
            this.btnLatest = new System.Windows.Forms.Button();
            this.btnCritical = new System.Windows.Forms.Button();
            this.pgsDownload = new System.Windows.Forms.ProgressBar();
            this.downloads = new System.Windows.Forms.Label();
            this.signature = new System.Windows.Forms.Label();
            this.tProgress = new System.Windows.Forms.Timer(this.components);
            this.txtRecommended = new System.Windows.Forms.Label();
            this.txtOptional = new System.Windows.Forms.Label();
            this.txtLatest = new System.Windows.Forms.Label();
            this.txtCritical = new System.Windows.Forms.Label();
            this.menuIndex = new System.Windows.Forms.MenuStrip();
            this.menuFiveM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLinux = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRedM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIndex.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRecommended
            // 
            this.btnRecommended.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecommended.Location = new System.Drawing.Point(115, 101);
            this.btnRecommended.Name = "btnRecommended";
            this.btnRecommended.Size = new System.Drawing.Size(170, 87);
            this.btnRecommended.TabIndex = 0;
            this.btnRecommended.Text = "Recommended";
            this.btnRecommended.UseVisualStyleBackColor = true;
            this.btnRecommended.Click += new System.EventHandler(this.btnRecommended_Click);
            // 
            // btnOptional
            // 
            this.btnOptional.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptional.Location = new System.Drawing.Point(318, 101);
            this.btnOptional.Name = "btnOptional";
            this.btnOptional.Size = new System.Drawing.Size(170, 87);
            this.btnOptional.TabIndex = 1;
            this.btnOptional.Text = "Optional";
            this.btnOptional.UseVisualStyleBackColor = true;
            this.btnOptional.Click += new System.EventHandler(this.btnOptional_Click);
            // 
            // btnLatest
            // 
            this.btnLatest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLatest.Location = new System.Drawing.Point(115, 207);
            this.btnLatest.Name = "btnLatest";
            this.btnLatest.Size = new System.Drawing.Size(170, 87);
            this.btnLatest.TabIndex = 2;
            this.btnLatest.Text = "Latest";
            this.btnLatest.UseVisualStyleBackColor = true;
            this.btnLatest.Click += new System.EventHandler(this.btnLatest_Click);
            // 
            // btnCritical
            // 
            this.btnCritical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCritical.Location = new System.Drawing.Point(318, 207);
            this.btnCritical.Name = "btnCritical";
            this.btnCritical.Size = new System.Drawing.Size(170, 87);
            this.btnCritical.TabIndex = 3;
            this.btnCritical.Text = "Critical";
            this.btnCritical.UseVisualStyleBackColor = true;
            this.btnCritical.Click += new System.EventHandler(this.btnCritical_Click);
            // 
            // pgsDownload
            // 
            this.pgsDownload.Location = new System.Drawing.Point(-2, 399);
            this.pgsDownload.Name = "pgsDownload";
            this.pgsDownload.Size = new System.Drawing.Size(607, 22);
            this.pgsDownload.TabIndex = 4;
            // 
            // downloads
            // 
            this.downloads.AutoSize = true;
            this.downloads.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloads.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.downloads.Location = new System.Drawing.Point(219, 41);
            this.downloads.Name = "downloads";
            this.downloads.Size = new System.Drawing.Size(166, 45);
            this.downloads.TabIndex = 5;
            this.downloads.Text = "DOWNLOADS";
            // 
            // signature
            // 
            this.signature.AutoSize = true;
            this.signature.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signature.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signature.Location = new System.Drawing.Point(0, 373);
            this.signature.Name = "signature";
            this.signature.Size = new System.Drawing.Size(119, 23);
            this.signature.TabIndex = 6;
            this.signature.Text = "Created by nikit0";
            // 
            // tProgress
            // 
            this.tProgress.Tick += new System.EventHandler(this.tProgress_Tick);
            // 
            // txtRecommended
            // 
            this.txtRecommended.AutoSize = true;
            this.txtRecommended.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRecommended.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRecommended.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtRecommended.Location = new System.Drawing.Point(184, 154);
            this.txtRecommended.Name = "txtRecommended";
            this.txtRecommended.Size = new System.Drawing.Size(41, 13);
            this.txtRecommended.TabIndex = 7;
            this.txtRecommended.Text = "version";
            // 
            // txtOptional
            // 
            this.txtOptional.AutoSize = true;
            this.txtOptional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtOptional.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtOptional.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtOptional.Location = new System.Drawing.Point(388, 154);
            this.txtOptional.Name = "txtOptional";
            this.txtOptional.Size = new System.Drawing.Size(41, 13);
            this.txtOptional.TabIndex = 8;
            this.txtOptional.Text = "version";
            // 
            // txtLatest
            // 
            this.txtLatest.AutoSize = true;
            this.txtLatest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLatest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLatest.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtLatest.Location = new System.Drawing.Point(184, 259);
            this.txtLatest.Name = "txtLatest";
            this.txtLatest.Size = new System.Drawing.Size(41, 13);
            this.txtLatest.TabIndex = 9;
            this.txtLatest.Text = "version";
            // 
            // txtCritical
            // 
            this.txtCritical.AutoSize = true;
            this.txtCritical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCritical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCritical.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtCritical.Location = new System.Drawing.Point(388, 259);
            this.txtCritical.Name = "txtCritical";
            this.txtCritical.Size = new System.Drawing.Size(41, 13);
            this.txtCritical.TabIndex = 10;
            this.txtCritical.Text = "version";
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
            this.menuLinux});
            this.menuFiveM.Name = "menuFiveM";
            this.menuFiveM.Size = new System.Drawing.Size(51, 20);
            this.menuFiveM.Text = "FiveM";
            // 
            // menuWindows
            // 
            this.menuWindows.Name = "menuWindows";
            this.menuWindows.Size = new System.Drawing.Size(180, 22);
            this.menuWindows.Text = "Windows";
            // 
            // menuLinux
            // 
            this.menuLinux.Enabled = false;
            this.menuLinux.Name = "menuLinux";
            this.menuLinux.Size = new System.Drawing.Size(180, 22);
            this.menuLinux.Text = "Linux";
            // 
            // menuRedM
            // 
            this.menuRedM.Enabled = false;
            this.menuRedM.Name = "menuRedM";
            this.menuRedM.Size = new System.Drawing.Size(50, 20);
            this.menuRedM.Text = "RedM";
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(604, 420);
            this.Controls.Add(this.txtCritical);
            this.Controls.Add(this.txtLatest);
            this.Controls.Add(this.txtOptional);
            this.Controls.Add(this.txtRecommended);
            this.Controls.Add(this.signature);
            this.Controls.Add(this.downloads);
            this.Controls.Add(this.pgsDownload);
            this.Controls.Add(this.btnCritical);
            this.Controls.Add(this.btnLatest);
            this.Controls.Add(this.btnOptional);
            this.Controls.Add(this.btnRecommended);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecommended;
        private System.Windows.Forms.Button btnOptional;
        private System.Windows.Forms.Button btnLatest;
        private System.Windows.Forms.Button btnCritical;
        private System.Windows.Forms.ProgressBar pgsDownload;
        private System.Windows.Forms.Label downloads;
        private System.Windows.Forms.Label signature;
        private System.Windows.Forms.Timer tProgress;
        private System.Windows.Forms.Label txtRecommended;
        private System.Windows.Forms.Label txtOptional;
        private System.Windows.Forms.Label txtLatest;
        private System.Windows.Forms.Label txtCritical;
        private System.Windows.Forms.MenuStrip menuIndex;
        private System.Windows.Forms.ToolStripMenuItem menuFiveM;
        private System.Windows.Forms.ToolStripMenuItem menuWindows;
        private System.Windows.Forms.ToolStripMenuItem menuLinux;
        private System.Windows.Forms.ToolStripMenuItem menuRedM;
    }
}


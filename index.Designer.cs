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
            this.download = new System.Windows.Forms.Label();
            this.signature = new System.Windows.Forms.Label();
            this.tProgress = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnRecommended
            // 
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
            // download
            // 
            this.download.AutoSize = true;
            this.download.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.download.Location = new System.Drawing.Point(231, 51);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(143, 31);
            this.download.TabIndex = 5;
            this.download.Text = "Download";
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
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(604, 420);
            this.Controls.Add(this.signature);
            this.Controls.Add(this.download);
            this.Controls.Add(this.pgsDownload);
            this.Controls.Add(this.btnCritical);
            this.Controls.Add(this.btnLatest);
            this.Controls.Add(this.btnOptional);
            this.Controls.Add(this.btnRecommended);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artifacts Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecommended;
        private System.Windows.Forms.Button btnOptional;
        private System.Windows.Forms.Button btnLatest;
        private System.Windows.Forms.Button btnCritical;
        private System.Windows.Forms.ProgressBar pgsDownload;
        private System.Windows.Forms.Label download;
        private System.Windows.Forms.Label signature;
        private System.Windows.Forms.Timer tProgress;
    }
}


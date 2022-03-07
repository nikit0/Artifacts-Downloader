namespace Artifacts_Downloader
{
    partial class redmC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tProgress = new System.Windows.Forms.Timer(this.components);
            this.btnCacheS = new System.Windows.Forms.Button();
            this.server = new System.Windows.Forms.Label();
            this.client = new System.Windows.Forms.Label();
            this.btnServerC = new System.Windows.Forms.Button();
            this.btnNuiC = new System.Windows.Forms.Button();
            this.btnGameC = new System.Windows.Forms.Button();
            this.btnCacheC = new System.Windows.Forms.Button();
            this.signature = new System.Windows.Forms.Label();
            this.pgsDownload = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // tProgress
            // 
            this.tProgress.Tick += new System.EventHandler(this.tProgress_Tick);
            // 
            // btnCacheS
            // 
            this.btnCacheS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCacheS.Location = new System.Drawing.Point(409, 204);
            this.btnCacheS.Name = "btnCacheS";
            this.btnCacheS.Size = new System.Drawing.Size(130, 55);
            this.btnCacheS.TabIndex = 44;
            this.btnCacheS.Text = "Cache";
            this.btnCacheS.UseVisualStyleBackColor = true;
            this.btnCacheS.Click += new System.EventHandler(this.btnCacheS_Click);
            // 
            // server
            // 
            this.server.AutoSize = true;
            this.server.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.server.Location = new System.Drawing.Point(418, 142);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(112, 45);
            this.server.TabIndex = 43;
            this.server.Text = "SERVER";
            // 
            // client
            // 
            this.client.AutoSize = true;
            this.client.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.client.Location = new System.Drawing.Point(129, 80);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(101, 45);
            this.client.TabIndex = 42;
            this.client.Text = "CLIENT";
            // 
            // btnServerC
            // 
            this.btnServerC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServerC.Location = new System.Drawing.Point(177, 204);
            this.btnServerC.Name = "btnServerC";
            this.btnServerC.Size = new System.Drawing.Size(130, 55);
            this.btnServerC.TabIndex = 41;
            this.btnServerC.Text = "Server";
            this.btnServerC.UseVisualStyleBackColor = true;
            this.btnServerC.Click += new System.EventHandler(this.btnServerC_Click);
            // 
            // btnNuiC
            // 
            this.btnNuiC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuiC.Location = new System.Drawing.Point(41, 204);
            this.btnNuiC.Name = "btnNuiC";
            this.btnNuiC.Size = new System.Drawing.Size(130, 55);
            this.btnNuiC.TabIndex = 40;
            this.btnNuiC.Text = "Nui";
            this.btnNuiC.UseVisualStyleBackColor = true;
            this.btnNuiC.Click += new System.EventHandler(this.btnNuiC_Click);
            // 
            // btnGameC
            // 
            this.btnGameC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGameC.Location = new System.Drawing.Point(177, 142);
            this.btnGameC.Name = "btnGameC";
            this.btnGameC.Size = new System.Drawing.Size(130, 55);
            this.btnGameC.TabIndex = 39;
            this.btnGameC.Text = "Game";
            this.btnGameC.UseVisualStyleBackColor = true;
            this.btnGameC.Click += new System.EventHandler(this.btnGameC_Click);
            // 
            // btnCacheC
            // 
            this.btnCacheC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCacheC.Location = new System.Drawing.Point(41, 142);
            this.btnCacheC.Name = "btnCacheC";
            this.btnCacheC.Size = new System.Drawing.Size(130, 55);
            this.btnCacheC.TabIndex = 38;
            this.btnCacheC.Text = "Cache";
            this.btnCacheC.UseVisualStyleBackColor = true;
            this.btnCacheC.Click += new System.EventHandler(this.btnCacheC_Click);
            // 
            // signature
            // 
            this.signature.AutoSize = true;
            this.signature.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signature.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signature.Location = new System.Drawing.Point(1, 348);
            this.signature.Name = "signature";
            this.signature.Size = new System.Drawing.Size(119, 23);
            this.signature.TabIndex = 37;
            this.signature.Text = "Created by nikit0";
            // 
            // pgsDownload
            // 
            this.pgsDownload.Location = new System.Drawing.Point(-1, 374);
            this.pgsDownload.Name = "pgsDownload";
            this.pgsDownload.Size = new System.Drawing.Size(607, 22);
            this.pgsDownload.TabIndex = 36;
            // 
            // redmC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(604, 396);
            this.Controls.Add(this.btnCacheS);
            this.Controls.Add(this.server);
            this.Controls.Add(this.client);
            this.Controls.Add(this.btnServerC);
            this.Controls.Add(this.btnNuiC);
            this.Controls.Add(this.btnGameC);
            this.Controls.Add(this.btnCacheC);
            this.Controls.Add(this.signature);
            this.Controls.Add(this.pgsDownload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "redmC";
            this.Text = "redmC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tProgress;
        private System.Windows.Forms.Button btnCacheS;
        private System.Windows.Forms.Label server;
        private System.Windows.Forms.Label client;
        private System.Windows.Forms.Button btnServerC;
        private System.Windows.Forms.Button btnNuiC;
        private System.Windows.Forms.Button btnGameC;
        private System.Windows.Forms.Button btnCacheC;
        private System.Windows.Forms.Label signature;
        private System.Windows.Forms.ProgressBar pgsDownload;
    }
}
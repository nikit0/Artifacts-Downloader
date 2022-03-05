namespace Artifacts_Downloader
{
    partial class fivemL
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
            this.txtCritical = new System.Windows.Forms.Label();
            this.txtLatest = new System.Windows.Forms.Label();
            this.txtOptional = new System.Windows.Forms.Label();
            this.txtRecommended = new System.Windows.Forms.Label();
            this.signature = new System.Windows.Forms.Label();
            this.linux = new System.Windows.Forms.Label();
            this.pgsDownload = new System.Windows.Forms.ProgressBar();
            this.btnCritical = new System.Windows.Forms.Button();
            this.btnLatest = new System.Windows.Forms.Button();
            this.btnOptional = new System.Windows.Forms.Button();
            this.btnRecommended = new System.Windows.Forms.Button();
            this.tProgress = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtCritical
            // 
            this.txtCritical.AutoSize = true;
            this.txtCritical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCritical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCritical.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtCritical.Location = new System.Drawing.Point(389, 268);
            this.txtCritical.Name = "txtCritical";
            this.txtCritical.Size = new System.Drawing.Size(41, 13);
            this.txtCritical.TabIndex = 32;
            this.txtCritical.Text = "version";
            // 
            // txtLatest
            // 
            this.txtLatest.AutoSize = true;
            this.txtLatest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLatest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLatest.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtLatest.Location = new System.Drawing.Point(185, 268);
            this.txtLatest.Name = "txtLatest";
            this.txtLatest.Size = new System.Drawing.Size(41, 13);
            this.txtLatest.TabIndex = 31;
            this.txtLatest.Text = "version";
            // 
            // txtOptional
            // 
            this.txtOptional.AutoSize = true;
            this.txtOptional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtOptional.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtOptional.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtOptional.Location = new System.Drawing.Point(389, 163);
            this.txtOptional.Name = "txtOptional";
            this.txtOptional.Size = new System.Drawing.Size(41, 13);
            this.txtOptional.TabIndex = 30;
            this.txtOptional.Text = "version";
            // 
            // txtRecommended
            // 
            this.txtRecommended.AutoSize = true;
            this.txtRecommended.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRecommended.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRecommended.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtRecommended.Location = new System.Drawing.Point(185, 163);
            this.txtRecommended.Name = "txtRecommended";
            this.txtRecommended.Size = new System.Drawing.Size(41, 13);
            this.txtRecommended.TabIndex = 29;
            this.txtRecommended.Text = "version";
            // 
            // signature
            // 
            this.signature.AutoSize = true;
            this.signature.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signature.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signature.Location = new System.Drawing.Point(1, 348);
            this.signature.Name = "signature";
            this.signature.Size = new System.Drawing.Size(119, 23);
            this.signature.TabIndex = 28;
            this.signature.Text = "Created by nikit0";
            // 
            // linux
            // 
            this.linux.AutoSize = true;
            this.linux.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linux.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linux.Location = new System.Drawing.Point(261, 43);
            this.linux.Name = "linux";
            this.linux.Size = new System.Drawing.Size(86, 45);
            this.linux.TabIndex = 27;
            this.linux.Text = "LINUX";
            // 
            // pgsDownload
            // 
            this.pgsDownload.Location = new System.Drawing.Point(-1, 374);
            this.pgsDownload.Name = "pgsDownload";
            this.pgsDownload.Size = new System.Drawing.Size(607, 22);
            this.pgsDownload.TabIndex = 26;
            this.pgsDownload.Click += new System.EventHandler(this.tProgress_Tick);
            // 
            // btnCritical
            // 
            this.btnCritical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCritical.Location = new System.Drawing.Point(319, 216);
            this.btnCritical.Name = "btnCritical";
            this.btnCritical.Size = new System.Drawing.Size(170, 87);
            this.btnCritical.TabIndex = 25;
            this.btnCritical.Text = "Critical";
            this.btnCritical.UseVisualStyleBackColor = true;
            this.btnCritical.Click += new System.EventHandler(this.btnCritical_Click);
            // 
            // btnLatest
            // 
            this.btnLatest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLatest.Location = new System.Drawing.Point(116, 216);
            this.btnLatest.Name = "btnLatest";
            this.btnLatest.Size = new System.Drawing.Size(170, 87);
            this.btnLatest.TabIndex = 24;
            this.btnLatest.Text = "Latest";
            this.btnLatest.UseVisualStyleBackColor = true;
            this.btnLatest.Click += new System.EventHandler(this.btnLatest_Click);
            // 
            // btnOptional
            // 
            this.btnOptional.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptional.Location = new System.Drawing.Point(319, 110);
            this.btnOptional.Name = "btnOptional";
            this.btnOptional.Size = new System.Drawing.Size(170, 87);
            this.btnOptional.TabIndex = 23;
            this.btnOptional.Text = "Optional";
            this.btnOptional.UseVisualStyleBackColor = true;
            this.btnOptional.Click += new System.EventHandler(this.btnOptional_Click);
            // 
            // btnRecommended
            // 
            this.btnRecommended.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecommended.Location = new System.Drawing.Point(116, 110);
            this.btnRecommended.Name = "btnRecommended";
            this.btnRecommended.Size = new System.Drawing.Size(170, 87);
            this.btnRecommended.TabIndex = 22;
            this.btnRecommended.Text = "Recommended";
            this.btnRecommended.UseVisualStyleBackColor = true;
            this.btnRecommended.Click += new System.EventHandler(this.btnRecommended_Click);
            // 
            // tProgress
            // 
            this.tProgress.Tick += new System.EventHandler(this.tProgress_Tick);
            // 
            // fivemL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(604, 396);
            this.Controls.Add(this.txtCritical);
            this.Controls.Add(this.txtLatest);
            this.Controls.Add(this.txtOptional);
            this.Controls.Add(this.txtRecommended);
            this.Controls.Add(this.signature);
            this.Controls.Add(this.linux);
            this.Controls.Add(this.pgsDownload);
            this.Controls.Add(this.btnCritical);
            this.Controls.Add(this.btnLatest);
            this.Controls.Add(this.btnOptional);
            this.Controls.Add(this.btnRecommended);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fivemL";
            this.Text = "fivemL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCritical;
        private System.Windows.Forms.Label txtLatest;
        private System.Windows.Forms.Label txtOptional;
        private System.Windows.Forms.Label txtRecommended;
        private System.Windows.Forms.Label signature;
        private System.Windows.Forms.Label linux;
        private System.Windows.Forms.ProgressBar pgsDownload;
        private System.Windows.Forms.Button btnCritical;
        private System.Windows.Forms.Button btnLatest;
        private System.Windows.Forms.Button btnOptional;
        private System.Windows.Forms.Button btnRecommended;
        private System.Windows.Forms.Timer tProgress;
    }
}
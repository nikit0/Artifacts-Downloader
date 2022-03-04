namespace Artifacts_Downloader
{
    partial class redmW
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
            this.windows = new System.Windows.Forms.Label();
            this.signature = new System.Windows.Forms.Label();
            this.pgsDownload = new System.Windows.Forms.ProgressBar();
            this.tProgress = new System.Windows.Forms.Timer(this.components);
            this.underConstruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // windows
            // 
            this.windows.AutoSize = true;
            this.windows.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windows.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.windows.Location = new System.Drawing.Point(239, 41);
            this.windows.Name = "windows";
            this.windows.Size = new System.Drawing.Size(134, 45);
            this.windows.TabIndex = 17;
            this.windows.Text = "WINDOWS";
            // 
            // signature
            // 
            this.signature.AutoSize = true;
            this.signature.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signature.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signature.Location = new System.Drawing.Point(1, 348);
            this.signature.Name = "signature";
            this.signature.Size = new System.Drawing.Size(119, 23);
            this.signature.TabIndex = 19;
            this.signature.Text = "Created by nikit0";
            // 
            // pgsDownload
            // 
            this.pgsDownload.Location = new System.Drawing.Point(-1, 374);
            this.pgsDownload.Name = "pgsDownload";
            this.pgsDownload.Size = new System.Drawing.Size(607, 22);
            this.pgsDownload.TabIndex = 18;
            // 
            // underConstruction
            // 
            this.underConstruction.AutoSize = true;
            this.underConstruction.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underConstruction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.underConstruction.Location = new System.Drawing.Point(170, 180);
            this.underConstruction.Name = "underConstruction";
            this.underConstruction.Size = new System.Drawing.Size(269, 45);
            this.underConstruction.TabIndex = 20;
            this.underConstruction.Text = "Under construction...";
            // 
            // redmW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(604, 396);
            this.Controls.Add(this.underConstruction);
            this.Controls.Add(this.signature);
            this.Controls.Add(this.pgsDownload);
            this.Controls.Add(this.windows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "redmW";
            this.Text = "redm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label windows;
        private System.Windows.Forms.Label signature;
        private System.Windows.Forms.ProgressBar pgsDownload;
        private System.Windows.Forms.Timer tProgress;
        private System.Windows.Forms.Label underConstruction;
    }
}
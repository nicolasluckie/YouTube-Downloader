namespace YouTube_Downloader
{
    partial class GUI
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
            this.vidUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resolution = new System.Windows.Forms.ComboBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progText = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vidUrl
            // 
            this.vidUrl.Location = new System.Drawing.Point(75, 12);
            this.vidUrl.Name = "vidUrl";
            this.vidUrl.Size = new System.Drawing.Size(303, 20);
            this.vidUrl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resolution:";
            // 
            // resolution
            // 
            this.resolution.FormattingEnabled = true;
            this.resolution.Items.AddRange(new object[] {
            "720",
            "1080"});
            this.resolution.Location = new System.Drawing.Point(75, 38);
            this.resolution.Name = "resolution";
            this.resolution.Size = new System.Drawing.Size(121, 21);
            this.resolution.TabIndex = 3;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(75, 65);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(303, 23);
            this.progressBar.TabIndex = 4;
            // 
            // progText
            // 
            this.progText.AutoSize = true;
            this.progText.Location = new System.Drawing.Point(384, 70);
            this.progText.Name = "progText";
            this.progText.Size = new System.Drawing.Size(21, 13);
            this.progText.TabIndex = 5;
            this.progText.Text = "0%";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(303, 94);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Download";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 151);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.progText);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.resolution);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vidUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.Text = "YouTube Downloader - Created by Nicolas Luckie";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vidUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox resolution;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progText;
        private System.Windows.Forms.Button startBtn;
    }
}


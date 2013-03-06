namespace eliteNotifier
{
    partial class CustomProgressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomProgressForm));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topLabelProgress = new System.Windows.Forms.Label();
            this.bottomLabelProgress = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelProgressPercentage = new System.Windows.Forms.Label();
            this.labelFileDownloadSize = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Maroon;
            this.progressBar1.Location = new System.Drawing.Point(15, 20);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(493, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 67);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // topLabelProgress
            // 
            this.topLabelProgress.AutoSize = true;
            this.topLabelProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabelProgress.ForeColor = System.Drawing.Color.White;
            this.topLabelProgress.Location = new System.Drawing.Point(168, 12);
            this.topLabelProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.topLabelProgress.Name = "topLabelProgress";
            this.topLabelProgress.Size = new System.Drawing.Size(468, 16);
            this.topLabelProgress.TabIndex = 3;
            this.topLabelProgress.Text = "Staples® EasyTech™ SBC Performance Optimization In Progress... ";
            this.topLabelProgress.UseWaitCursor = true;
            // 
            // bottomLabelProgress
            // 
            this.bottomLabelProgress.AutoSize = true;
            this.bottomLabelProgress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bottomLabelProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomLabelProgress.ForeColor = System.Drawing.Color.White;
            this.bottomLabelProgress.Location = new System.Drawing.Point(168, 96);
            this.bottomLabelProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bottomLabelProgress.Name = "bottomLabelProgress";
            this.bottomLabelProgress.Size = new System.Drawing.Size(142, 16);
            this.bottomLabelProgress.TabIndex = 4;
            this.bottomLabelProgress.Text = "CheckThisSpace ...";
            this.bottomLabelProgress.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Location = new System.Drawing.Point(161, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 57);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(14, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 85);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.UseWaitCursor = true;
            // 
            // labelProgressPercentage
            // 
            this.labelProgressPercentage.AutoSize = true;
            this.labelProgressPercentage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelProgressPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressPercentage.ForeColor = System.Drawing.Color.White;
            this.labelProgressPercentage.Location = new System.Drawing.Point(632, 12);
            this.labelProgressPercentage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProgressPercentage.Name = "labelProgressPercentage";
            this.labelProgressPercentage.Size = new System.Drawing.Size(49, 16);
            this.labelProgressPercentage.TabIndex = 7;
            this.labelProgressPercentage.Text = "100 %";
            this.labelProgressPercentage.UseWaitCursor = true;
            // 
            // labelFileDownloadSize
            // 
            this.labelFileDownloadSize.AutoSize = true;
            this.labelFileDownloadSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelFileDownloadSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileDownloadSize.ForeColor = System.Drawing.Color.White;
            this.labelFileDownloadSize.Location = new System.Drawing.Point(530, 96);
            this.labelFileDownloadSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFileDownloadSize.Name = "labelFileDownloadSize";
            this.labelFileDownloadSize.Size = new System.Drawing.Size(151, 16);
            this.labelFileDownloadSize.TabIndex = 8;
            this.labelFileDownloadSize.Text = "1024000/1024000 MB";
            this.labelFileDownloadSize.UseWaitCursor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(6, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(690, 123);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // CustomProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(702, 131);
            this.Controls.Add(this.labelFileDownloadSize);
            this.Controls.Add(this.labelProgressPercentage);
            this.Controls.Add(this.bottomLabelProgress);
            this.Controls.Add(this.topLabelProgress);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomProgressForm";
            //this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom ProGress";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label topLabelProgress;
        private System.Windows.Forms.Label bottomLabelProgress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelProgressPercentage;
        private System.Windows.Forms.Label labelFileDownloadSize;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
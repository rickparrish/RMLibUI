/*
  RMLibUI: Visual support classes/components used by multiple R&M Software programs
  Copyright (C) 2008-2014  Rick Parrish, R&M Software

  This file is part of RMLibUI.

  RMLibUI is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  any later version.

  RMLibUI is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with RMLibUI.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;
using RandM.RMLib;

namespace RandM.RMLibUI
{
    public class frmRMFileDownloader : Form
    {
        #region Windows Contols and Constructor

        private System.Windows.Forms.ProgressBar pbDownload;
        private System.Windows.Forms.Button cmdCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblSpeed;
        private Label lblTimeRemaining;
        private Label lblTo;
        private Label lblFrom;
        private Label lblName;
        private Label lblBytesRemaining;
        private Label label7;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #endregion

        #region Dispose

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

        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbDownload = new System.Windows.Forms.ProgressBar();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBytesRemaining = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbDownload
            // 
            this.pbDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDownload.Location = new System.Drawing.Point(12, 123);
            this.pbDownload.Maximum = 1;
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.Size = new System.Drawing.Size(282, 23);
            this.pbDownload.TabIndex = 1;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.Location = new System.Drawing.Point(300, 123);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(87, 23);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Time remaining:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Speed:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(116, 97);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(48, 13);
            this.lblSpeed.TabIndex = 15;
            this.lblSpeed.Text = "Speed:";
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.AutoSize = true;
            this.lblTimeRemaining.Location = new System.Drawing.Point(116, 62);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(101, 13);
            this.lblTimeRemaining.TabIndex = 14;
            this.lblTimeRemaining.Text = "Time remaining:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(116, 44);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(26, 13);
            this.lblTo.TabIndex = 13;
            this.lblTo.Text = "To:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(116, 26);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(41, 13);
            this.lblFrom.TabIndex = 12;
            this.lblFrom.Text = "From:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(116, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name:";
            // 
            // lblBytesRemaining
            // 
            this.lblBytesRemaining.AutoSize = true;
            this.lblBytesRemaining.Location = new System.Drawing.Point(116, 80);
            this.lblBytesRemaining.Name = "lblBytesRemaining";
            this.lblBytesRemaining.Size = new System.Drawing.Size(105, 13);
            this.lblBytesRemaining.TabIndex = 17;
            this.lblBytesRemaining.Text = "Bytes remaining:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Bytes remaining:";
            // 
            // frmRMFileDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(394, 152);
            this.Controls.Add(this.lblBytesRemaining);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblTimeRemaining);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.pbDownload);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRMFileDownloader";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "R&M File Downloader";
            this.Load += new System.EventHandler(this.frmRMFileDownload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bool _Kilo = false;
        private long _LastBytes = 0;
        private DateTime _LastUpdate = DateTime.Now;
        private object _Lock = new object();
        private RMWebClient _WebClient = null;

        public frmRMFileDownloader(Uri url, string fileName)
        {
            if (url == null) throw new ArgumentNullException("url");
            // TODO Should abort if target directory does not exist, or should create target directory?

            InitializeComponent();

            lblName.Text = Path.GetFileName(url.ToString());
            lblFrom.Text = url.ToString();
            lblTo.Text = fileName;
            lblTimeRemaining.Text = "Calculating...";
            lblBytesRemaining.Text = "Unknown";
            lblSpeed.Text = "Calculating...";

            Directory.CreateDirectory(Path.GetDirectoryName(fileName));
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            lock (_Lock)
            {
                if (_WebClient != null) _WebClient.CancelAsync();
            }
        }

        private void frmRMFileDownload_Load(object sender, EventArgs e)
        {
            lock (_Lock)
            {
                _WebClient = new RMWebClient();
                _WebClient.DownloadFileCompleted += new AsyncCompletedEventHandler(WC_DownloadFileCompleted);
                _WebClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(WC_DownloadProgressChanged);
                _WebClient.DownloadFileAsync(new Uri(lblFrom.Text), lblTo.Text);
            }
        }

        void WC_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Check if we need to initialize the progress bar
            if (pbDownload.Maximum == 1)
            {
                _Kilo = (e.TotalBytesToReceive > int.MaxValue);
                pbDownload.Maximum = (_Kilo) ? (int)(e.TotalBytesToReceive / 1024) : (int)e.TotalBytesToReceive;
            }

            // Check how long it's been since our last update
            double MS = DateTime.Now.Subtract(_LastUpdate).TotalMilliseconds;
            if (MS >= 500)
            {
                // More than 500 milliseconds, so also calculate the speed/time estimates
                long IntervalBytes = e.BytesReceived - _LastBytes;
                double BytesPerSecond = IntervalBytes / MS * 1000;
                long BytesRemaining = e.TotalBytesToReceive - e.BytesReceived;

                lblTimeRemaining.Text = (BytesPerSecond == 0) ? "Infinite" : StringUtils.SecToMS((int)(BytesRemaining / BytesPerSecond));
                lblBytesRemaining.Text = StringUtils.BytesToStr(BytesRemaining);
                lblSpeed.Text = StringUtils.BytesToStr((int)BytesPerSecond) + " per second";

                _LastBytes = e.BytesReceived;
                _LastUpdate = DateTime.Now;
            }

            // Update the progress bar
            pbDownload.Value = (_Kilo) ? (int)(e.BytesReceived / 1024) : (int)e.BytesReceived;
        }

        void WC_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                pbDownload.Value = 0;
                Dialog.Information("Download Aborted", "Download Aborted");

                // Clean up the aborted download
                FileUtils.FileDelete(lblTo.Text);

                DialogResult = DialogResult.Cancel;
                Close();
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }

            lock (_Lock)
            {
                _WebClient = null;
            }
        }
    }
}
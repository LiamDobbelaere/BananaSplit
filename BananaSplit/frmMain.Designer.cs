namespace BananaSplit
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblStep1 = new System.Windows.Forms.Label();
            this.lblCurrFile = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.MaskedTextBox();
            this.txtMinutes = new System.Windows.Forms.MaskedTextBox();
            this.txtSeconds = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStartsplitInfo = new System.Windows.Forms.Label();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnViewLog = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.ofdVideoFile = new System.Windows.Forms.OpenFileDialog();
            this.ttFile = new System.Windows.Forms.ToolTip(this.components);
            this.pbrProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep1.Location = new System.Drawing.Point(12, 9);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(174, 20);
            this.lblStep1.TabIndex = 0;
            this.lblStep1.Text = "Step 1 - Select video file:";
            // 
            // lblCurrFile
            // 
            this.lblCurrFile.AutoSize = true;
            this.lblCurrFile.Location = new System.Drawing.Point(97, 37);
            this.lblCurrFile.Name = "lblCurrFile";
            this.lblCurrFile.Size = new System.Drawing.Size(80, 13);
            this.lblCurrFile.TabIndex = 1;
            this.lblCurrFile.Text = "No file selected";
            this.ttFile.SetToolTip(this.lblCurrFile, "Meow");
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Khaki;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Location = new System.Drawing.Point(16, 32);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Step 2 - Split file every:";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(16, 94);
            this.txtHours.Mask = "00 hour(s)";
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(70, 20);
            this.txtHours.TabIndex = 7;
            this.txtHours.Text = "00";
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(92, 94);
            this.txtMinutes.Mask = "00 minute(s)";
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(70, 20);
            this.txtMinutes.TabIndex = 8;
            this.txtMinutes.Text = "05";
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(168, 94);
            this.txtSeconds.Mask = "00 second(s)";
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(70, 20);
            this.txtSeconds.TabIndex = 9;
            this.txtSeconds.Text = "00";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 41);
            this.label2.TabIndex = 10;
            this.label2.Text = "Example: a value of 1 hour and 20 minutes would split the file every set of 1 hou" +
    "r and 20 minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Step 3 - Start splitting:";
            // 
            // lblStartsplitInfo
            // 
            this.lblStartsplitInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartsplitInfo.Location = new System.Drawing.Point(13, 196);
            this.lblStartsplitInfo.Name = "lblStartsplitInfo";
            this.lblStartsplitInfo.Size = new System.Drawing.Size(384, 53);
            this.lblStartsplitInfo.TabIndex = 12;
            this.lblStartsplitInfo.Tag = "The splitted files will be put in a folder called %filename%_split where the orig" +
    "inal video file is located. The original file will be untouched.";
            // 
            // btnSplit
            // 
            this.btnSplit.BackColor = System.Drawing.Color.Khaki;
            this.btnSplit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSplit.Location = new System.Drawing.Point(16, 252);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(156, 23);
            this.btnSplit.TabIndex = 13;
            this.btnSplit.Text = "Banana split!";
            this.btnSplit.UseVisualStyleBackColor = false;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnViewLog
            // 
            this.btnViewLog.BackColor = System.Drawing.Color.White;
            this.btnViewLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewLog.Location = new System.Drawing.Point(339, 252);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(58, 23);
            this.btnViewLog.TabIndex = 14;
            this.btnViewLog.Text = "View log";
            this.btnViewLog.UseVisualStyleBackColor = false;
            this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(433, 12);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(264, 247);
            this.rtbLog.TabIndex = 15;
            this.rtbLog.Text = "";
            // 
            // ofdVideoFile
            // 
            this.ofdVideoFile.Title = "Select video file";
            // 
            // ttFile
            // 
            this.ttFile.BackColor = System.Drawing.Color.Blue;
            this.ttFile.ForeColor = System.Drawing.Color.White;
            this.ttFile.IsBalloon = true;
            this.ttFile.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttFile.ToolTipTitle = "Input file";
            // 
            // pbrProgress
            // 
            this.pbrProgress.Location = new System.Drawing.Point(178, 252);
            this.pbrProgress.Name = "pbrProgress";
            this.pbrProgress.Size = new System.Drawing.Size(155, 23);
            this.pbrProgress.TabIndex = 16;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(414, 287);
            this.Controls.Add(this.pbrProgress);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btnViewLog);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.lblStartsplitInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblCurrFile);
            this.Controls.Add(this.lblStep1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "BananaSplit - Simple video splitter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.Label lblCurrFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtHours;
        private System.Windows.Forms.MaskedTextBox txtMinutes;
        private System.Windows.Forms.MaskedTextBox txtSeconds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStartsplitInfo;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnViewLog;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.OpenFileDialog ofdVideoFile;
        private System.Windows.Forms.ToolTip ttFile;
        private System.Windows.Forms.ProgressBar pbrProgress;
    }
}


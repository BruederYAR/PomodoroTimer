namespace PomodoroTimer
{
    partial class SettingsForm
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SettingRestScoreLimitBox = new System.Windows.Forms.TextBox();
            this.labelSettingRestScore = new System.Windows.Forms.Label();
            this.labelSettingBigRest = new System.Windows.Forms.Label();
            this.SettingBigRestBox = new System.Windows.Forms.TextBox();
            this.labeSettinglSmallRest = new System.Windows.Forms.Label();
            this.labelSettingWorking = new System.Windows.Forms.Label();
            this.SettingSmallRestBox = new System.Windows.Forms.TextBox();
            this.SettingWorkingBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(230, 130);
            this.webBrowser1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonLoad);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.SettingRestScoreLimitBox);
            this.panel1.Controls.Add(this.labelSettingRestScore);
            this.panel1.Controls.Add(this.labelSettingBigRest);
            this.panel1.Controls.Add(this.SettingBigRestBox);
            this.panel1.Controls.Add(this.labeSettinglSmallRest);
            this.panel1.Controls.Add(this.labelSettingWorking);
            this.panel1.Controls.Add(this.SettingSmallRestBox);
            this.panel1.Controls.Add(this.SettingWorkingBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 130);
            this.panel1.TabIndex = 1;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(124, 90);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(90, 24);
            this.buttonLoad.TabIndex = 9;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 88);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 24);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // SettingRestScoreLimitBox
            // 
            this.SettingRestScoreLimitBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SettingRestScoreLimitBox.Location = new System.Drawing.Point(124, 64);
            this.SettingRestScoreLimitBox.Name = "SettingRestScoreLimitBox";
            this.SettingRestScoreLimitBox.Size = new System.Drawing.Size(90, 20);
            this.SettingRestScoreLimitBox.TabIndex = 7;
            this.SettingRestScoreLimitBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SettingRestScoreLimitBox_KeyPress);
            // 
            // labelSettingRestScore
            // 
            this.labelSettingRestScore.AutoSize = true;
            this.labelSettingRestScore.Location = new System.Drawing.Point(121, 48);
            this.labelSettingRestScore.Name = "labelSettingRestScore";
            this.labelSettingRestScore.Size = new System.Drawing.Size(84, 13);
            this.labelSettingRestScore.TabIndex = 6;
            this.labelSettingRestScore.Text = "Rest Score Limit";
            // 
            // labelSettingBigRest
            // 
            this.labelSettingBigRest.AutoSize = true;
            this.labelSettingBigRest.Location = new System.Drawing.Point(121, 9);
            this.labelSettingBigRest.Name = "labelSettingBigRest";
            this.labelSettingBigRest.Size = new System.Drawing.Size(73, 13);
            this.labelSettingBigRest.TabIndex = 5;
            this.labelSettingBigRest.Text = "Big Rest Time";
            // 
            // SettingBigRestBox
            // 
            this.SettingBigRestBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SettingBigRestBox.Location = new System.Drawing.Point(124, 25);
            this.SettingBigRestBox.Name = "SettingBigRestBox";
            this.SettingBigRestBox.Size = new System.Drawing.Size(90, 20);
            this.SettingBigRestBox.TabIndex = 4;
            this.SettingBigRestBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SettingBigRestBox_KeyPress);
            // 
            // labeSettinglSmallRest
            // 
            this.labeSettinglSmallRest.AutoSize = true;
            this.labeSettinglSmallRest.Location = new System.Drawing.Point(12, 49);
            this.labeSettinglSmallRest.Name = "labeSettinglSmallRest";
            this.labeSettinglSmallRest.Size = new System.Drawing.Size(83, 13);
            this.labeSettinglSmallRest.TabIndex = 3;
            this.labeSettinglSmallRest.Text = "Small Rest Time";
            // 
            // labelSettingWorking
            // 
            this.labelSettingWorking.AutoSize = true;
            this.labelSettingWorking.Location = new System.Drawing.Point(12, 9);
            this.labelSettingWorking.Name = "labelSettingWorking";
            this.labelSettingWorking.Size = new System.Drawing.Size(73, 13);
            this.labelSettingWorking.TabIndex = 2;
            this.labelSettingWorking.Text = "Working Time";
            // 
            // SettingSmallRestBox
            // 
            this.SettingSmallRestBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SettingSmallRestBox.Location = new System.Drawing.Point(12, 62);
            this.SettingSmallRestBox.Name = "SettingSmallRestBox";
            this.SettingSmallRestBox.Size = new System.Drawing.Size(90, 20);
            this.SettingSmallRestBox.TabIndex = 1;
            this.SettingSmallRestBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SettingSmallRestBox_KeyPress);
            // 
            // SettingWorkingBox
            // 
            this.SettingWorkingBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SettingWorkingBox.Location = new System.Drawing.Point(12, 26);
            this.SettingWorkingBox.Name = "SettingWorkingBox";
            this.SettingWorkingBox.Size = new System.Drawing.Size(90, 20);
            this.SettingWorkingBox.TabIndex = 0;
            this.SettingWorkingBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SettingWorkingBox_KeyPress);
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(230, 130);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labeSettinglSmallRest;
        private System.Windows.Forms.Label labelSettingWorking;
        private System.Windows.Forms.TextBox SettingSmallRestBox;
        private System.Windows.Forms.TextBox SettingWorkingBox;
        private System.Windows.Forms.Label labelSettingBigRest;
        private System.Windows.Forms.TextBox SettingBigRestBox;
        private System.Windows.Forms.TextBox SettingRestScoreLimitBox;
        private System.Windows.Forms.Label labelSettingRestScore;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
    }
}
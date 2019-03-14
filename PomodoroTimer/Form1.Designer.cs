namespace PomodoroTimer
{
    partial class Pomodoro
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pomodoro));
            this.timerLabel = new System.Windows.Forms.Label();
            this.startButt = new System.Windows.Forms.Button();
            this.stopButt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.Location = new System.Drawing.Point(86, 18);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(83, 91);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "0";
            // 
            // startButt
            // 
            this.startButt.BackColor = System.Drawing.Color.Red;
            this.startButt.Location = new System.Drawing.Point(12, 173);
            this.startButt.Name = "startButt";
            this.startButt.Size = new System.Drawing.Size(108, 57);
            this.startButt.TabIndex = 1;
            this.startButt.Text = "START";
            this.startButt.UseVisualStyleBackColor = false;
            this.startButt.Click += new System.EventHandler(this.startButt_Click);
            // 
            // stopButt
            // 
            this.stopButt.BackColor = System.Drawing.Color.Red;
            this.stopButt.Location = new System.Drawing.Point(144, 173);
            this.stopButt.Name = "stopButt";
            this.stopButt.Size = new System.Drawing.Size(108, 57);
            this.stopButt.TabIndex = 2;
            this.stopButt.Text = "STOP";
            this.stopButt.UseVisualStyleBackColor = false;
            this.stopButt.Click += new System.EventHandler(this.stopButt_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLabel.Location = new System.Drawing.Point(12, 120);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(240, 20);
            this.TextLabel.TabIndex = 3;
            this.TextLabel.Text = "Time to start work, click \"START\"";
            this.TextLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(257, 242);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.stopButt);
            this.Controls.Add(this.startButt);
            this.Controls.Add(this.timerLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Pomodoro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pomodoro";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button startButt;
        private System.Windows.Forms.Button stopButt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TextLabel;
    }
}


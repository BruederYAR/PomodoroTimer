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
            this.SuspendLayout();
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.Location = new System.Drawing.Point(66, 30);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(57, 63);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "0";
            // 
            // startButt
            // 
            this.startButt.BackColor = System.Drawing.Color.Red;
            this.startButt.Location = new System.Drawing.Point(12, 118);
            this.startButt.Name = "startButt";
            this.startButt.Size = new System.Drawing.Size(76, 40);
            this.startButt.TabIndex = 1;
            this.startButt.Text = "START";
            this.startButt.UseVisualStyleBackColor = false;
            this.startButt.Click += new System.EventHandler(this.startButt_Click);
            // 
            // stopButt
            // 
            this.stopButt.BackColor = System.Drawing.Color.Red;
            this.stopButt.Location = new System.Drawing.Point(100, 118);
            this.stopButt.Name = "stopButt";
            this.stopButt.Size = new System.Drawing.Size(76, 40);
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
            // Pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(188, 174);
            this.Controls.Add(this.stopButt);
            this.Controls.Add(this.startButt);
            this.Controls.Add(this.timerLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pomodoro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pomodoro";
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
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PomodoroTimer
{
    public partial class SettingsForm : Form
    {
        string[] settings = new string[] { "25", "5", "25", "4" };

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists("Settings.txt"))
            {
                File.WriteAllLines("Settings.txt", settings);
            }

            settings = File.ReadAllLines("Settings.txt", Encoding.Default);

            SettingWorkingBox.Text = settings[0];
            SettingSmallRestBox.Text = settings[1];
            SettingBigRestBox.Text = settings[2];
            SettingRestScoreLimitBox.Text = settings[3];
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (SettingRestScoreLimitBox.Text != null && SettingBigRestBox.Text != null && SettingSmallRestBox != null && SettingWorkingBox.Text != null)
            {
                settings[0] = SettingWorkingBox.Text;
                settings[1] = SettingSmallRestBox.Text;
                settings[2] = SettingBigRestBox.Text;
                settings[3] = SettingRestScoreLimitBox.Text;
                File.WriteAllLines("Settings.txt", settings);
            }
            else
            {
                MessageBox.Show("You have not entered a value", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            settings = File.ReadAllLines("Settings.txt", Encoding.Default);

            SettingWorkingBox.Text = settings[0];
            SettingSmallRestBox.Text = settings[1];
            SettingBigRestBox.Text = settings[2];
            SettingRestScoreLimitBox.Text = settings[3];
        }

        private void SettingWorkingBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) 
                return;
            else
                e.Handled = true;
        }

        private void SettingBigRestBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                return;
            else
                e.Handled = true;
        }

        private void SettingSmallRestBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                return;
            else
                e.Handled = true;
        }

        private void SettingRestScoreLimitBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > '1' && e.KeyChar <= '9' || Char.IsControl(e.KeyChar))
                return;
            else
                e.Handled = true;
        }
    }
}

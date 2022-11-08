using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Microffer.Core
{
    public partial class FormSettings : FormShadow
    {
        RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Microffer\Hotkey");

        public FormSettings()
        {
            InitializeComponent();

            FormPaint(Color.FromArgb(14, 22, 33), Color.FromArgb(14, 22, 33));

            new List<Control> { labelHeader, panelHeader }.ForEach(x =>
            {
                x.MouseDown += (s, a) =>
                {
                    x.Capture = false;
                    Capture = false;
                    Message m = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                    base.WndProc(ref m);
                };
            });

            if (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor <= 1)
                labelExit.Text = "☓";

            if (key.GetValue("UseHotkeys")?.ToString() == "true")
            {
                checkBoxHotkey.Checked = true;
                textBox.Enabled = true;
                labelKey.ForeColor = Color.FromArgb(115, 185, 245);
            }
            else if (key.GetValue("UseHotkeys")?.ToString() == "false")
            {
                checkBoxHotkey.Checked = false;
                textBox.Enabled = false;
                labelKey.ForeColor = Color.FromArgb(118, 140, 158);
            }
            else
            {
                key.SetValue("UseHotkeys", "false");
            }
        }

        #region [ Label events ]
        private void labelLeaveSettings_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelLeaveSettings_MouseEnter(object sender, EventArgs e)
        {
            labelLeaveSettings.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void labelLeaveSettings_MouseLeave(object sender, EventArgs e)
        {
            labelLeaveSettings.ForeColor = Color.FromArgb(86, 101, 114);
        }
        #endregion

        private void checkBoxHotkey_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxHotkey.Checked)
            {
                textBox.Enabled = false;
                labelKey.ForeColor = Color.FromArgb(118, 140, 158);
            }
            else
            {
                textBox.Enabled = true;
                labelKey.ForeColor = Color.FromArgb(115, 185, 245);
            }
        }

        private void FormSettings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                buttonAccept_Click(buttonAccept, null);
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (key != null)
            {
                if (checkBoxHotkey.Checked)
                {
                    key?.SetValue("UseHotkeys", "true");
                }
                else
                {
                    key?.SetValue("UseHotkeys", "false");
                }
            }
            else
            {
                key?.CreateSubKey(@"Software\Microffer\Hotkey")?.SetValue("UseHotkeys", "false");
            }
        }
    }
}

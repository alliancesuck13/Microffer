using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microffer.Core.Checkers;

namespace Microffer.Core
{
    public partial class FormSettings : FormShadow
    {
        static RegistryChecker registryChecker = new RegistryChecker();
        RegistryKey openedRegistryKey = registryChecker.OpenRegistryKey("Software\\Microffer\\Hotkey");
        RegistryKey createdRegistryKey = registryChecker.CreateRegistryKey("Software\\Microffer\\Hotkey");

        public FormSettings()
        {
            InitializeComponent();

            FormPaint(Color.FromArgb(14, 22, 33), Color.FromArgb(14, 22, 33));

            new List<Control> { labelHeader, panelHeader }.ForEach(control =>
            {
                control.MouseDown += (s, a) =>
                {
                    control.Capture = false;
                    Capture = false;
                    Message m = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                    base.WndProc(ref m);
                };
            });

            if (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor <= 1)
                labelExit.Text = "☓";

            if (openedRegistryKey?.GetValue("UseHotkeys")?.ToString() == "true")
            {
                checkBoxHotkey.Checked = true;
                textBox.Enabled = true;
                labelKey.ForeColor = Color.FromArgb(115, 185, 245);

                openedRegistryKey.Close();
            }
            else if (openedRegistryKey?.GetValue("UseHotkeys")?.ToString() == "false")
            {
                checkBoxHotkey.Checked = false;
                textBox.Enabled = false;
                labelKey.ForeColor = Color.FromArgb(118, 140, 158);

                openedRegistryKey.Close();
            }
            else
            {
                createdRegistryKey.SetValue("UseHotkeys", "false");
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
            try
            {
                if (registryChecker.CheckExistingKey("Software\\Microffer"))
                {
                    if (checkBoxHotkey.Checked)
                    {
                        createdRegistryKey?.SetValue("UseHotkeys", "true");
                    }
                    else
                    {
                        createdRegistryKey?.SetValue("UseHotkeys", "false");
                    }
                }
                else
                {
                    createdRegistryKey?.SetValue("UseHotkeys", "false");
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Дебил ебаный, хватит ломать программу");
                Close();
            }

            Close();
            
        }

    }
}

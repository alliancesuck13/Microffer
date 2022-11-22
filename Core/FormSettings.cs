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
                labelKey.ForeColor = Color.FromArgb(43, 82, 120);

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

            switch (textBox.Text)
            {
                case " ":
                    MessageBox.Show("Test");
                    break;

                default:
                    KeyDown += (s, a) =>
                    {
                        switch (a.KeyData)
                        {
                            case Keys.Up:
                                textBox.Text = "Up";
                                break;

                            case Keys.Down:
                                textBox.Text = "Down";
                                break;

                            case Keys.Left:
                                textBox.Text = "Left";
                                break;

                            case Keys.Right:
                                textBox.Text = "Right";
                                break;

                            case Keys.Home:
                                textBox.Text = "Home";
                                break;

                            case Keys.PageUp:
                                textBox.Text = "PageUp";
                                break;

                            case Keys.PageDown:
                                textBox.Text = "PageDown";
                                break;

                            case Keys.NumPad0:
                                textBox.Text = "NumPad0";
                                break;

                            case Keys.NumPad1:
                                textBox.Text = "NumPad1";
                                break;

                            case Keys.NumPad2:
                                textBox.Text = "NumPad2";
                                break;

                            case Keys.NumPad3:
                                textBox.Text = "NumPad3";
                                break;

                            case Keys.NumPad4:
                                textBox.Text = "NumPad4";
                                break;

                            case Keys.NumPad5:
                                textBox.Text = "NumPad5";
                                break;

                            case Keys.NumPad6:
                                textBox.Text = "NumPad6";
                                break;

                            case Keys.NumPad7:
                                textBox.Text = "NumPad7";
                                break;

                            case Keys.NumPad8:
                                textBox.Text = "NumPad8";
                                break;

                            case Keys.NumPad9:
                                textBox.Text = "NumPad9";
                                break;
                                // -
                            case Keys.Subtract:
                                textBox.Text = "Subtract";
                                break;

                            case Keys.Multiply:
                                textBox.Text = "Multiply";
                                break;
                                // /
                            case Keys.Divide:
                                textBox.Text = "Divide";
                                break;

                            case Keys.NumLock:
                                textBox.Text = "NumLock";
                                break;

                            case Keys.F10:
                                textBox.Text = "F10";
                                break;

                            case Keys.F9:
                                textBox.Text = "F9";
                                break;
                        }
                    };
                    break;
            }

            if (registryChecker.CheckExistingKey("Software\\Microffer\\Hotkey") != false)
            {
                textBox.Text = createdRegistryKey?.GetValue("Hotkey")?.ToString();
            }
            else
            {
                createdRegistryKey?.SetValue("Hotkey", string.Empty);
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
                labelKey.ForeColor = Color.FromArgb(43, 82, 120);
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
            if (registryChecker.CheckExistingKey("Software\\Microffer"))
            {
                if (checkBoxHotkey.Checked)
                {
                    createdRegistryKey?.SetValue("UseHotkeys", "true");

                    if (textBox != null)
                    {
                        createdRegistryKey?.SetValue("Hotkey", textBox.Text);
                    }
                }
                else
                {
                    createdRegistryKey?.SetValue("UseHotkeys", "false");
                }
            }
            else
            {
                createdRegistryKey?.SetValue("UseHotkeys", "false");
                createdRegistryKey?.SetValue("Hotkey", string.Empty);
            }

            Close();
        }

        private void labelKey_Click(object sender, EventArgs e)
        {
            textBox.Focus();
        }

        private void labelQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В приложении пока что не реализована возможность изменять горячую клавишу. " +
                "Для отключения звука необходимо нажать * на NumPad.", 
                "Microffer", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Warning);
        }
    }
}

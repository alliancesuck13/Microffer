using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Microffer
{
    public partial class FormMain : FormShadow
    {
        public FormMain()
        {
            InitializeComponent();

            FormPaint(Color.FromArgb(14, 22, 33), Color.FromArgb(14, 22, 33));

            new List<Control> { panelHeader }.ForEach(x =>
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
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void labelExit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.FromArgb(86, 101, 114);
        }

        private void labelHeader_MouseClick(object sender, MouseEventArgs e)
        {
            if (Application.OpenForms["FormAbout"] == null)
                new FormAbout().Show();
        }
    }
}

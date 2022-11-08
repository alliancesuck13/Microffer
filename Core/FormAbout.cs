using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


namespace Microffer
{
    public partial class FormAbout : FormShadow
    {
        public FormAbout()
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
        }

        #region [ Label events ]
        private void labelLeaveAbout_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void labelLeaveAbout_MouseEnter(object sender, EventArgs e)
        {
            labelLeaveAbout.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void labelLeaveAbout_MouseLeave(object sender, EventArgs e)
        {
            labelLeaveAbout.ForeColor = Color.FromArgb(86, 101, 114);
        }

        private void labelAuthorName_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start("https://fe2ck.t.me");
        }
        #endregion

    }
}

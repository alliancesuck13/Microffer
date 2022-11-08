using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Windows.Forms;

namespace Microffer
{
    public partial class FormMain : FormShadow
    {
        public FormMain()
        {
            InitializeComponent();
            if (!InstanceChecker.TakeMemory())
            {
                labelCopy.Text = "Копия программы!";
            }

            FormClosing += (s, a) => InstanceChecker.ReleaseMemory();
            SizeChanged += (s, a) =>
            {
                if (WindowState == FormWindowState.Minimized)
                    InstanceChecker.ReleaseMemory();
            };

            FormPaint(Color.FromArgb(14, 22, 33), Color.FromArgb(14, 22, 33));

            new List<Control> { panelHeader, labelCopy }.ForEach(x =>
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

            ServiceController serviceControllerAudio = ServiceController.GetServices().Single(ServiceHandler());
            if (serviceControllerAudio.Status.ToString() == "Running")
            {
                labelAudioStatus.Text = "Звук включен";
            }
            else
            {
                labelAudioStatus.Text = "Звук выключен";
                labelAudioStatus.ForeColor = Color.FromArgb(127, 145, 164);

                buttonSoundOff.Text = "Включить";
            }
        }
        private static Func<ServiceController, bool> ServiceHandler()
        {
            return svc => svc.ServiceName == "Audiosrv";
        }

        #region [ Label events ]
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

        private void labelMinimize_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void labelMinimize_MouseEnter(object sender, EventArgs e)
        {
            labelMinimize.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void labelMinimize_MouseLeave(object sender, EventArgs e)
        {
            labelMinimize.ForeColor = Color.FromArgb(86, 101, 114);
        }

        private void labelSettings_MouseEnter(object sender, EventArgs e)
        {
            labelSettings.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void labelSettings_MouseLeave(object sender, EventArgs e)
        {
            labelSettings.ForeColor = Color.FromArgb(86, 101, 114);
        }
        #endregion

        #region [ Form ]
        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            notifyIconDefault.BalloonTipTitle = "Microffer";
            notifyIconDefault.BalloonTipText = "Приложение свернуто";
        }

        private void notifyIconDefault_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            notifyIconDefault.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIconDefault.Visible = true;
                notifyIconDefault.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == WindowState)
            {
                notifyIconDefault.Visible = false;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormAbout"] == null)
                new FormAbout().Show();
        }

        private void microfferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }
        #endregion

        #region [ Button events ]
        private void buttonSoundOff_MouseDown(object sender, MouseEventArgs e)
        {
            buttonSoundOff.ForeColor = Color.FromArgb(155, 178, 197);
        }
        private void buttonSoundOff_Click(object sender, EventArgs e)
        {
            ServiceController serviceControllerAudio = ServiceController.GetServices().Single(ServiceHandler());

            if (serviceControllerAudio.Status.Equals(ServiceControllerStatus.Running))
            {
                serviceControllerAudio.Stop();

                buttonSoundOff.Text = "Включить";
                labelAudioStatus.Text = "Звук выключен";
                labelAudioStatus.ForeColor = Color.FromArgb(127, 145, 164);

                buttonSoundOff.Click -= new EventHandler(buttonSoundOff_Click);
                buttonSoundOff.Click += new EventHandler(buttonSoundOff_SecondClick);
            }
            else
            {
                serviceControllerAudio.Start();

                buttonSoundOff.Text = "Выключить";
                labelAudioStatus.Text = "Звук включен";
                labelAudioStatus.ForeColor = Color.DarkGreen;
            }
        }

        private void buttonSoundOff_SecondClick(object sender, EventArgs e)
        {
            ServiceController serviceControllerAudio = ServiceController.GetServices().Single(ServiceHandler());

            if (serviceControllerAudio.Status.Equals(ServiceControllerStatus.Stopped))
            {
                serviceControllerAudio.Start();

                buttonSoundOff.Text = "Выключить";
                labelAudioStatus.Text = "Звук включен";
                labelAudioStatus.ForeColor = Color.DarkGreen;

                buttonSoundOff.Click += new EventHandler(buttonSoundOff_Click);
                buttonSoundOff.Click -= new EventHandler(buttonSoundOff_SecondClick);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceController serviceControllerAudio = ServiceController.GetServices().Single(ServiceHandler());

            label2.Text = serviceControllerAudio.Status.ToString();
        }
        #endregion

    }
}

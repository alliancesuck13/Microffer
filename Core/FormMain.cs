using Microffer.Core;
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

            // Реализация mutex
            if (!InstanceChecker.TakeMemory())
            {
                labelCopy.Text = "Копия программы!";
                labelCopy.Location = new Point(6, 16);
                labelHeader.Text = String.Empty;
            }

            FormClosing += (s, a) => InstanceChecker.ReleaseMemory();
            // Освобождение памяти при сворачивании в трей
            SizeChanged += (s, a) =>
            {
                if (WindowState == FormWindowState.Minimized)
                    InstanceChecker.ReleaseMemory();
            };

            // Покраска формы в нужный цвет 
            // Этот метод дает возможность исправить баг с белой полоской внизу формы
            FormPaint(Color.FromArgb(14, 22, 33), Color.FromArgb(14, 22, 33));

            // Перетаскивание панели и лейбла
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

            // Замена крестика, если ОС Windows 7
            if (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor <= 1)
                labelExit.Text = "☓";

            ServiceController serviceControllerAudio = ServiceController.GetServices().Single(ServiceHandler());
            if (serviceControllerAudio.Status.ToString() == "Running")
            {
                labelAudioStatus.Text = "Звук включен";
                notifyIconDefault.Text = "Microffer - звук включен";

            }
            else
            {
                labelAudioStatus.Text = "Звук отключен";
                labelAudioStatus.ForeColor = Color.FromArgb(127, 145, 164);

                отключитьЗвукToolStripMenuItem.Text = "Включить звук";
                notifyIconDefault.Text = "Microffer - звук отключен";

                buttonSoundOff.Text = "Включить";
            }
        }

        // Поиск службы Audiosrv
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
        private void labelSettings_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormSettings"] == null)
                new FormSettings().Show();
        }
        #endregion

        #region [ Form ]
        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                Application.Exit();
            }

            if (e.KeyValue == (char)Keys.Multiply)
            {
                ServiceController serviceControllerAudio = ServiceController.GetServices().Single(ServiceHandler());
                serviceControllerAudio.Stop();
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
            WindowState = FormWindowState.Normal;
        }

        private void отключитьЗвукToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceController serviceControllerAudio = ServiceController.GetServices().Single(ServiceHandler());

            if (serviceControllerAudio.Status.Equals(ServiceControllerStatus.Running))
            {
                serviceControllerAudio.Stop();

                отключитьЗвукToolStripMenuItem.Text = "Включить звук";
                notifyIconDefault.Text = "Microffer - звук отключен";

                отключитьЗвукToolStripMenuItem.Click -= new EventHandler(отключитьЗвукToolStripMenuItem_Click);
                отключитьЗвукToolStripMenuItem.Click += new EventHandler(отключитьЗвукToolStripMenuItem_SecondClick);
            }
            else
            {
                serviceControllerAudio.Start();

                отключитьЗвукToolStripMenuItem.Text = "Отключить звук";
                notifyIconDefault.Text = "Microffer - звук включен";
            }
        }

        private void отключитьЗвукToolStripMenuItem_SecondClick(object sender, EventArgs e)
        {
            ServiceController serviceControllerAudio = ServiceController.GetServices().Single(ServiceHandler());

            if (serviceControllerAudio.Status.Equals(ServiceControllerStatus.Stopped))
            {
                serviceControllerAudio.Start();

                отключитьЗвукToolStripMenuItem.Text = "Отключить звук";
                notifyIconDefault.Text = "Microffer - звук включен";

                отключитьЗвукToolStripMenuItem.Click += new EventHandler(отключитьЗвукToolStripMenuItem_Click);
                отключитьЗвукToolStripMenuItem.Click -= new EventHandler(отключитьЗвукToolStripMenuItem_SecondClick);
            }
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
                labelAudioStatus.Text = "Звук отключен";
                labelAudioStatus.ForeColor = Color.FromArgb(127, 145, 164);

                buttonSoundOff.Click -= new EventHandler(buttonSoundOff_Click);
                buttonSoundOff.Click += new EventHandler(buttonSoundOff_SecondClick);
            }
            else
            {
                serviceControllerAudio.Start();

                buttonSoundOff.Text = "Отключить";
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

                buttonSoundOff.Text = "Отключить";
                labelAudioStatus.Text = "Звук включен";
                labelAudioStatus.ForeColor = Color.DarkGreen;

                buttonSoundOff.Click += new EventHandler(buttonSoundOff_Click);
                buttonSoundOff.Click -= new EventHandler(buttonSoundOff_SecondClick);
            }
        }
        #endregion

    }
}

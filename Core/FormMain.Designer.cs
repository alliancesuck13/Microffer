namespace Microffer
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelCopy = new System.Windows.Forms.Label();
            this.labelSettings = new System.Windows.Forms.Label();
            this.labelMinimize = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.notifyIconDefault = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.microfferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отключитьЗвукToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSoundOff = new System.Windows.Forms.Button();
            this.labelAudioStatus = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panelHeader.Controls.Add(this.labelCopy);
            this.panelHeader.Controls.Add(this.labelSettings);
            this.panelHeader.Controls.Add(this.labelMinimize);
            this.panelHeader.Controls.Add(this.labelExit);
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Location = new System.Drawing.Point(-5, -10);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(288, 34);
            this.panelHeader.TabIndex = 0;
            // 
            // labelCopy
            // 
            this.labelCopy.AutoSize = true;
            this.labelCopy.BackColor = System.Drawing.Color.Transparent;
            this.labelCopy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(181)))), ((int)(((byte)(247)))));
            this.labelCopy.Location = new System.Drawing.Point(87, 15);
            this.labelCopy.Name = "labelCopy";
            this.labelCopy.Size = new System.Drawing.Size(0, 13);
            this.labelCopy.TabIndex = 4;
            this.labelCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.BackColor = System.Drawing.Color.Transparent;
            this.labelSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSettings.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.labelSettings.Location = new System.Drawing.Point(214, 14);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(16, 16);
            this.labelSettings.TabIndex = 3;
            this.labelSettings.Text = "⛭";
            this.labelSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSettings.Click += new System.EventHandler(this.labelSettings_Click);
            this.labelSettings.MouseEnter += new System.EventHandler(this.labelSettings_MouseEnter);
            this.labelSettings.MouseLeave += new System.EventHandler(this.labelSettings_MouseLeave);
            // 
            // labelMinimize
            // 
            this.labelMinimize.AutoSize = true;
            this.labelMinimize.BackColor = System.Drawing.Color.Transparent;
            this.labelMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMinimize.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.labelMinimize.Location = new System.Drawing.Point(233, 14);
            this.labelMinimize.Name = "labelMinimize";
            this.labelMinimize.Size = new System.Drawing.Size(20, 16);
            this.labelMinimize.TabIndex = 2;
            this.labelMinimize.Text = "—";
            this.labelMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMinimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelMinimize_MouseClick);
            this.labelMinimize.MouseEnter += new System.EventHandler(this.labelMinimize_MouseEnter);
            this.labelMinimize.MouseLeave += new System.EventHandler(this.labelMinimize_MouseLeave);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.labelExit.Location = new System.Drawing.Point(257, 13);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(19, 16);
            this.labelExit.TabIndex = 1;
            this.labelExit.Text = "❌";
            this.labelExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelExit_MouseClick);
            this.labelExit.MouseEnter += new System.EventHandler(this.labelExit_MouseEnter);
            this.labelExit.MouseLeave += new System.EventHandler(this.labelExit_MouseLeave);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelHeader.Font = new System.Drawing.Font("Verdana", 10F);
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.labelHeader.Location = new System.Drawing.Point(6, 13);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(68, 17);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Microffer";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHeader.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelHeader_MouseClick);
            // 
            // notifyIconDefault
            // 
            this.notifyIconDefault.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIconDefault.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconDefault.Icon")));
            this.notifyIconDefault.Text = "Microffer - трей";
            this.notifyIconDefault.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconDefault_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.microfferToolStripMenuItem,
            this.отключитьЗвукToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(160, 92);
            // 
            // microfferToolStripMenuItem
            // 
            this.microfferToolStripMenuItem.Name = "microfferToolStripMenuItem";
            this.microfferToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.microfferToolStripMenuItem.Text = "Microffer";
            this.microfferToolStripMenuItem.Click += new System.EventHandler(this.microfferToolStripMenuItem_Click);
            // 
            // отключитьЗвукToolStripMenuItem
            // 
            this.отключитьЗвукToolStripMenuItem.Name = "отключитьЗвукToolStripMenuItem";
            this.отключитьЗвукToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.отключитьЗвукToolStripMenuItem.Text = "Отключить звук";
            this.отключитьЗвукToolStripMenuItem.Click += new System.EventHandler(this.отключитьЗвукToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.выходToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.выходToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.выходToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(185)))), ((int)(((byte)(245)))));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.выходToolStripMenuItem.Text = "Закрыть";
            this.выходToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // buttonSoundOff
            // 
            this.buttonSoundOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.buttonSoundOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSoundOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSoundOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(140)))), ((int)(((byte)(158)))));
            this.buttonSoundOff.Location = new System.Drawing.Point(100, 68);
            this.buttonSoundOff.Name = "buttonSoundOff";
            this.buttonSoundOff.Size = new System.Drawing.Size(75, 23);
            this.buttonSoundOff.TabIndex = 1;
            this.buttonSoundOff.TabStop = false;
            this.buttonSoundOff.Text = "Отключить";
            this.buttonSoundOff.UseVisualStyleBackColor = false;
            this.buttonSoundOff.Click += new System.EventHandler(this.buttonSoundOff_Click);
            this.buttonSoundOff.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSoundOff_MouseDown);
            // 
            // labelAudioStatus
            // 
            this.labelAudioStatus.AutoSize = true;
            this.labelAudioStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelAudioStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAudioStatus.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelAudioStatus.Location = new System.Drawing.Point(82, 36);
            this.labelAudioStatus.Name = "labelAudioStatus";
            this.labelAudioStatus.Size = new System.Drawing.Size(110, 19);
            this.labelAudioStatus.TabIndex = 2;
            this.labelAudioStatus.Text = "Звук включен";
            this.labelAudioStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(275, 126);
            this.Controls.Add(this.labelAudioStatus);
            this.Controls.Add(this.buttonSoundOff);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Microffer";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelMinimize;
        private System.Windows.Forms.NotifyIcon notifyIconDefault;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microfferToolStripMenuItem;
        private System.Windows.Forms.Button buttonSoundOff;
        private System.Windows.Forms.Label labelAudioStatus;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Label labelCopy;
        private System.Windows.Forms.ToolStripMenuItem отключитьЗвукToolStripMenuItem;
    }
}


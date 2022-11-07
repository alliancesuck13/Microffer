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
            this.labelMinimize = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.notifyIconDefault = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.microfferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonMicOff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panelHeader.Controls.Add(this.labelMinimize);
            this.panelHeader.Controls.Add(this.labelExit);
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Location = new System.Drawing.Point(-5, -10);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(288, 34);
            this.panelHeader.TabIndex = 0;
            // 
            // labelMinimize
            // 
            this.labelMinimize.AutoSize = true;
            this.labelMinimize.BackColor = System.Drawing.Color.Transparent;
            this.labelMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMinimize.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.labelMinimize.Location = new System.Drawing.Point(232, 14);
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
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(139, 70);
            // 
            // microfferToolStripMenuItem
            // 
            this.microfferToolStripMenuItem.Name = "microfferToolStripMenuItem";
            this.microfferToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.microfferToolStripMenuItem.Text = "Microffer";
            this.microfferToolStripMenuItem.Click += new System.EventHandler(this.microfferToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
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
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.выходToolStripMenuItem.Text = "Закрыть";
            this.выходToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // buttonMicOff
            // 
            this.buttonMicOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.buttonMicOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMicOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMicOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(140)))), ((int)(((byte)(158)))));
            this.buttonMicOff.Location = new System.Drawing.Point(100, 88);
            this.buttonMicOff.Name = "buttonMicOff";
            this.buttonMicOff.Size = new System.Drawing.Size(75, 23);
            this.buttonMicOff.TabIndex = 1;
            this.buttonMicOff.TabStop = false;
            this.buttonMicOff.Text = "Выключить";
            this.buttonMicOff.UseVisualStyleBackColor = false;
            this.buttonMicOff.Click += new System.EventHandler(this.buttonMicOff_Click);
            this.buttonMicOff.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMicOff_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(185)))), ((int)(((byte)(245)))));
            this.label1.Location = new System.Drawing.Point(97, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(275, 174);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMicOff);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button buttonMicOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}


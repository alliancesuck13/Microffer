namespace Microffer.Core
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelLeaveSettings = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.checkBoxHotkey = new System.Windows.Forms.CheckBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panelHeader.Controls.Add(this.panelMain);
            this.panelHeader.Controls.Add(this.labelLeaveSettings);
            this.panelHeader.Controls.Add(this.labelExit);
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(233, 25);
            this.panelHeader.TabIndex = 2;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Location = new System.Drawing.Point(0, 24);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(233, 77);
            this.panelMain.TabIndex = 2;
            // 
            // labelLeaveSettings
            // 
            this.labelLeaveSettings.AutoSize = true;
            this.labelLeaveSettings.BackColor = System.Drawing.Color.Transparent;
            this.labelLeaveSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLeaveSettings.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLeaveSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.labelLeaveSettings.Location = new System.Drawing.Point(206, 4);
            this.labelLeaveSettings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLeaveSettings.Name = "labelLeaveSettings";
            this.labelLeaveSettings.Size = new System.Drawing.Size(19, 16);
            this.labelLeaveSettings.TabIndex = 2;
            this.labelLeaveSettings.Text = "❌";
            this.labelLeaveSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLeaveSettings.Click += new System.EventHandler(this.labelLeaveSettings_Click);
            this.labelLeaveSettings.MouseEnter += new System.EventHandler(this.labelLeaveSettings_MouseEnter);
            this.labelLeaveSettings.MouseLeave += new System.EventHandler(this.labelLeaveSettings_MouseLeave);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.labelExit.Location = new System.Drawing.Point(300, 13);
            this.labelExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(19, 16);
            this.labelExit.TabIndex = 1;
            this.labelExit.Text = "❌";
            this.labelExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Verdana", 10F);
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.labelHeader.Location = new System.Drawing.Point(4, 4);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(85, 17);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Настройки";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxHotkey
            // 
            this.checkBoxHotkey.AutoSize = true;
            this.checkBoxHotkey.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxHotkey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(82)))), ((int)(((byte)(120)))));
            this.checkBoxHotkey.Location = new System.Drawing.Point(7, 31);
            this.checkBoxHotkey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxHotkey.Name = "checkBoxHotkey";
            this.checkBoxHotkey.Size = new System.Drawing.Size(188, 17);
            this.checkBoxHotkey.TabIndex = 3;
            this.checkBoxHotkey.Text = "Использовать горячие клавиши";
            this.checkBoxHotkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxHotkey.UseVisualStyleBackColor = true;
            this.checkBoxHotkey.CheckedChanged += new System.EventHandler(this.checkBoxHotkey_CheckedChanged);
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.buttonAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccept.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(140)))), ((int)(((byte)(158)))));
            this.buttonAccept.Location = new System.Drawing.Point(145, 65);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 4;
            this.buttonAccept.TabStop = false;
            this.buttonAccept.Text = "Принять";
            this.buttonAccept.UseVisualStyleBackColor = false;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // textBox
            // 
            this.textBox.Enabled = false;
            this.textBox.Location = new System.Drawing.Point(7, 54);
            this.textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox.MaxLength = 1;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(23, 21);
            this.textBox.TabIndex = 5;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(140)))), ((int)(((byte)(158)))));
            this.labelKey.Location = new System.Drawing.Point(34, 60);
            this.labelKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(52, 13);
            this.labelKey.TabIndex = 6;
            this.labelKey.Text = "Клавиша";
            this.labelKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(233, 100);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.checkBoxHotkey);
            this.Controls.Add(this.panelHeader);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSettings_KeyDown);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelLeaveSettings;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.CheckBox checkBoxHotkey;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelKey;
    }
}
namespace Microffer
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelLeaveAbout = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelTextAbout = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelAuthorName = new System.Windows.Forms.Label();
            this.labelVersionNum = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panelHeader.Controls.Add(this.panelMain);
            this.panelHeader.Controls.Add(this.labelLeaveAbout);
            this.panelHeader.Controls.Add(this.labelExit);
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(200, 25);
            this.panelHeader.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Location = new System.Drawing.Point(0, 24);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(200, 77);
            this.panelMain.TabIndex = 2;
            // 
            // labelLeaveAbout
            // 
            this.labelLeaveAbout.AutoSize = true;
            this.labelLeaveAbout.BackColor = System.Drawing.Color.Transparent;
            this.labelLeaveAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLeaveAbout.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLeaveAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.labelLeaveAbout.Location = new System.Drawing.Point(177, 4);
            this.labelLeaveAbout.Name = "labelLeaveAbout";
            this.labelLeaveAbout.Size = new System.Drawing.Size(19, 16);
            this.labelLeaveAbout.TabIndex = 2;
            this.labelLeaveAbout.Text = "❌";
            this.labelLeaveAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLeaveAbout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelLeaveAbout_MouseClick);
            this.labelLeaveAbout.MouseEnter += new System.EventHandler(this.labelLeaveAbout_MouseEnter);
            this.labelLeaveAbout.MouseLeave += new System.EventHandler(this.labelLeaveAbout_MouseLeave);
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
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Verdana", 10F);
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.labelHeader.Location = new System.Drawing.Point(3, 4);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(103, 17);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "О программе";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTextAbout
            // 
            this.labelTextAbout.BackColor = System.Drawing.Color.Transparent;
            this.labelTextAbout.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(82)))), ((int)(((byte)(120)))));
            this.labelTextAbout.Location = new System.Drawing.Point(14, 28);
            this.labelTextAbout.Name = "labelTextAbout";
            this.labelTextAbout.Size = new System.Drawing.Size(173, 44);
            this.labelTextAbout.TabIndex = 2;
            this.labelTextAbout.Text = "Microffer — это программа, созданная для отключения/включения звука";
            this.labelTextAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAutor
            // 
            this.labelAutor.BackColor = System.Drawing.Color.Transparent;
            this.labelAutor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(140)))), ((int)(((byte)(158)))));
            this.labelAutor.Location = new System.Drawing.Point(6, 77);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(74, 20);
            this.labelAutor.TabIndex = 3;
            this.labelAutor.Text = "Автор:";
            this.labelAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(140)))), ((int)(((byte)(158)))));
            this.labelVersion.Location = new System.Drawing.Point(126, 81);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(87, 13);
            this.labelVersion.TabIndex = 4;
            this.labelVersion.Text = "Версия:";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.BackColor = System.Drawing.Color.Transparent;
            this.labelAuthorName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAuthorName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthorName.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.labelAuthorName.Location = new System.Drawing.Point(43, 77);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(37, 20);
            this.labelAuthorName.TabIndex = 5;
            this.labelAuthorName.Text = "fe2ck";
            this.labelAuthorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAuthorName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelAuthorName_MouseClick);
            // 
            // labelVersionNum
            // 
            this.labelVersionNum.BackColor = System.Drawing.Color.Transparent;
            this.labelVersionNum.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVersionNum.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.labelVersionNum.Location = new System.Drawing.Point(168, 80);
            this.labelVersionNum.Name = "labelVersionNum";
            this.labelVersionNum.Size = new System.Drawing.Size(47, 14);
            this.labelVersionNum.TabIndex = 6;
            this.labelVersionNum.Text = "num";
            this.labelVersionNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(200, 100);
            this.Controls.Add(this.labelVersionNum);
            this.Controls.Add(this.labelAuthorName);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelTextAbout);
            this.Controls.Add(this.panelHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelLeaveAbout;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelTextAbout;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelAuthorName;
        private System.Windows.Forms.Label labelVersionNum;
    }
}
namespace Lab3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richText = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDinhDang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripCmb1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripCmb2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripB = new System.Windows.Forms.ToolStripButton();
            this.toolStripI = new System.Windows.Forms.ToolStripButton();
            this.toolStripU = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richText
            // 
            this.richText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richText.Location = new System.Drawing.Point(0, 125);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(1264, 570);
            this.richText.TabIndex = 3;
            this.richText.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.menuDinhDang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHeThong
            // 
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuNew,
            this.toolStripMenuOpen,
            this.toolStripSeparator3,
            this.toolStripMenuSave,
            this.toolStripMenuExit});
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(152, 36);
            this.menuHeThong.Text = "HỆ THỐNG";
            // 
            // toolStripMenuNew
            // 
            this.toolStripMenuNew.Name = "toolStripMenuNew";
            this.toolStripMenuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuNew.Size = new System.Drawing.Size(462, 44);
            this.toolStripMenuNew.Text = "Tạo văn bản mới";
            this.toolStripMenuNew.Click += new System.EventHandler(this.toolStripMenuNew_Click);
            // 
            // toolStripMenuOpen
            // 
            this.toolStripMenuOpen.Name = "toolStripMenuOpen";
            this.toolStripMenuOpen.Size = new System.Drawing.Size(462, 44);
            this.toolStripMenuOpen.Text = "Mở tập tin";
            this.toolStripMenuOpen.Click += new System.EventHandler(this.toolStripMenuOpen_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(459, 6);
            // 
            // toolStripMenuSave
            // 
            this.toolStripMenuSave.Name = "toolStripMenuSave";
            this.toolStripMenuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuSave.Size = new System.Drawing.Size(462, 44);
            this.toolStripMenuSave.Text = "Lưu nội dung văn bản";
            // 
            // toolStripMenuExit
            // 
            this.toolStripMenuExit.Name = "toolStripMenuExit";
            this.toolStripMenuExit.Size = new System.Drawing.Size(462, 44);
            this.toolStripMenuExit.Text = "Thoát";
            this.toolStripMenuExit.Click += new System.EventHandler(this.toolStripMenuExit_Click);
            // 
            // menuDinhDang
            // 
            this.menuDinhDang.Name = "menuDinhDang";
            this.menuDinhDang.Size = new System.Drawing.Size(165, 36);
            this.menuDinhDang.Text = "ĐỊNH DẠNG";
            this.menuDinhDang.Click += new System.EventHandler(this.menuDinhDang_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNew,
            this.toolStripSave,
            this.toolStripSeparator1,
            this.toolStripCmb1,
            this.toolStripCmb2,
            this.toolStripB,
            this.toolStripI,
            this.toolStripU,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 42);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripNew
            // 
            this.toolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNew.Image")));
            this.toolStripNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNew.Name = "toolStripNew";
            this.toolStripNew.RightToLeftAutoMirrorImage = true;
            this.toolStripNew.Size = new System.Drawing.Size(46, 36);
            this.toolStripNew.Text = "toolStripButton1";
            this.toolStripNew.Click += new System.EventHandler(this.toolStripNew_Click);
            // 
            // toolStripSave
            // 
            this.toolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(46, 36);
            this.toolStripSave.Text = "toolStripButton2";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // toolStripCmb1
            // 
            this.toolStripCmb1.Name = "toolStripCmb1";
            this.toolStripCmb1.Size = new System.Drawing.Size(121, 42);
            // 
            // toolStripCmb2
            // 
            this.toolStripCmb2.Name = "toolStripCmb2";
            this.toolStripCmb2.Size = new System.Drawing.Size(121, 42);
            // 
            // toolStripB
            // 
            this.toolStripB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripB.Image = ((System.Drawing.Image)(resources.GetObject("toolStripB.Image")));
            this.toolStripB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripB.Name = "toolStripB";
            this.toolStripB.Size = new System.Drawing.Size(46, 36);
            this.toolStripB.Text = "toolStripButton3";
            this.toolStripB.Click += new System.EventHandler(this.toolStripB_Click_1);
            // 
            // toolStripI
            // 
            this.toolStripI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripI.Image = ((System.Drawing.Image)(resources.GetObject("toolStripI.Image")));
            this.toolStripI.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripI.Name = "toolStripI";
            this.toolStripI.Size = new System.Drawing.Size(46, 36);
            this.toolStripI.Text = "toolStripButton4";
            this.toolStripI.Click += new System.EventHandler(this.toolStripI_Click);
            // 
            // toolStripU
            // 
            this.toolStripU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripU.Image = ((System.Drawing.Image)(resources.GetObject("toolStripU.Image")));
            this.toolStripU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripU.Name = "toolStripU";
            this.toolStripU.Size = new System.Drawing.Size(46, 36);
            this.toolStripU.Text = "toolStripButton5";
            this.toolStripU.Click += new System.EventHandler(this.toolStripU_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 695);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SOẠN THẢO VĂN BẢN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuDinhDang;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripNew;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripCmb1;
        private System.Windows.Forms.ToolStripComboBox toolStripCmb2;
        private System.Windows.Forms.ToolStripButton toolStripB;
        private System.Windows.Forms.ToolStripButton toolStripI;
        private System.Windows.Forms.ToolStripButton toolStripU;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuNew;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExit;
    }
}


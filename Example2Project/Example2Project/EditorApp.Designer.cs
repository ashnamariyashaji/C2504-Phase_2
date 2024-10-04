namespace Example2Project
{
    partial class EditorApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorApp));
            this.lblTitile = new System.Windows.Forms.Label();
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.mnuEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuRed2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlue2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGreen2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.staPage = new System.Windows.Forms.StatusStrip();
            this.staColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.staForeColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuBar = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRedBg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlueBg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGreenbg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBg = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlignLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlignCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlignRight = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toRight = new System.Windows.Forms.ToolStripButton();
            this.toCenter = new System.Windows.Forms.ToolStripButton();
            this.toLeft = new System.Windows.Forms.ToolStripButton();
            this.mnuEditor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.staPage.SuspendLayout();
            this.mnuBar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitile
            // 
            this.lblTitile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTitile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitile.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitile.Location = new System.Drawing.Point(0, 61);
            this.lblTitile.Name = "lblTitile";
            this.lblTitile.Size = new System.Drawing.Size(1004, 75);
            this.lblTitile.TabIndex = 0;
            this.lblTitile.Text = "Editor App";
            this.lblTitile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEditor
            // 
            this.txtEditor.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtEditor.ContextMenuStrip = this.mnuEditor;
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditor.Location = new System.Drawing.Point(0, 136);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(1004, 553);
            this.txtEditor.TabIndex = 1;
            this.txtEditor.Text = "Iam Ashna Mariya Shaji\r\nIntern of C#\r\nQuest Global\r\n\r\n";
            // 
            // mnuEditor
            // 
            this.mnuEditor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRed2,
            this.mnuBlue2,
            this.mnuGreen2});
            this.mnuEditor.Name = "mnuEditor";
            this.mnuEditor.Size = new System.Drawing.Size(241, 76);
            // 
            // mnuRed2
            // 
            this.mnuRed2.Name = "mnuRed2";
            this.mnuRed2.Size = new System.Drawing.Size(240, 24);
            this.mnuRed2.Text = "Red Background Color";
            this.mnuRed2.Click += new System.EventHandler(this.mnuRed2_Click);
            // 
            // mnuBlue2
            // 
            this.mnuBlue2.Name = "mnuBlue2";
            this.mnuBlue2.Size = new System.Drawing.Size(240, 24);
            this.mnuBlue2.Text = "Blue Background Color";
            this.mnuBlue2.Click += new System.EventHandler(this.mnuBlue2_Click);
            // 
            // mnuGreen2
            // 
            this.mnuGreen2.Name = "mnuGreen2";
            this.mnuGreen2.Size = new System.Drawing.Size(240, 24);
            this.mnuGreen2.Text = "Green Background Color";
            this.mnuGreen2.Click += new System.EventHandler(this.mnuGreen2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnForeColor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.btnGreen);
            this.panel1.Controls.Add(this.btnBlue);
            this.panel1.Controls.Add(this.btnRed);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 563);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 100);
            this.panel1.TabIndex = 2;
            // 
            // btnForeColor
            // 
            this.btnForeColor.Location = new System.Drawing.Point(607, 36);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(108, 34);
            this.btnForeColor.TabIndex = 6;
            this.btnForeColor.Text = "Pick Color";
            this.btnForeColor.UseVisualStyleBackColor = true;
            this.btnForeColor.Click += new System.EventHandler(this.btnForeColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(605, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Foreground";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Background";
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(459, 30);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(105, 46);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGreen.Location = new System.Drawing.Point(341, 30);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(92, 46);
            this.btnGreen.TabIndex = 2;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBlue.Location = new System.Drawing.Point(197, 30);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(112, 46);
            this.btnBlue.TabIndex = 1;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.IndianRed;
            this.btnRed.Location = new System.Drawing.Point(42, 30);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(119, 46);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // staPage
            // 
            this.staPage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.staPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staColor,
            this.staForeColor});
            this.staPage.Location = new System.Drawing.Point(0, 663);
            this.staPage.Name = "staPage";
            this.staPage.Size = new System.Drawing.Size(1004, 26);
            this.staPage.TabIndex = 3;
            this.staPage.Text = "statusStrip1";
            // 
            // staColor
            // 
            this.staColor.Name = "staColor";
            this.staColor.Size = new System.Drawing.Size(76, 20);
            this.staColor.Text = "IndianRed";
            // 
            // staForeColor
            // 
            this.staForeColor.Name = "staForeColor";
            this.staForeColor.Size = new System.Drawing.Size(74, 20);
            this.staForeColor.Text = "ForeColor";
            // 
            // mnuBar
            // 
            this.mnuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuColor,
            this.mnFormat});
            this.mnuBar.Location = new System.Drawing.Point(0, 31);
            this.mnuBar.Name = "mnuBar";
            this.mnuBar.Size = new System.Drawing.Size(1004, 30);
            this.mnuBar.TabIndex = 5;
            this.mnuBar.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.toolStripSeparator2,
            this.mnuSave});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 26);
            this.mnuFile.Text = "File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(128, 26);
            this.mnuOpen.Text = "Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(125, 6);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(128, 26);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuColor
            // 
            this.mnuColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRedBg,
            this.mnuBlueBg,
            this.mnuGreenbg,
            this.mnuBg,
            this.toolStripSeparator1,
            this.mnuFg});
            this.mnuColor.Name = "mnuColor";
            this.mnuColor.Size = new System.Drawing.Size(59, 26);
            this.mnuColor.Text = "Color";
            // 
            // mnuRedBg
            // 
            this.mnuRedBg.Name = "mnuRedBg";
            this.mnuRedBg.Size = new System.Drawing.Size(254, 26);
            this.mnuRedBg.Text = "Red Background Color";
            this.mnuRedBg.Click += new System.EventHandler(this.mnuRedBg_Click);
            // 
            // mnuBlueBg
            // 
            this.mnuBlueBg.Name = "mnuBlueBg";
            this.mnuBlueBg.Size = new System.Drawing.Size(254, 26);
            this.mnuBlueBg.Text = "Blue Background Color";
            this.mnuBlueBg.Click += new System.EventHandler(this.mnuBlueBg_Click);
            // 
            // mnuGreenbg
            // 
            this.mnuGreenbg.Name = "mnuGreenbg";
            this.mnuGreenbg.Size = new System.Drawing.Size(254, 26);
            this.mnuGreenbg.Text = "Green Background Color";
            this.mnuGreenbg.Click += new System.EventHandler(this.mnuGreenbg_Click);
            // 
            // mnuBg
            // 
            this.mnuBg.Name = "mnuBg";
            this.mnuBg.Size = new System.Drawing.Size(254, 26);
            this.mnuBg.Text = "Other Background Color";
            this.mnuBg.Click += new System.EventHandler(this.mnuBg_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(251, 6);
            // 
            // mnuFg
            // 
            this.mnuFg.Name = "mnuFg";
            this.mnuFg.Size = new System.Drawing.Size(254, 26);
            this.mnuFg.Text = "Foreground Color";
            this.mnuFg.Click += new System.EventHandler(this.mnuFg_Click);
            // 
            // mnFormat
            // 
            this.mnFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFont,
            this.mnuAlignLeft,
            this.mnuAlignCenter,
            this.mnuAlignRight});
            this.mnFormat.Name = "mnFormat";
            this.mnFormat.Size = new System.Drawing.Size(70, 26);
            this.mnFormat.Text = "Format";
            // 
            // mnuFont
            // 
            this.mnuFont.Name = "mnuFont";
            this.mnuFont.Size = new System.Drawing.Size(174, 26);
            this.mnuFont.Text = "Font";
            this.mnuFont.Click += new System.EventHandler(this.mnuFont_Click);
            // 
            // mnuAlignLeft
            // 
            this.mnuAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("mnuAlignLeft.Image")));
            this.mnuAlignLeft.Name = "mnuAlignLeft";
            this.mnuAlignLeft.Size = new System.Drawing.Size(174, 26);
            this.mnuAlignLeft.Text = "Align Left";
            this.mnuAlignLeft.Click += new System.EventHandler(this.mnuAlignLeft_Click);
            // 
            // mnuAlignCenter
            // 
            this.mnuAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("mnuAlignCenter.Image")));
            this.mnuAlignCenter.Name = "mnuAlignCenter";
            this.mnuAlignCenter.Size = new System.Drawing.Size(174, 26);
            this.mnuAlignCenter.Text = "Align Center";
            this.mnuAlignCenter.Click += new System.EventHandler(this.mnuAlignCenter_Click);
            // 
            // mnuAlignRight
            // 
            this.mnuAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("mnuAlignRight.Image")));
            this.mnuAlignRight.Name = "mnuAlignRight";
            this.mnuAlignRight.Size = new System.Drawing.Size(174, 26);
            this.mnuAlignRight.Text = "Align Right";
            this.mnuAlignRight.Click += new System.EventHandler(this.mnuAlignRight_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "mytext";
            // 
            // dlgSave
            // 
            this.dlgSave.FileName = "mytext1.txt";
            this.dlgSave.Filter = "Text File(*.txt) | JSON File (*.json)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toRight,
            this.toCenter,
            this.toLeft});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1004, 31);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toRight
            // 
            this.toRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toRight.Image = ((System.Drawing.Image)(resources.GetObject("toRight.Image")));
            this.toRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toRight.Name = "toRight";
            this.toRight.Size = new System.Drawing.Size(29, 28);
            this.toRight.Text = "toolStripButton1";
            this.toRight.Click += new System.EventHandler(this.toRight_Click);
            // 
            // toCenter
            // 
            this.toCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toCenter.Image = ((System.Drawing.Image)(resources.GetObject("toCenter.Image")));
            this.toCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toCenter.Name = "toCenter";
            this.toCenter.Size = new System.Drawing.Size(29, 28);
            this.toCenter.Text = "toolStripButton2";
            this.toCenter.Click += new System.EventHandler(this.toCenter_Click);
            // 
            // toLeft
            // 
            this.toLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toLeft.Image = ((System.Drawing.Image)(resources.GetObject("toLeft.Image")));
            this.toLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toLeft.Name = "toLeft";
            this.toLeft.Size = new System.Drawing.Size(29, 28);
            this.toLeft.Text = "toolStripButton3";
            this.toLeft.Click += new System.EventHandler(this.toLeft_Click);
            // 
            // EditorApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 689);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.staPage);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.lblTitile);
            this.Controls.Add(this.mnuBar);
            this.Controls.Add(this.toolStrip1);
            this.MainMenuStrip = this.mnuBar;
            this.Name = "EditorApp";
            this.Text = "Editor App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuEditor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.staPage.ResumeLayout(false);
            this.staPage.PerformLayout();
            this.mnuBar.ResumeLayout(false);
            this.mnuBar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitile;
        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.StatusStrip staPage;
        private System.Windows.Forms.ToolStripStatusLabel staColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel staForeColor;
        private System.Windows.Forms.ContextMenuStrip mnuEditor;
        private System.Windows.Forms.MenuStrip mnuBar;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuColor;
        private System.Windows.Forms.ToolStripMenuItem mnuRedBg;
        private System.Windows.Forms.ToolStripMenuItem mnuBlueBg;
        private System.Windows.Forms.ToolStripMenuItem mnuGreenbg;
        private System.Windows.Forms.ToolStripMenuItem mnuBg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFg;
        private System.Windows.Forms.ToolStripMenuItem mnuRed2;
        private System.Windows.Forms.ToolStripMenuItem mnuBlue2;
        private System.Windows.Forms.ToolStripMenuItem mnuGreen2;
        private System.Windows.Forms.ToolStripMenuItem mnFormat;
        private System.Windows.Forms.ToolStripMenuItem mnuFont;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignLeft;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignCenter;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignRight;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toRight;
        private System.Windows.Forms.ToolStripButton toCenter;
        private System.Windows.Forms.ToolStripButton toLeft;
    }
}


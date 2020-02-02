namespace ImageProcessing
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMainStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInvert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDarken = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWhiten = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBrighten = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGray = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFlipX = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFlipY = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMirrorHor = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMirrorVert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScale50 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScale200 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRotate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlur = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.mnuMainStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainStrip
            // 
            this.mnuMainStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.mnuMainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuProcess,
            this.mnuAbout});
            this.mnuMainStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuMainStrip.Name = "mnuMainStrip";
            this.mnuMainStrip.Size = new System.Drawing.Size(849, 24);
            this.mnuMainStrip.TabIndex = 0;
            this.mnuMainStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuSave,
            this.mnuExit});
            this.mnuFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.mnuOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(180, 22);
            this.mnuOpen.Text = "Open";
            this.mnuOpen.Click += new System.EventHandler(this.tabLoad_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.mnuSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(180, 22);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.tabSave_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.mnuExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.tabExit_Click);
            // 
            // mnuProcess
            // 
            this.mnuProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.mnuProcess.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReset,
            this.mnuInvert,
            this.mnuDarken,
            this.mnuWhiten,
            this.mnuBrighten,
            this.mnuGray,
            this.mnuFlipX,
            this.mnuFlipY,
            this.mnuMirrorHor,
            this.tabMirrorVert,
            this.mnuScale50,
            this.mnuScale200,
            this.mnuRotate,
            this.mnuBlur});
            this.mnuProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mnuProcess.Name = "mnuProcess";
            this.mnuProcess.Size = new System.Drawing.Size(59, 20);
            this.mnuProcess.Text = "Process";
            // 
            // mnuReset
            // 
            this.mnuReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.mnuReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mnuReset.Name = "mnuReset";
            this.mnuReset.Size = new System.Drawing.Size(180, 22);
            this.mnuReset.Text = "Reset";
            this.mnuReset.Click += new System.EventHandler(this.tabReset_Click);
            // 
            // mnuInvert
            // 
            this.mnuInvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.mnuInvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mnuInvert.Name = "mnuInvert";
            this.mnuInvert.Size = new System.Drawing.Size(180, 22);
            this.mnuInvert.Text = "Invert";
            this.mnuInvert.Click += new System.EventHandler(this.tabInvert_Click);
            // 
            // mnuDarken
            // 
            this.mnuDarken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.mnuDarken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mnuDarken.Name = "mnuDarken";
            this.mnuDarken.Size = new System.Drawing.Size(180, 22);
            this.mnuDarken.Text = "Darken";
            this.mnuDarken.Click += new System.EventHandler(this.mnuDarken_Click);
            // 
            // mnuWhiten
            // 
            this.mnuWhiten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.mnuWhiten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mnuWhiten.Name = "mnuWhiten";
            this.mnuWhiten.Size = new System.Drawing.Size(180, 22);
            this.mnuWhiten.Text = "Whiten";
            this.mnuWhiten.Click += new System.EventHandler(this.tabWhiten_Click);
            // 
            // mnuBrighten
            // 
            this.mnuBrighten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.mnuBrighten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mnuBrighten.Name = "mnuBrighten";
            this.mnuBrighten.Size = new System.Drawing.Size(180, 22);
            this.mnuBrighten.Text = "Brighten";
            this.mnuBrighten.Click += new System.EventHandler(this.brightenToolStripMenuItem_Click);
            // 
            // mnuGray
            // 
            this.mnuGray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.mnuGray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mnuGray.Name = "mnuGray";
            this.mnuGray.Size = new System.Drawing.Size(180, 22);
            this.mnuGray.Text = "Greyscale";
            this.mnuGray.Click += new System.EventHandler(this.tabGray_Click);
            // 
            // mnuFlipX
            // 
            this.mnuFlipX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.mnuFlipX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mnuFlipX.Name = "mnuFlipX";
            this.mnuFlipX.Size = new System.Drawing.Size(180, 22);
            this.mnuFlipX.Text = "Flip X";
            this.mnuFlipX.Click += new System.EventHandler(this.tabFlipX_Click);
            // 
            // mnuFlipY
            // 
            this.mnuFlipY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.mnuFlipY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mnuFlipY.Name = "mnuFlipY";
            this.mnuFlipY.Size = new System.Drawing.Size(180, 22);
            this.mnuFlipY.Text = "Flip Y";
            this.mnuFlipY.Click += new System.EventHandler(this.tabFlipY_Click);
            // 
            // mnuMirrorHor
            // 
            this.mnuMirrorHor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.mnuMirrorHor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mnuMirrorHor.Name = "mnuMirrorHor";
            this.mnuMirrorHor.Size = new System.Drawing.Size(180, 22);
            this.mnuMirrorHor.Text = "Mirror Horizonal";
            this.mnuMirrorHor.Click += new System.EventHandler(this.tabMirrorHor_Click);
            // 
            // tabMirrorVert
            // 
            this.tabMirrorVert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.tabMirrorVert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabMirrorVert.Name = "tabMirrorVert";
            this.tabMirrorVert.Size = new System.Drawing.Size(180, 22);
            this.tabMirrorVert.Text = "Mirror Vertical";
            this.tabMirrorVert.Click += new System.EventHandler(this.tabMirrorVert_Click);
            // 
            // mnuScale50
            // 
            this.mnuScale50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.mnuScale50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mnuScale50.Name = "mnuScale50";
            this.mnuScale50.Size = new System.Drawing.Size(180, 22);
            this.mnuScale50.Text = "Scale 50";
            this.mnuScale50.Click += new System.EventHandler(this.tabScale50_Click);
            // 
            // mnuScale200
            // 
            this.mnuScale200.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.mnuScale200.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mnuScale200.Name = "mnuScale200";
            this.mnuScale200.Size = new System.Drawing.Size(180, 22);
            this.mnuScale200.Text = "Scale 200";
            this.mnuScale200.Click += new System.EventHandler(this.tabScale200_Click);
            // 
            // mnuRotate
            // 
            this.mnuRotate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.mnuRotate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mnuRotate.Name = "mnuRotate";
            this.mnuRotate.Size = new System.Drawing.Size(180, 22);
            this.mnuRotate.Text = "Rotate";
            this.mnuRotate.Click += new System.EventHandler(this.tabRotate_Click);
            // 
            // mnuBlur
            // 
            this.mnuBlur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.mnuBlur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mnuBlur.Name = "mnuBlur";
            this.mnuBlur.Size = new System.Drawing.Size(180, 22);
            this.mnuBlur.Text = "Blur";
            this.mnuBlur.Click += new System.EventHandler(this.tabBlur_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(52, 20);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.picBox.Location = new System.Drawing.Point(24, 36);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(800, 600);
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(849, 657);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.mnuMainStrip);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMainStrip;
            this.Name = "frmMain";
            this.Text = "Image Processing";
            this.TransparencyKey = System.Drawing.Color.LightGray;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMainStrip.ResumeLayout(false);
            this.mnuMainStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuProcess;
        private System.Windows.Forms.ToolStripMenuItem mnuReset;
        private System.Windows.Forms.ToolStripMenuItem mnuInvert;
        private System.Windows.Forms.ToolStripMenuItem mnuDarken;
        private System.Windows.Forms.ToolStripMenuItem mnuWhiten;
        private System.Windows.Forms.ToolStripMenuItem mnuGray;
        private System.Windows.Forms.ToolStripMenuItem mnuFlipX;
        private System.Windows.Forms.ToolStripMenuItem mnuFlipY;
        private System.Windows.Forms.ToolStripMenuItem mnuMirrorHor;
        private System.Windows.Forms.ToolStripMenuItem tabMirrorVert;
        private System.Windows.Forms.ToolStripMenuItem mnuScale50;
        private System.Windows.Forms.ToolStripMenuItem mnuScale200;
        private System.Windows.Forms.ToolStripMenuItem mnuRotate;
        private System.Windows.Forms.ToolStripMenuItem mnuBlur;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuBrighten;

    }
}


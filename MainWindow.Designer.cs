namespace Jeeja_ImageLabeller
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImagesFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadClassesFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLabelsToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autosaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursorSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawCrosshairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.listBoxClass = new System.Windows.Forms.ListBox();
            this.labelImageCount = new System.Windows.Forms.Label();
            this.textBoxGoto = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrev.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonPrev.Font = new System.Drawing.Font("Nunito ExtraBold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPrev.Location = new System.Drawing.Point(12, 619);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(625, 50);
            this.buttonPrev.TabIndex = 0;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNext.Font = new System.Drawing.Font("Nunito ExtraBold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNext.Location = new System.Drawing.Point(643, 619);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(609, 50);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.saveSettingsToolStripMenuItem,
            this.cursorSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 37);
            this.menuStrip1.TabIndex = 6;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImagesFromToolStripMenuItem,
            this.loadClassesFromToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(150, 33);
            this.settingsToolStripMenuItem.Text = "Load settings";
            // 
            // loadImagesFromToolStripMenuItem
            // 
            this.loadImagesFromToolStripMenuItem.Name = "loadImagesFromToolStripMenuItem";
            this.loadImagesFromToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.loadImagesFromToolStripMenuItem.Text = "Load images from";
            this.loadImagesFromToolStripMenuItem.Click += new System.EventHandler(this.loadImagesFromToolStripMenuItem_Click);
            // 
            // loadClassesFromToolStripMenuItem
            // 
            this.loadClassesFromToolStripMenuItem.Name = "loadClassesFromToolStripMenuItem";
            this.loadClassesFromToolStripMenuItem.Size = new System.Drawing.Size(255, 34);
            this.loadClassesFromToolStripMenuItem.Text = "Load classes from";
            this.loadClassesFromToolStripMenuItem.Click += new System.EventHandler(this.loadClassesFromToolStripMenuItem_Click);
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveLabelsToToolStripMenuItem,
            this.autosaveToolStripMenuItem});
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(150, 33);
            this.saveSettingsToolStripMenuItem.Text = "Save settings";
            // 
            // saveLabelsToToolStripMenuItem
            // 
            this.saveLabelsToToolStripMenuItem.Name = "saveLabelsToToolStripMenuItem";
            this.saveLabelsToToolStripMenuItem.Size = new System.Drawing.Size(217, 34);
            this.saveLabelsToToolStripMenuItem.Text = "Save labels to";
            this.saveLabelsToToolStripMenuItem.Click += new System.EventHandler(this.saveLabelsToToolStripMenuItem_Click);
            // 
            // autosaveToolStripMenuItem
            // 
            this.autosaveToolStripMenuItem.Name = "autosaveToolStripMenuItem";
            this.autosaveToolStripMenuItem.Size = new System.Drawing.Size(217, 34);
            this.autosaveToolStripMenuItem.Text = "Autosave";
            this.autosaveToolStripMenuItem.Click += new System.EventHandler(this.autosaveToolStripMenuItem_Click);
            // 
            // cursorSettingsToolStripMenuItem
            // 
            this.cursorSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawCrosshairToolStripMenuItem});
            this.cursorSettingsToolStripMenuItem.Name = "cursorSettingsToolStripMenuItem";
            this.cursorSettingsToolStripMenuItem.Size = new System.Drawing.Size(168, 33);
            this.cursorSettingsToolStripMenuItem.Text = "Cursor settings";
            // 
            // drawCrosshairToolStripMenuItem
            // 
            this.drawCrosshairToolStripMenuItem.Name = "drawCrosshairToolStripMenuItem";
            this.drawCrosshairToolStripMenuItem.Size = new System.Drawing.Size(230, 34);
            this.drawCrosshairToolStripMenuItem.Text = "Draw crosshair";
            this.drawCrosshairToolStripMenuItem.Click += new System.EventHandler(this.drawCrosshairToolStripMenuItem_Click);
            // 
            // imagePanel
            // 
            this.imagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePanel.Location = new System.Drawing.Point(12, 85);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(1050, 526);
            this.imagePanel.TabIndex = 5;
            this.imagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.imagePanel_Paint);
            // 
            // listBoxClass
            // 
            this.listBoxClass.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxClass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxClass.FormattingEnabled = true;
            this.listBoxClass.ItemHeight = 29;
            this.listBoxClass.Items.AddRange(new object[] {
            "class 1",
            "class 2",
            "class 3",
            "class 4"});
            this.listBoxClass.Location = new System.Drawing.Point(1072, 85);
            this.listBoxClass.Name = "listBoxClass";
            this.listBoxClass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxClass.Size = new System.Drawing.Size(180, 526);
            this.listBoxClass.TabIndex = 7;
            // 
            // labelImageCount
            // 
            this.labelImageCount.AutoSize = true;
            this.labelImageCount.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelImageCount.Location = new System.Drawing.Point(501, 38);
            this.labelImageCount.Name = "labelImageCount";
            this.labelImageCount.Size = new System.Drawing.Size(130, 29);
            this.labelImageCount.TabIndex = 8;
            this.labelImageCount.Text = "Image 0 of 0";
            // 
            // textBoxGoto
            // 
            this.textBoxGoto.Location = new System.Drawing.Point(1072, 46);
            this.textBoxGoto.MaxLength = 7;
            this.textBoxGoto.Name = "textBoxGoto";
            this.textBoxGoto.ShortcutsEnabled = false;
            this.textBoxGoto.Size = new System.Drawing.Size(180, 23);
            this.textBoxGoto.TabIndex = 9;
            this.textBoxGoto.Text = "Go to * image";
            this.textBoxGoto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxGoto_KeyDown);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.textBoxGoto);
            this.Controls.Add(this.labelImageCount);
            this.Controls.Add(this.listBoxClass);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Jeeja Image Labeller";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonPrev;
        private Button buttonNext;
        private Panel imagePanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem loadImagesFromToolStripMenuItem;
        private ToolStripMenuItem loadClassesFromToolStripMenuItem;
        private ListBox listBoxClass;
        private Label labelImageCount;
        private ToolStripMenuItem saveSettingsToolStripMenuItem;
        private ToolStripMenuItem saveLabelsToToolStripMenuItem;
        private ToolStripMenuItem autosaveToolStripMenuItem;
        private ToolStripMenuItem cursorSettingsToolStripMenuItem;
        private ToolStripMenuItem drawCrosshairToolStripMenuItem;
        private TextBox textBoxGoto;
    }
}
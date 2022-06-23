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
            this.listBoxClass = new System.Windows.Forms.ListBox();
            this.labelImageCount = new System.Windows.Forms.Label();
            this.textBoxGoto = new System.Windows.Forms.TextBox();
            this.buttonGoto = new System.Windows.Forms.Button();
            this.imagePanel = new System.Windows.Forms.PictureBox();
            this.labellingModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSegmentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datasetTTVSplitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrev.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.saveSettingsToolStripMenuItem,
            this.cursorSettingsToolStripMenuItem,
            this.labellingModeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 33);
            this.menuStrip1.TabIndex = 6;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImagesFromToolStripMenuItem,
            this.loadClassesFromToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(182, 29);
            this.settingsToolStripMenuItem.Text = "Loading settings";
            // 
            // loadImagesFromToolStripMenuItem
            // 
            this.loadImagesFromToolStripMenuItem.Name = "loadImagesFromToolStripMenuItem";
            this.loadImagesFromToolStripMenuItem.Size = new System.Drawing.Size(259, 30);
            this.loadImagesFromToolStripMenuItem.Text = "Load images from";
            this.loadImagesFromToolStripMenuItem.Click += new System.EventHandler(this.loadImagesFromToolStripMenuItem_Click);
            // 
            // loadClassesFromToolStripMenuItem
            // 
            this.loadClassesFromToolStripMenuItem.Name = "loadClassesFromToolStripMenuItem";
            this.loadClassesFromToolStripMenuItem.Size = new System.Drawing.Size(259, 30);
            this.loadClassesFromToolStripMenuItem.Text = "Load classes from";
            this.loadClassesFromToolStripMenuItem.Click += new System.EventHandler(this.loadClassesFromToolStripMenuItem_Click);
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveLabelsToToolStripMenuItem,
            this.autosaveToolStripMenuItem});
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(171, 29);
            this.saveSettingsToolStripMenuItem.Text = "Saving settings";
            // 
            // saveLabelsToToolStripMenuItem
            // 
            this.saveLabelsToToolStripMenuItem.Name = "saveLabelsToToolStripMenuItem";
            this.saveLabelsToToolStripMenuItem.Size = new System.Drawing.Size(220, 30);
            this.saveLabelsToToolStripMenuItem.Text = "Save labels to";
            this.saveLabelsToToolStripMenuItem.Click += new System.EventHandler(this.saveLabelsToToolStripMenuItem_Click);
            // 
            // autosaveToolStripMenuItem
            // 
            this.autosaveToolStripMenuItem.Name = "autosaveToolStripMenuItem";
            this.autosaveToolStripMenuItem.Size = new System.Drawing.Size(220, 30);
            this.autosaveToolStripMenuItem.Text = "Autosave";
            this.autosaveToolStripMenuItem.Click += new System.EventHandler(this.autosaveToolStripMenuItem_Click);
            // 
            // cursorSettingsToolStripMenuItem
            // 
            this.cursorSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawCrosshairToolStripMenuItem});
            this.cursorSettingsToolStripMenuItem.Name = "cursorSettingsToolStripMenuItem";
            this.cursorSettingsToolStripMenuItem.Size = new System.Drawing.Size(169, 29);
            this.cursorSettingsToolStripMenuItem.Text = "Cursor settings";
            // 
            // drawCrosshairToolStripMenuItem
            // 
            this.drawCrosshairToolStripMenuItem.Name = "drawCrosshairToolStripMenuItem";
            this.drawCrosshairToolStripMenuItem.Size = new System.Drawing.Size(227, 30);
            this.drawCrosshairToolStripMenuItem.Text = "Draw crosshair";
            this.drawCrosshairToolStripMenuItem.Click += new System.EventHandler(this.drawCrosshairToolStripMenuItem_Click);
            // 
            // listBoxClass
            // 
            this.listBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxClass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxClass.FormattingEnabled = true;
            this.listBoxClass.ItemHeight = 25;
            this.listBoxClass.Items.AddRange(new object[] {
            "class 1",
            "class 2",
            "class 3",
            "class 4"});
            this.listBoxClass.Location = new System.Drawing.Point(1072, 85);
            this.listBoxClass.Name = "listBoxClass";
            this.listBoxClass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxClass.Size = new System.Drawing.Size(180, 504);
            this.listBoxClass.TabIndex = 7;
            // 
            // labelImageCount
            // 
            this.labelImageCount.AutoSize = true;
            this.labelImageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelImageCount.Location = new System.Drawing.Point(501, 38);
            this.labelImageCount.Name = "labelImageCount";
            this.labelImageCount.Size = new System.Drawing.Size(130, 25);
            this.labelImageCount.TabIndex = 8;
            this.labelImageCount.Text = "Image 0 of 0";
            // 
            // textBoxGoto
            // 
            this.textBoxGoto.Location = new System.Drawing.Point(1072, 46);
            this.textBoxGoto.MaxLength = 7;
            this.textBoxGoto.Name = "textBoxGoto";
            this.textBoxGoto.ShortcutsEnabled = false;
            this.textBoxGoto.Size = new System.Drawing.Size(87, 23);
            this.textBoxGoto.TabIndex = 9;
            // 
            // buttonGoto
            // 
            this.buttonGoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGoto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonGoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGoto.Location = new System.Drawing.Point(1165, 46);
            this.buttonGoto.Name = "buttonGoto";
            this.buttonGoto.Size = new System.Drawing.Size(87, 23);
            this.buttonGoto.TabIndex = 10;
            this.buttonGoto.Text = "Go";
            this.buttonGoto.UseVisualStyleBackColor = true;
            this.buttonGoto.Click += new System.EventHandler(this.buttonGoto_Click);
            // 
            // imagePanel
            // 
            this.imagePanel.Location = new System.Drawing.Point(12, 85);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(1054, 526);
            this.imagePanel.TabIndex = 11;
            this.imagePanel.TabStop = false;
            this.imagePanel.Click += new System.EventHandler(this.imagePanel_Click);
            this.imagePanel.MouseLeave += new System.EventHandler(this.imagePanel_MouseLeave);
            this.imagePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imagePanel_MouseMove);
            // 
            // labellingModeToolStripMenuItem
            // 
            this.labellingModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageSegmentationToolStripMenuItem,
            this.datasetTTVSplitToolStripMenuItem});
            this.labellingModeToolStripMenuItem.Name = "labellingModeToolStripMenuItem";
            this.labellingModeToolStripMenuItem.Size = new System.Drawing.Size(170, 29);
            this.labellingModeToolStripMenuItem.Text = "Labelling mode";
            // 
            // imageSegmentationToolStripMenuItem
            // 
            this.imageSegmentationToolStripMenuItem.Checked = true;
            this.imageSegmentationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.imageSegmentationToolStripMenuItem.Name = "imageSegmentationToolStripMenuItem";
            this.imageSegmentationToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.imageSegmentationToolStripMenuItem.Text = "Image Segmentation";
            // 
            // datasetTTVSplitToolStripMenuItem
            // 
            this.datasetTTVSplitToolStripMenuItem.Name = "datasetTTVSplitToolStripMenuItem";
            this.datasetTTVSplitToolStripMenuItem.Size = new System.Drawing.Size(280, 30);
            this.datasetTTVSplitToolStripMenuItem.Text = "Dataset TTV split";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.buttonGoto);
            this.Controls.Add(this.textBoxGoto);
            this.Controls.Add(this.labelImageCount);
            this.Controls.Add(this.listBoxClass);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Jeeja Image Labeller";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainWindow_PreviewKeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonPrev;
        private Button buttonNext;
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
        private Button buttonGoto;
        private PictureBox imagePanel;
        private ToolStripMenuItem labellingModeToolStripMenuItem;
        private ToolStripMenuItem imageSegmentationToolStripMenuItem;
        private ToolStripMenuItem datasetTTVSplitToolStripMenuItem;
    }
}
namespace src
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelNameApp = new System.Windows.Forms.Label();
            this.logoApp = new System.Windows.Forms.PictureBox();
            this.testing = new System.Windows.Forms.ListBox();
            this.radioButtonBfs = new System.Windows.Forms.RadioButton();
            this.radioButtonDfs = new System.Windows.Forms.RadioButton();
            this.gViewer1 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelInputFile = new System.Windows.Forms.Label();
            this.textBoxInputFileName = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panelChooseFile = new System.Windows.Forms.Panel();
            this.labelFolderPath = new System.Windows.Forms.Label();
            this.labelChooseFolder = new System.Windows.Forms.Label();
            this.buttonChooseFolder = new System.Windows.Forms.Button();
            this.panelMain = new src.GradientPanel();
            this.checkBoxFindAll = new System.Windows.Forms.CheckBox();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.labelPathnoFile = new System.Windows.Forms.Label();
            this.listLinkPath = new System.Windows.Forms.ListBox();
            this.labelRuntime = new System.Windows.Forms.Label();
            this.labellinkPath = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoApp)).BeginInit();
            this.panelChooseFile.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelHeader.Controls.Add(this.labelNameApp);
            this.panelHeader.Controls.Add(this.logoApp);
            this.panelHeader.Location = new System.Drawing.Point(-1, 1);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1400, 70);
            this.panelHeader.TabIndex = 11;
            // 
            // labelNameApp
            // 
            this.labelNameApp.AutoSize = true;
            this.labelNameApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNameApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelNameApp.Location = new System.Drawing.Point(105, 16);
            this.labelNameApp.Name = "labelNameApp";
            this.labelNameApp.Size = new System.Drawing.Size(245, 42);
            this.labelNameApp.TabIndex = 13;
            this.labelNameApp.Text = "MesinPencari";
            // 
            // logoApp
            // 
            this.logoApp.BackColor = System.Drawing.Color.Transparent;
            this.logoApp.Image = ((System.Drawing.Image)(resources.GetObject("logoApp.Image")));
            this.logoApp.Location = new System.Drawing.Point(32, 5);
            this.logoApp.Name = "logoApp";
            this.logoApp.Size = new System.Drawing.Size(56, 56);
            this.logoApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoApp.TabIndex = 0;
            this.logoApp.TabStop = false;
            // 
            // testing
            // 
            this.testing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.testing.Cursor = System.Windows.Forms.Cursors.No;
            this.testing.FormattingEnabled = true;
            this.testing.ItemHeight = 18;
            this.testing.Location = new System.Drawing.Point(29, 427);
            this.testing.Name = "testing";
            this.testing.Size = new System.Drawing.Size(572, 90);
            this.testing.TabIndex = 1;
            this.testing.Visible = false;
            // 
            // radioButtonBfs
            // 
            this.radioButtonBfs.AutoSize = true;
            this.radioButtonBfs.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonBfs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonBfs.ForeColor = System.Drawing.Color.White;
            this.radioButtonBfs.Location = new System.Drawing.Point(29, 316);
            this.radioButtonBfs.Name = "radioButtonBfs";
            this.radioButtonBfs.Size = new System.Drawing.Size(72, 29);
            this.radioButtonBfs.TabIndex = 3;
            this.radioButtonBfs.TabStop = true;
            this.radioButtonBfs.Text = "BFS";
            this.radioButtonBfs.UseVisualStyleBackColor = false;
            // 
            // radioButtonDfs
            // 
            this.radioButtonDfs.AutoSize = true;
            this.radioButtonDfs.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonDfs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonDfs.ForeColor = System.Drawing.Color.White;
            this.radioButtonDfs.Location = new System.Drawing.Point(119, 316);
            this.radioButtonDfs.Name = "radioButtonDfs";
            this.radioButtonDfs.Size = new System.Drawing.Size(73, 29);
            this.radioButtonDfs.TabIndex = 4;
            this.radioButtonDfs.TabStop = true;
            this.radioButtonDfs.Text = "DFS";
            this.radioButtonDfs.UseVisualStyleBackColor = false;
            // 
            // gViewer1
            // 
            this.gViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gViewer1.ArrowheadLength = 10D;
            this.gViewer1.AsyncLayout = false;
            this.gViewer1.AutoScroll = true;
            this.gViewer1.BackColor = System.Drawing.Color.White;
            this.gViewer1.BackwardEnabled = false;
            this.gViewer1.BuildHitTree = true;
            this.gViewer1.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewer1.EdgeInsertButtonVisible = true;
            this.gViewer1.FileName = "";
            this.gViewer1.ForwardEnabled = false;
            this.gViewer1.Graph = null;
            this.gViewer1.InsertingEdge = false;
            this.gViewer1.LayoutAlgorithmSettingsButtonVisible = true;
            this.gViewer1.LayoutEditingEnabled = true;
            this.gViewer1.Location = new System.Drawing.Point(629, 93);
            this.gViewer1.LooseOffsetForRouting = 0.25D;
            this.gViewer1.MouseHitDistance = 0.05D;
            this.gViewer1.Name = "gViewer1";
            this.gViewer1.NavigationVisible = true;
            this.gViewer1.NeedToCalculateLayout = true;
            this.gViewer1.OffsetForRelaxingInRouting = 0.6D;
            this.gViewer1.PaddingForEdgeRouting = 8D;
            this.gViewer1.PanButtonPressed = false;
            this.gViewer1.SaveAsImageEnabled = true;
            this.gViewer1.SaveAsMsaglEnabled = true;
            this.gViewer1.SaveButtonVisible = true;
            this.gViewer1.SaveGraphButtonVisible = true;
            this.gViewer1.SaveInVectorFormatEnabled = true;
            this.gViewer1.Size = new System.Drawing.Size(619, 396);
            this.gViewer1.TabIndex = 5;
            this.gViewer1.TightOffsetForRouting = 0.125D;
            this.gViewer1.ToolBarIsVisible = true;
            this.gViewer1.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("gViewer1.Transform")));
            this.gViewer1.UndoRedoButtonsVisible = true;
            this.gViewer1.WindowZoomButtonPressed = false;
            this.gViewer1.ZoomF = 1D;
            this.gViewer1.ZoomWindowThreshold = 0.05D;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.BackColor = System.Drawing.Color.Transparent;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelInput.Location = new System.Drawing.Point(28, 13);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(112, 46);
            this.labelInput.TabIndex = 6;
            this.labelInput.Text = "Input";
            // 
            // labelInputFile
            // 
            this.labelInputFile.AutoSize = true;
            this.labelInputFile.BackColor = System.Drawing.Color.Transparent;
            this.labelInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInputFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelInputFile.Location = new System.Drawing.Point(29, 210);
            this.labelInputFile.Name = "labelInputFile";
            this.labelInputFile.Size = new System.Drawing.Size(183, 29);
            this.labelInputFile.TabIndex = 8;
            this.labelInputFile.Text = "Input File Name";
            // 
            // textBoxInputFileName
            // 
            this.textBoxInputFileName.Location = new System.Drawing.Point(30, 245);
            this.textBoxInputFileName.Name = "textBoxInputFileName";
            this.textBoxInputFileName.Size = new System.Drawing.Size(222, 24);
            this.textBoxInputFileName.TabIndex = 9;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonSearch.Location = new System.Drawing.Point(28, 359);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(164, 43);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panelChooseFile
            // 
            this.panelChooseFile.BackColor = System.Drawing.Color.Transparent;
            this.panelChooseFile.Controls.Add(this.labelFolderPath);
            this.panelChooseFile.Controls.Add(this.labelChooseFolder);
            this.panelChooseFile.Controls.Add(this.buttonChooseFolder);
            this.panelChooseFile.Location = new System.Drawing.Point(28, 93);
            this.panelChooseFile.Name = "panelChooseFile";
            this.panelChooseFile.Size = new System.Drawing.Size(576, 99);
            this.panelChooseFile.TabIndex = 12;
            // 
            // labelFolderPath
            // 
            this.labelFolderPath.AllowDrop = true;
            this.labelFolderPath.AutoSize = true;
            this.labelFolderPath.BackColor = System.Drawing.Color.Transparent;
            this.labelFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFolderPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelFolderPath.Location = new System.Drawing.Point(174, 57);
            this.labelFolderPath.MaximumSize = new System.Drawing.Size(450, 0);
            this.labelFolderPath.MinimumSize = new System.Drawing.Size(338, 0);
            this.labelFolderPath.Name = "labelFolderPath";
            this.labelFolderPath.Size = new System.Drawing.Size(338, 18);
            this.labelFolderPath.TabIndex = 9;
            this.labelFolderPath.Text = "No File Choosen..";
            // 
            // labelChooseFolder
            // 
            this.labelChooseFolder.AutoSize = true;
            this.labelChooseFolder.BackColor = System.Drawing.Color.Transparent;
            this.labelChooseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelChooseFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelChooseFolder.Location = new System.Drawing.Point(1, 9);
            this.labelChooseFolder.Name = "labelChooseFolder";
            this.labelChooseFolder.Size = new System.Drawing.Size(238, 29);
            this.labelChooseFolder.TabIndex = 7;
            this.labelChooseFolder.Text = "Choose File directori";
            // 
            // buttonChooseFolder
            // 
            this.buttonChooseFolder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonChooseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChooseFolder.Location = new System.Drawing.Point(4, 48);
            this.buttonChooseFolder.Name = "buttonChooseFolder";
            this.buttonChooseFolder.Size = new System.Drawing.Size(163, 47);
            this.buttonChooseFolder.TabIndex = 0;
            this.buttonChooseFolder.Text = "Change Folder";
            this.buttonChooseFolder.UseVisualStyleBackColor = false;
            this.buttonChooseFolder.Click += new System.EventHandler(this.buttonChooseFolder_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Angle = 0F;
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(76)))));
            this.panelMain.Controls.Add(this.checkBoxFindAll);
            this.panelMain.Controls.Add(this.panelOutput);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.gViewer1);
            this.panelMain.Controls.Add(this.buttonSearch);
            this.panelMain.Controls.Add(this.testing);
            this.panelMain.Controls.Add(this.panelChooseFile);
            this.panelMain.Controls.Add(this.textBoxInputFileName);
            this.panelMain.Controls.Add(this.radioButtonDfs);
            this.panelMain.Controls.Add(this.labelInput);
            this.panelMain.Controls.Add(this.radioButtonBfs);
            this.panelMain.Controls.Add(this.labelInputFile);
            this.panelMain.Location = new System.Drawing.Point(46, 112);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1298, 680);
            this.panelMain.TabIndex = 15;
            this.panelMain.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(72)))));
            // 
            // checkBoxFindAll
            // 
            this.checkBoxFindAll.AutoSize = true;
            this.checkBoxFindAll.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxFindAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxFindAll.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxFindAll.Location = new System.Drawing.Point(29, 278);
            this.checkBoxFindAll.Name = "checkBoxFindAll";
            this.checkBoxFindAll.Size = new System.Drawing.Size(178, 26);
            this.checkBoxFindAll.TabIndex = 16;
            this.checkBoxFindAll.Text = "Find all occurence";
            this.checkBoxFindAll.UseVisualStyleBackColor = false;
            // 
            // panelOutput
            // 
            this.panelOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOutput.BackColor = System.Drawing.Color.Transparent;
            this.panelOutput.Controls.Add(this.labelPathnoFile);
            this.panelOutput.Controls.Add(this.listLinkPath);
            this.panelOutput.Controls.Add(this.labelRuntime);
            this.panelOutput.Controls.Add(this.labellinkPath);
            this.panelOutput.Controls.Add(this.labelTime);
            this.panelOutput.Location = new System.Drawing.Point(629, 495);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(619, 182);
            this.panelOutput.TabIndex = 15;
            this.panelOutput.Visible = false;
            // 
            // labelPathnoFile
            // 
            this.labelPathnoFile.AutoSize = true;
            this.labelPathnoFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPathnoFile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPathnoFile.Location = new System.Drawing.Point(4, 34);
            this.labelPathnoFile.Name = "labelPathnoFile";
            this.labelPathnoFile.Size = new System.Drawing.Size(91, 22);
            this.labelPathnoFile.TabIndex = 18;
            this.labelPathnoFile.Text = "Path File :";
            // 
            // listLinkPath
            // 
            this.listLinkPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.listLinkPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listLinkPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listLinkPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.listLinkPath.ForeColor = System.Drawing.Color.Aquamarine;
            this.listLinkPath.FormattingEnabled = true;
            this.listLinkPath.ItemHeight = 18;
            this.listLinkPath.Location = new System.Drawing.Point(11, 37);
            this.listLinkPath.MaximumSize = new System.Drawing.Size(593, 90);
            this.listLinkPath.MinimumSize = new System.Drawing.Size(200, 30);
            this.listLinkPath.Name = "listLinkPath";
            this.listLinkPath.Size = new System.Drawing.Size(593, 54);
            this.listLinkPath.TabIndex = 17;
            this.listLinkPath.SelectedIndexChanged += new System.EventHandler(this.listLinkPath_SelectedIndexChanged);
            // 
            // labelRuntime
            // 
            this.labelRuntime.AutoSize = true;
            this.labelRuntime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRuntime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRuntime.Location = new System.Drawing.Point(133, 138);
            this.labelRuntime.Name = "labelRuntime";
            this.labelRuntime.Size = new System.Drawing.Size(23, 25);
            this.labelRuntime.TabIndex = 3;
            this.labelRuntime.Text = "0";
            // 
            // labellinkPath
            // 
            this.labellinkPath.AutoSize = true;
            this.labellinkPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labellinkPath.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labellinkPath.Location = new System.Drawing.Point(3, 9);
            this.labellinkPath.Name = "labellinkPath";
            this.labellinkPath.Size = new System.Drawing.Size(99, 25);
            this.labellinkPath.TabIndex = 2;
            this.labellinkPath.Text = "Path File :";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTime.Location = new System.Drawing.Point(3, 138);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(124, 25);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "Time Spent :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.panel2.Location = new System.Drawing.Point(34, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 4);
            this.panel2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1390, 834);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MesinPencari";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoApp)).EndInit();
            this.panelChooseFile.ResumeLayout(false);
            this.panelChooseFile.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelOutput.ResumeLayout(false);
            this.panelOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        public override bool Equals(object obj)
        {
            return obj is Form1 form &&
                   EqualityComparer<Button>.Default.Equals(buttonChooseFolder, form.buttonChooseFolder);
        }

        #endregion
        private Panel panelHeader;
        private Label labelNameApp;
        private PictureBox logoApp;
        private ListBox testing;
        private RadioButton radioButtonBfs;
        private RadioButton radioButtonDfs;
        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer1;
        private Label labelInput;
        private Label labelInputFile;
        private TextBox textBoxInputFileName;
        private Button buttonSearch;
        private Panel panelChooseFile;
        private Label labelChooseFolder;
        private Button buttonChooseFolder;
        private GradientPanel panelMain;
        private Label labelFolderPath;
        private Panel panel2;
        private Panel panelOutput;
        private Label labellinkPath;
        private Label labelTime;
        private Label labelRuntime;
        private CheckBox checkBoxFindAll;
        private ListBox listLinkPath;
        private Label labelPathnoFile;
    }
}
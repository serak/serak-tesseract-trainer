namespace SerakTesseractTrainer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPorjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tesseractBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oCRModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtfreqwods = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btncreateNew = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtDictionary = new System.Windows.Forms.TextBox();
            this.btnSaveDictionary = new System.Windows.Forms.Button();
            this.btnCreateNewDiction = new System.Windows.Forms.Button();
            this.btnbrouseDictionary = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.txtunicharambig = new System.Windows.Forms.TextBox();
            this.btnsaveunichar = new System.Windows.Forms.Button();
            this.btncreateunichar = new System.Windows.Forms.Button();
            this.btnbrwseunichar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.progPercent = new System.Windows.Forms.ProgressBar();
            this.lblPercent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRate = new System.Windows.Forms.Button();
            this.btnBrowseToComp = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtRecognizedWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtisolang = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openPorjectToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.newProjectToolStripMenuItem.Text = "New project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // openPorjectToolStripMenuItem
            // 
            this.openPorjectToolStripMenuItem.Name = "openPorjectToolStripMenuItem";
            this.openPorjectToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.openPorjectToolStripMenuItem.Text = "Open Project";
            this.openPorjectToolStripMenuItem.Click += new System.EventHandler(this.openPorjectToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tesseractBinaryToolStripMenuItem,
            this.oCRModeToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.helpToolStripMenuItem.Text = "Option";
            // 
            // tesseractBinaryToolStripMenuItem
            // 
            this.tesseractBinaryToolStripMenuItem.Name = "tesseractBinaryToolStripMenuItem";
            this.tesseractBinaryToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.tesseractBinaryToolStripMenuItem.Text = "TesseractOption";
            this.tesseractBinaryToolStripMenuItem.Click += new System.EventHandler(this.tesseractOptionclick);
            // 
            // oCRModeToolStripMenuItem
            // 
            this.oCRModeToolStripMenuItem.Name = "oCRModeToolStripMenuItem";
            this.oCRModeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.oCRModeToolStripMenuItem.Text = "OCR Mode";
            this.oCRModeToolStripMenuItem.Click += new System.EventHandler(this.oCRModeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem2});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "Help";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.HelpMenuStripClick);
            // 
            // helpToolStripMenuItem2
            // 
            this.helpToolStripMenuItem2.Name = "helpToolStripMenuItem2";
            this.helpToolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem2.Text = "About";
            this.helpToolStripMenuItem2.Click += new System.EventHandler(this.AboutMenuStripClicked);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(785, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "New Project";
            this.toolStripButton1.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Open Project";
            this.toolStripButton2.Click += new System.EventHandler(this.openPorjectToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "OCR Mode";
            this.toolStripButton3.Click += new System.EventHandler(this.oCRModeToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(0, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 474);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Train Tesseract";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Maroon;
            this.button7.Location = new System.Drawing.Point(19, 390);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(257, 34);
            this.button7.TabIndex = 2;
            this.button7.Text = "Remove File";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(302, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(467, 402);
            this.listBox1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(19, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(257, 34);
            this.button4.TabIndex = 0;
            this.button4.Text = "4. Combine TessData";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.combineTessdata);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(19, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(257, 34);
            this.button3.TabIndex = 0;
            this.button3.Text = "3. Train Tesseract";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(19, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "2. Define Font_Properties";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.defineFontProperties);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "1. Add Train Image";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddImagesToProject);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modify Tessdata";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(0, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(781, 449);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtfreqwods);
            this.tabPage4.Controls.Add(this.btnSave);
            this.tabPage4.Controls.Add(this.btncreateNew);
            this.tabPage4.Controls.Add(this.btnBrowse);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(773, 423);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Frequent Words";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtfreqwods
            // 
            this.txtfreqwods.Enabled = false;
            this.txtfreqwods.Location = new System.Drawing.Point(6, 34);
            this.txtfreqwods.MaxLength = 10000000;
            this.txtfreqwods.Multiline = true;
            this.txtfreqwods.Name = "txtfreqwods";
            this.txtfreqwods.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtfreqwods.Size = new System.Drawing.Size(342, 381);
            this.txtfreqwods.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(366, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btncreateNew
            // 
            this.btncreateNew.Location = new System.Drawing.Point(103, 6);
            this.btncreateNew.Name = "btncreateNew";
            this.btncreateNew.Size = new System.Drawing.Size(245, 23);
            this.btncreateNew.TabIndex = 1;
            this.btncreateNew.Text = "Create New";
            this.btncreateNew.UseVisualStyleBackColor = true;
            this.btncreateNew.Click += new System.EventHandler(this.btncreateNew_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(6, 6);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(78, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtDictionary);
            this.tabPage5.Controls.Add(this.btnSaveDictionary);
            this.tabPage5.Controls.Add(this.btnCreateNewDiction);
            this.tabPage5.Controls.Add(this.btnbrouseDictionary);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(773, 423);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Dictionary Words";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtDictionary
            // 
            this.txtDictionary.Enabled = false;
            this.txtDictionary.Location = new System.Drawing.Point(4, 34);
            this.txtDictionary.MaxLength = 10000000;
            this.txtDictionary.Multiline = true;
            this.txtDictionary.Name = "txtDictionary";
            this.txtDictionary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDictionary.Size = new System.Drawing.Size(342, 381);
            this.txtDictionary.TabIndex = 8;
            // 
            // btnSaveDictionary
            // 
            this.btnSaveDictionary.Location = new System.Drawing.Point(364, 32);
            this.btnSaveDictionary.Name = "btnSaveDictionary";
            this.btnSaveDictionary.Size = new System.Drawing.Size(137, 23);
            this.btnSaveDictionary.TabIndex = 7;
            this.btnSaveDictionary.Text = "Save";
            this.btnSaveDictionary.UseVisualStyleBackColor = true;
            this.btnSaveDictionary.Click += new System.EventHandler(this.btnSaveDictionary_Click);
            // 
            // btnCreateNewDiction
            // 
            this.btnCreateNewDiction.Location = new System.Drawing.Point(101, 6);
            this.btnCreateNewDiction.Name = "btnCreateNewDiction";
            this.btnCreateNewDiction.Size = new System.Drawing.Size(245, 23);
            this.btnCreateNewDiction.TabIndex = 5;
            this.btnCreateNewDiction.Text = "Create New";
            this.btnCreateNewDiction.UseVisualStyleBackColor = true;
            this.btnCreateNewDiction.Click += new System.EventHandler(this.btnCreateNewDiction_Click);
            // 
            // btnbrouseDictionary
            // 
            this.btnbrouseDictionary.Location = new System.Drawing.Point(4, 6);
            this.btnbrouseDictionary.Name = "btnbrouseDictionary";
            this.btnbrouseDictionary.Size = new System.Drawing.Size(78, 23);
            this.btnbrouseDictionary.TabIndex = 6;
            this.btnbrouseDictionary.Text = "Browse";
            this.btnbrouseDictionary.UseVisualStyleBackColor = true;
            this.btnbrouseDictionary.Click += new System.EventHandler(this.browseDictionary);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.txtunicharambig);
            this.tabPage6.Controls.Add(this.btnsaveunichar);
            this.tabPage6.Controls.Add(this.btncreateunichar);
            this.tabPage6.Controls.Add(this.btnbrwseunichar);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(773, 423);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Unichar Umbiguity";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // txtunicharambig
            // 
            this.txtunicharambig.Enabled = false;
            this.txtunicharambig.Location = new System.Drawing.Point(6, 34);
            this.txtunicharambig.MaxLength = 10000000;
            this.txtunicharambig.Multiline = true;
            this.txtunicharambig.Name = "txtunicharambig";
            this.txtunicharambig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtunicharambig.Size = new System.Drawing.Size(342, 381);
            this.txtunicharambig.TabIndex = 12;
            // 
            // btnsaveunichar
            // 
            this.btnsaveunichar.Location = new System.Drawing.Point(366, 32);
            this.btnsaveunichar.Name = "btnsaveunichar";
            this.btnsaveunichar.Size = new System.Drawing.Size(137, 23);
            this.btnsaveunichar.TabIndex = 11;
            this.btnsaveunichar.Text = "Save";
            this.btnsaveunichar.UseVisualStyleBackColor = true;
            this.btnsaveunichar.Click += new System.EventHandler(this.btnsaveunichar_Click);
            // 
            // btncreateunichar
            // 
            this.btncreateunichar.Location = new System.Drawing.Point(103, 6);
            this.btncreateunichar.Name = "btncreateunichar";
            this.btncreateunichar.Size = new System.Drawing.Size(245, 23);
            this.btncreateunichar.TabIndex = 9;
            this.btncreateunichar.Text = "Create New";
            this.btncreateunichar.UseVisualStyleBackColor = true;
            this.btncreateunichar.Click += new System.EventHandler(this.btncreateunichar_Click);
            // 
            // btnbrwseunichar
            // 
            this.btnbrwseunichar.Location = new System.Drawing.Point(6, 6);
            this.btnbrwseunichar.Name = "btnbrwseunichar";
            this.btnbrwseunichar.Size = new System.Drawing.Size(78, 23);
            this.btnbrwseunichar.TabIndex = 10;
            this.btnbrwseunichar.Text = "Browse";
            this.btnbrwseunichar.UseVisualStyleBackColor = true;
            this.btnbrwseunichar.Click += new System.EventHandler(this.btnbrwseunichar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.progPercent);
            this.tabPage3.Controls.Add(this.lblPercent);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btnRate);
            this.tabPage3.Controls.Add(this.btnBrowseToComp);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.txtRecognizedWord);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txtLocation);
            this.tabPage3.Controls.Add(this.txtisolang);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(777, 448);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Test OCR";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // progPercent
            // 
            this.progPercent.Enabled = false;
            this.progPercent.Location = new System.Drawing.Point(464, 408);
            this.progPercent.Name = "progPercent";
            this.progPercent.Size = new System.Drawing.Size(274, 23);
            this.progPercent.TabIndex = 6;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Enabled = false;
            this.lblPercent.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.Location = new System.Drawing.Point(399, 408);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(31, 23);
            this.lblPercent.TabIndex = 5;
            this.lblPercent.Text = "0%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Browse Text to Compare";
            // 
            // btnRate
            // 
            this.btnRate.Enabled = false;
            this.btnRate.Location = new System.Drawing.Point(281, 408);
            this.btnRate.Name = "btnRate";
            this.btnRate.Size = new System.Drawing.Size(75, 23);
            this.btnRate.TabIndex = 4;
            this.btnRate.Text = "Rate";
            this.btnRate.UseVisualStyleBackColor = true;
            this.btnRate.Click += new System.EventHandler(this.btnRate_Click);
            // 
            // btnBrowseToComp
            // 
            this.btnBrowseToComp.Enabled = false;
            this.btnBrowseToComp.Location = new System.Drawing.Point(172, 408);
            this.btnBrowseToComp.Name = "btnBrowseToComp";
            this.btnBrowseToComp.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseToComp.TabIndex = 4;
            this.btnBrowseToComp.Text = "Browse";
            this.btnBrowseToComp.UseVisualStyleBackColor = true;
            this.btnBrowseToComp.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(582, 8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Browse";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.browseforRecognition);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(663, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Recognize";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.recognize);
            // 
            // txtRecognizedWord
            // 
            this.txtRecognizedWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecognizedWord.Location = new System.Drawing.Point(11, 36);
            this.txtRecognizedWord.Multiline = true;
            this.txtRecognizedWord.Name = "txtRecognizedWord";
            this.txtRecognizedWord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecognizedWord.Size = new System.Drawing.Size(727, 357);
            this.txtRecognizedWord.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Image Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISO-Lang name";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(300, 10);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(246, 20);
            this.txtLocation.TabIndex = 0;
            // 
            // txtisolang
            // 
            this.txtisolang.Location = new System.Drawing.Point(95, 10);
            this.txtisolang.Name = "txtisolang";
            this.txtisolang.Size = new System.Drawing.Size(100, 20);
            this.txtisolang.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 526);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(801, 564);
            this.MinimumSize = new System.Drawing.Size(801, 564);
            this.Name = "MainForm";
            this.Text = "Serak Trainer For Tesseract 3.0X";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPorjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tesseractBinaryToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btncreateNew;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtfreqwods;
        private System.Windows.Forms.TextBox txtDictionary;
        private System.Windows.Forms.Button btnSaveDictionary;
        private System.Windows.Forms.Button btnCreateNewDiction;
        private System.Windows.Forms.Button btnbrouseDictionary;
        private System.Windows.Forms.TextBox txtunicharambig;
        private System.Windows.Forms.Button btnsaveunichar;
        private System.Windows.Forms.Button btncreateunichar;
        private System.Windows.Forms.Button btnbrwseunichar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtRecognizedWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtisolang;
        private System.Windows.Forms.ToolStripMenuItem oCRModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ProgressBar progPercent;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRate;
        private System.Windows.Forms.Button btnBrowseToComp;
        private System.Windows.Forms.Timer timer1;
    }
}
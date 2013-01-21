namespace SerakTesseractTrainer
{
    partial class Fonts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fonts));
            this.lstFonts = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkFrankfurt = new System.Windows.Forms.CheckBox();
            this.chkserif = new System.Windows.Forms.CheckBox();
            this.chkFixed = new System.Windows.Forms.CheckBox();
            this.chkbold = new System.Windows.Forms.CheckBox();
            this.chkitalic = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFonts
            // 
            this.lstFonts.FormattingEnabled = true;
            this.lstFonts.Location = new System.Drawing.Point(12, 32);
            this.lstFonts.Name = "lstFonts";
            this.lstFonts.Size = new System.Drawing.Size(172, 381);
            this.lstFonts.TabIndex = 0;
            this.lstFonts.SelectedIndexChanged += new System.EventHandler(this.lstFonts_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkFrankfurt);
            this.groupBox1.Controls.Add(this.chkserif);
            this.groupBox1.Controls.Add(this.chkFixed);
            this.groupBox1.Controls.Add(this.chkbold);
            this.groupBox1.Controls.Add(this.chkitalic);
            this.groupBox1.Location = new System.Drawing.Point(199, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font Properties";
            // 
            // chkFrankfurt
            // 
            this.chkFrankfurt.AutoSize = true;
            this.chkFrankfurt.Location = new System.Drawing.Point(6, 130);
            this.chkFrankfurt.Name = "chkFrankfurt";
            this.chkFrankfurt.Size = new System.Drawing.Size(65, 17);
            this.chkFrankfurt.TabIndex = 1;
            this.chkFrankfurt.Text = "Franktur";
            this.chkFrankfurt.UseVisualStyleBackColor = true;
            // 
            // chkserif
            // 
            this.chkserif.AutoSize = true;
            this.chkserif.Location = new System.Drawing.Point(6, 103);
            this.chkserif.Name = "chkserif";
            this.chkserif.Size = new System.Drawing.Size(47, 17);
            this.chkserif.TabIndex = 2;
            this.chkserif.Text = "Serif";
            this.chkserif.UseVisualStyleBackColor = true;
            // 
            // chkFixed
            // 
            this.chkFixed.AutoSize = true;
            this.chkFixed.Location = new System.Drawing.Point(6, 76);
            this.chkFixed.Name = "chkFixed";
            this.chkFixed.Size = new System.Drawing.Size(51, 17);
            this.chkFixed.TabIndex = 3;
            this.chkFixed.Text = "Fixed";
            this.chkFixed.UseVisualStyleBackColor = true;
            // 
            // chkbold
            // 
            this.chkbold.AutoSize = true;
            this.chkbold.Location = new System.Drawing.Point(6, 49);
            this.chkbold.Name = "chkbold";
            this.chkbold.Size = new System.Drawing.Size(47, 17);
            this.chkbold.TabIndex = 4;
            this.chkbold.Text = "Bold";
            this.chkbold.UseVisualStyleBackColor = true;
            // 
            // chkitalic
            // 
            this.chkitalic.AutoSize = true;
            this.chkitalic.Location = new System.Drawing.Point(6, 22);
            this.chkitalic.Name = "chkitalic";
            this.chkitalic.Size = new System.Drawing.Size(48, 17);
            this.chkitalic.TabIndex = 5;
            this.chkitalic.Text = "Italic";
            this.chkitalic.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fonts";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Set and Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.setAndSaveChanges);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear Properties";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.setAllTonone);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(199, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "SaveAll and Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.saveallandclose);
            // 
            // Fonts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 452);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstFonts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Fonts";
            this.Text = "Fonts";
            this.Load += new System.EventHandler(this.Fonts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFonts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkFrankfurt;
        private System.Windows.Forms.CheckBox chkserif;
        private System.Windows.Forms.CheckBox chkFixed;
        private System.Windows.Forms.CheckBox chkbold;
        private System.Windows.Forms.CheckBox chkitalic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
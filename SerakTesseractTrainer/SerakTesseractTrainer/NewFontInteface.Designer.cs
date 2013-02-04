namespace SerakTesseractTrainer
{
    partial class NewFontInteface
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
            this.grdFont = new System.Windows.Forms.DataGridView();
            this.fontname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.italic = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bold = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fixed_font = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.serif = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fraktur = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdFont)).BeginInit();
            this.SuspendLayout();
            // 
            // grdFont
            // 
            this.grdFont.AllowUserToAddRows = false;
            this.grdFont.AllowUserToDeleteRows = false;
            this.grdFont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdFont.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFont.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fontname,
            this.italic,
            this.bold,
            this.fixed_font,
            this.serif,
            this.fraktur});
            this.grdFont.Location = new System.Drawing.Point(12, 50);
            this.grdFont.Name = "grdFont";
            this.grdFont.Size = new System.Drawing.Size(636, 284);
            this.grdFont.TabIndex = 0;
            // 
            // fontname
            // 
            this.fontname.HeaderText = "Font Name";
            this.fontname.Name = "fontname";
            this.fontname.ReadOnly = true;
            // 
            // italic
            // 
            this.italic.FalseValue = "0";
            this.italic.HeaderText = "Italic";
            this.italic.IndeterminateValue = "0";
            this.italic.Name = "italic";
            this.italic.TrueValue = "1";
            // 
            // bold
            // 
            this.bold.FalseValue = "0";
            this.bold.HeaderText = "Bold";
            this.bold.IndeterminateValue = "0";
            this.bold.Name = "bold";
            this.bold.TrueValue = "1";
            // 
            // fixed_font
            // 
            this.fixed_font.FalseValue = "0";
            this.fixed_font.HeaderText = "Fixed";
            this.fixed_font.IndeterminateValue = "0";
            this.fixed_font.Name = "fixed_font";
            this.fixed_font.TrueValue = "1";
            // 
            // serif
            // 
            this.serif.FalseValue = "0";
            this.serif.HeaderText = "Serif";
            this.serif.IndeterminateValue = "0";
            this.serif.Name = "serif";
            this.serif.TrueValue = "1";
            // 
            // fraktur
            // 
            this.fraktur.FalseValue = "0";
            this.fraktur.HeaderText = "Fraktur";
            this.fraktur.IndeterminateValue = "0";
            this.fraktur.Name = "fraktur";
            this.fraktur.TrueValue = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Check Font Properties and Save Changes";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(16, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(492, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save Changes and Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.save_andClose);
            // 
            // NewFontInteface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 408);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdFont);
            this.Name = "NewFontInteface";
            this.Text = "Font Properties";
            this.Load += new System.EventHandler(this.NewFontInteface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdFont)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fontname;
        private System.Windows.Forms.DataGridViewCheckBoxColumn italic;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bold;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fixed_font;
        private System.Windows.Forms.DataGridViewCheckBoxColumn serif;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fraktur;

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerakTesseractTrainer
{
    public partial class Box_Creator : Form
    {
        ShellExcutor sh = new ShellExcutor();
        string projectFolder = TessMain.projectFolder;
        string filename;
        public Box_Creator(string file)
        {
            InitializeComponent();
            this.filename = file.Substring(file.LastIndexOf('\\')+1); ;
        }

        private void createnewbox(object sender, EventArgs e)
        {
            sh.cmdExcute("tesseract.exe", ShellExcutor.tesseractlocation, " " + filename + " " + filename.Substring(0,filename.LastIndexOf('.')) + " batch.nochop makebox", projectFolder);
        }

        private void bootstrapnewchar(object sender, EventArgs e)
        {
            sh.cmdExcute("tesseract.exe", ShellExcutor.tesseractlocation, " " + filename + " " + filename.Substring(0,filename.LastIndexOf('.')) + " -l " + ShellExcutor.isolang + " batch.nochop makebox", projectFolder);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SerakTesseractTrainer
{
    public partial class TesseractConfig : Form
    {
        string[] config = new string[2];
        string filename;
        OpenFileDialog fl;
        public TesseractConfig()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fl = new OpenFileDialog();
            fl.Filter = "Tesseract Excutables(*.exe) |*.exe";
            fl.DefaultExt = "tesseract.exe";
            if (fl.ShowDialog()==DialogResult.OK)
            {
                filename = fl.FileName;
                txttesspath.Text=filename.Substring(0,filename.LastIndexOf('\\'));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            config[0] = txttesspath.Text;
            config[1] = txtlang.Text;
            File.WriteAllLines(Environment.CurrentDirectory.ToString() + '\\' + "Config.cfg", config);
            ShellExcutor.tesseractlocation = txttesspath.Text;
            ShellExcutor.isolang = txtlang.Text;
            this.Close();
        }

        private void TesseractConfig_Load(object sender, EventArgs e)
        {
            if (File.Exists(Environment.CurrentDirectory.ToString() + '\\' + "Config.cfg"))
            {
            outoerror: //place to jump of the error page
                try
                {
                    config = File.ReadAllLines(Environment.CurrentDirectory.ToString() + '\\' + "Config.cfg");
                    txttesspath.Text = config[0];
                    txtlang.Text = config[1];
                }
                catch (Exception)
                {
                    string[] defaultconfig={"C:\\PathoftesseractBinary","iso-639-2_codes"};
                    File.WriteAllLines(Environment.CurrentDirectory.ToString() + '\\' + "Config.cfg",defaultconfig );
                    goto outoerror;
                }
                
               
                
            }       
        }
    }
}

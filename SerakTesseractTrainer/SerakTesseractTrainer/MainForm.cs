using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace SerakTesseractTrainer
{
    public partial class MainForm : Form
    {
        string[] config = new string[2];
        TessMain ts = new TessMain();
        Fonts fontwind;
        public MainForm()
        {
            InitializeComponent();    
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ts.createNewproject();
            this.Text = "Serak Trainer For Tesseract 3.0X -" + TessMain.projectFile;
            if (!(TessMain.projectFolder==null))
            {
                tabControl1.Enabled = true;
            }
        }
        private void AddImagesToProject(object sender, EventArgs e)
        {
            ts.addimages();
            listBox1.Items.Clear();
            foreach (var item in TessMain.images)
	        {
                listBox1.Items.Add(item.ToString());
	        }            
        }

        private void openPorjectToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            ts.openProject();
            if (!(TessMain.projectFolder == null))
            {
                tabControl1.Enabled = true;
            }
            listBox1.Items.Clear();
            foreach (var item in TessMain.images)
            {
                listBox1.Items.Add(item.ToString());
            }
            this.Text = "Serak Trainer For Tesseract 3.0X -" + TessMain.projectFile;
            Thread t = new Thread(Loaddictionaries);
            t.Priority = ThreadPriority.Lowest;
            t.Start();
        }
        #region Loading file Thread
        private void Loaddictionaries(object obj)
        {
            if (File.Exists(TessMain.projectFolder + @"\word-list"))
            {
                txtDictionary.Lines = File.ReadAllLines(TessMain.projectFolder + @"\word-list");
                txtDictionary.Enabled = true;
                btnSaveDictionary.Enabled = false;
            }
            if (File.Exists(TessMain.projectFolder + @"\freq-dawg"))
            {
                txtfreqwods.Lines = File.ReadAllLines(TessMain.projectFolder + @"\freq-dawg");
                txtfreqwods.Enabled = true;
                btncreateNew.Enabled = false;
            }
            if (File.Exists(TessMain.projectFolder + @"\unambig-dawg"))
            {
                txtunicharambig.Lines = File.ReadAllLines(TessMain.projectFolder + @"\unambig-dawg");
                txtunicharambig.Enabled = true;
                btnsaveunichar.Enabled = false;
            }
        }
        #endregion
        private void defineFontProperties(object sender, EventArgs e)
        {
            fontwind = new Fonts();
            fontwind.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ts.TrainTesseract();
            MessageBox.Show("Training Completed","Training Hopefully Completed Succesfully",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void tesseractOptionclick(object sender, EventArgs e)
        {
            TesseractConfig option = new TesseractConfig();
            option.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!(TessMain.projectFolder==null))
            {
                tabControl1.Enabled = true;
            }
            if (File.Exists(Environment.CurrentDirectory.ToString() + '\\' + "Config.cfg"))
            {
                try
                {
                    config = File.ReadAllLines(Environment.CurrentDirectory.ToString() + '\\' + "Config.cfg");
                    ShellExcutor.tesseractlocation = config[0];
                    ShellExcutor.isolang = config[1];
                    txtisolang.Text = config[1];
                }
                catch (Exception)
                {
                    MessageBox.Show("Garbage Congiguration File","Error when trying to Load Configuration File");
                    goto outofexception;
                }
            outofexception: ;
                //continue excution;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ts.savefreqwords(txtfreqwods.Lines);
            MessageBox.Show("Saved Succesfully", "Operation Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btncreateNew_Click(object sender, EventArgs e)
        {
            ts.createNewFreqWordList(txtfreqwods.Lines);
            btnBrowse.Enabled = false;
            txtfreqwods.Enabled = true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text Files(*.txt)|*.txt";
            if (file.ShowDialog()==DialogResult.OK)
            {
                txtfreqwods.Lines = File.ReadAllLines(file.FileName,Encoding.UTF8);
                ts.browsefreqwords(file.FileName);
                txtfreqwods.Enabled = true;
            }
            
        }

        private void browseDictionary(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text Files(*.txt)|*.txt";
            if (file.ShowDialog() == DialogResult.OK)
            {
                txtDictionary.Lines = File.ReadAllLines(file.FileName, Encoding.UTF8);
                ts.browseDictionary(file.FileName);
                txtDictionary.Enabled = true;
            }
            
        }

        private void btnCreateNewDiction_Click(object sender, EventArgs e)
        {
            ts.createNewDictionary(txtDictionary.Lines);
            btnbrouseDictionary.Enabled = false;
            txtDictionary.Enabled = true;
        }

        private void btnSaveDictionary_Click(object sender, EventArgs e)
        {
            ts.savewordlist(txtDictionary.Lines);
            MessageBox.Show("Saved Succesfully", "Operation Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnbrwseunichar_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text Files(*.txt)|*.txt";
            if (file.ShowDialog() == DialogResult.OK)
            {
                txtunicharambig.Lines = File.ReadAllLines(file.FileName, Encoding.UTF8);
                ts.browseUnicharAmbig(file.FileName);
                txtunicharambig.Enabled = true;
            }
            
        }

        private void btncreateunichar_Click(object sender, EventArgs e)
        {
            ts.createNewUnicharambig(txtunicharambig.Lines);
            btnbrwseunichar.Enabled = false;
            txtunicharambig.Enabled = true;
        }

        private void btnsaveunichar_Click(object sender, EventArgs e)
        {
            ts.saveUnicharAmbig(txtunicharambig.Lines);
            MessageBox.Show("Saved Succesfully", "Operation Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void combineTessdata(object sender, EventArgs e)
        {
            ts.combineTessDatamethod();
        }

        private void browseforRecognition(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image Files(*.jpg,*.png,*.tiff,*.tif,*.bmp)|*.jpg;*.png;*.tiff;*.tif;*.bmp";
            if (file.ShowDialog()==DialogResult.OK)
            {
                txtLocation.Text = file.FileName;
                txtisolang.Text = ShellExcutor.isolang;
            }
        }

        private void recognize(object sender, EventArgs e)
        {
            if (txtLocation.Text!=null && txtisolang.Text!=null)
            {
                string[] words = ts.recognizeimage(txtLocation.Text,txtisolang.Text);
                txtRecognizedWord.Lines = words;
                if (File.Exists(txtLocation.Text.Substring(0, txtLocation.Text.LastIndexOf('\\')) + @"\output.txt"))
                {
                    //trash temporary file;
                    File.Delete(txtLocation.Text.Substring(0, txtLocation.Text.LastIndexOf('\\')) + @"\output.txt");
                }
                btnBrowseToComp.Enabled = true;
                lblPercent.Enabled = true;
                progPercent.Enabled = true;
            }

        }

        private void oCRModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.Enabled = true;
            tabControl1.SelectedIndex = 2;
        }

        private void HelpMenuStripClick(object sender, EventArgs e)
        {

        }

        private void AboutMenuStripClicked(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Text File(*.txt)|*.txt";
            if (file.ShowDialog()==DialogResult.OK)
            {
                bool fileloadedSuccesfully=ts.BrowseRatingWord(file.FileName,txtRecognizedWord.Lines);
                if (fileloadedSuccesfully)
                {
                    btnRate.Enabled = true;
                }
            }
        }
        float score;
        float prog;
        private void btnRate_Click(object sender, EventArgs e)
        {
            prog = 0.0f;        
            score= ts.returnScore();
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += timer1_Tick;     //A little bit of animation wont kill us !!! lol
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            prog=(float)Math.Round(prog += 0.3f,2);
            progPercent.Value = (int)prog;
            lblPercent.Text = prog + "%";
            if (prog >= score)
            {
                timer1.Stop();
                lblPercent.Text = score + "%";
                progPercent.Value = (int)score;
            }
        }

        private void removeNode(object sender, EventArgs e)
        {
            DialogResult rs=MessageBox.Show("Are You sure You Want To Remove This Item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs==DialogResult.Yes)
            {
                ts.removeItem(listBox1.SelectedIndex);
                listBox1.Items.Clear();
                foreach (string item in TessMain.images)
                {
                    listBox1.Items.Add(item);
                }
            }  
        }
    }
}

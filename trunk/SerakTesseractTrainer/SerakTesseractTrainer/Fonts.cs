using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerakTesseractTrainer
{
    public partial class Fonts : Form
    {
        TessMain ts = new TessMain();
        string[] fonts;
        public static string[] font_properties=null;
        public Fonts()
        {
            InitializeComponent();
        }

        private void Fonts_Load(object sender, EventArgs e)
        {
                //fonts=File.ReadAllLines(ts.projectFolder+"\\"+@"font_properties");
                int i = 0;
                fonts = new string[TessMain.images.Count];
                font_properties=new string[TessMain.images.Count];
                foreach (string item in TessMain.images)
                {
                    fonts[i] = item.Substring((item.IndexOf('.') + 1), (item.LastIndexOf('.') - 9));
                    i++;
                }
                foreach (string item in fonts)
                {
                    lstFonts.Items.Add(item);
                }
                lstFonts.SetSelected(0, true);
                button1.Text = "SET " + lstFonts.SelectedItem;
                File.WriteAllLines(TessMain.projectFolder + "\\font_properties", fonts);
        }

        private void setAllTonone(object sender, EventArgs e)
        {
            chkbold.Checked = false;
            chkFixed.Checked = false;
            chkFrankfurt.Checked = false;
            chkitalic.Checked = false;
            chkserif.Checked = false;
        }

        private void setAndSaveChanges(object sender, EventArgs e)
        {
            string bold = "0", Fixed = "0", Frankfurt = "0", italic = "0", serif = "0";
            if (chkbold.Checked)
            {
                bold = "1";
            }
            if (chkFixed.Checked)
            {
                Fixed = "1";
            }
            if (chkFrankfurt.Checked)
            {
                Frankfurt = "1";
            }
            if (chkitalic.Checked)
            {
                italic = "1";
            }
            if (chkserif.Checked)
            {
                serif = "1";
            }
            font_properties[lstFonts.SelectedIndex] = fonts[lstFonts.SelectedIndex] + " " + bold + " " + Fixed + " " + Frankfurt + " " + italic + " " + serif;
        }

        private void lstFonts_SelectedIndexChanged(object sender, EventArgs e)
        { 
            button1.Text = "SET " + lstFonts.SelectedItem;
        }
        private void saveallandclose(object sender, EventArgs e)
        {
            bool allpropertyset=true;
            foreach (string item in font_properties)
            {
                if (item == null)
                {
                    allpropertyset = false;
                    MessageBox.Show("Not All Properties Set", "Please Set Some Properties");
                }    
            }
            if (allpropertyset)
            {
                File.WriteAllLines(TessMain.projectFolder + "\\font_properties", font_properties);
            }
            this.Close();
        }
    }
}

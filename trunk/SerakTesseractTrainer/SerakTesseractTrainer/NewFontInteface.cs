using System;
using System.Collections;
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
    public partial class NewFontInteface : Form
    {
        TessMain ts = new TessMain();
        string[] fonts;
        string[] font_fromfile;
        List<string> font_properties = new List<string>();
        public NewFontInteface()
        {
            InitializeComponent();
        }
        private void NewFontInteface_Load(object sender, EventArgs e)
        {
            int i = 0;
            fonts = new string[TessMain.images.Count];
            foreach (string item in TessMain.images) //load fonts from added font list.
            {
                fonts[i] = item.Split('.')[1];
                i++;
            }
            font_fromfile = File.ReadAllLines(TessMain.projectFolder + "\\font_properties"); //load font_properties file so that it will remember already set properties
            string[] temp = new string[6];
            if (font_fromfile.Length>fonts.Length) //if file get messed up for some reason
            {
                font_properties.Clear();
                foreach (string item in fonts)
                {
                    font_properties.Add(item + " 0 0 0 0 0");
                }
            }
            foreach (string item in font_fromfile)
            {
                font_properties.Add(item);
            }
            for (int iterat = font_properties.Count; iterat < fonts.Length; iterat++)
            {
                font_properties.Add(fonts[iterat]+" 0 0 0 0 0");
            }        
            #region GridView Of The Font
            grdFont.ColumnCount = 6;  //set column of the datagridview
            int fontscount = fonts.Length;  //total number of fonts loaded
            string[] tablearray = font_properties.ToArray();
            for (int rowcount = 0; rowcount < fontscount; rowcount++)
            {
                var row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = tablearray[rowcount].Split(' ')[0]
                });
                row.Cells.Add(new DataGridViewCheckBoxCell()
                {
                    Value = convertNumtoBool(tablearray[rowcount].Split(' ')[1])
                });
                row.Cells.Add(new DataGridViewCheckBoxCell()
                {
                    Value = convertNumtoBool(tablearray[rowcount].Split(' ')[2])
                });
                row.Cells.Add(new DataGridViewCheckBoxCell()
                {
                    Value = convertNumtoBool(tablearray[rowcount].Split(' ')[3])
                });
                row.Cells.Add(new DataGridViewCheckBoxCell()
                {
                    Value = convertNumtoBool(tablearray[rowcount].Split(' ')[4])
                });
                row.Cells.Add(new DataGridViewCheckBoxCell()
                {
                    Value = convertNumtoBool(tablearray[rowcount].Split(' ')[5])
                });
                grdFont.Rows.Add(row);
            }

            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_andClose(object sender, EventArgs e)
        {
            string[] tablearray= new string[fonts.Length];
            for (int row = 0; row < fonts.Length; row++)
            {
                string tempstring = null;
                tempstring += grdFont.Rows[row].Cells[0].Value.ToString()+" ";
                tempstring += boolToString((bool)grdFont.Rows[row].Cells[1].Value)+ " ";
                tempstring += boolToString((bool)grdFont.Rows[row].Cells[2].Value) + " ";
                tempstring += boolToString((bool)grdFont.Rows[row].Cells[3].Value) + " ";
                tempstring += boolToString((bool)grdFont.Rows[row].Cells[4].Value) + " ";
                tempstring += boolToString((bool)grdFont.Rows[row].Cells[5].Value);
                tablearray[row] = tempstring;
            }
            File.WriteAllLines(TessMain.projectFolder + @"\font_properties", tablearray);
            this.Close();
        }
        private string boolToString(bool prop)    //convert bool value to 0 and 1
        {
            if (prop)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }
        private bool convertNumtoBool(string num)   //convert 0 and 1 to a bool value
        {
            if (num.Trim() == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

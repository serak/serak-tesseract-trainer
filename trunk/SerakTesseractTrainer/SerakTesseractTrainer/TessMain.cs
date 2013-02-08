using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Linq;
using System.Threading;

namespace SerakTesseractTrainer
{
    class TessMain
    {
        public static string projectPath;
        public static string projectFile;
        public static string projectFolder;
        private XmlDocument ProjXML=new XmlDocument();
        private SaveFileDialog project;
        private string files = null;
        private XmlElement xmlimages;
        private XmlElement xmlboxFiles;
        private XmlElement tessdata;
        public static ArrayList images=new ArrayList();
        #region Project Creation
        public void createNewproject()
        {
            ProjXML = new XmlDocument();
            project = new SaveFileDialog(); 
            project.Filter = "Tesseract Project(*.ser) | *.ser";
            if (project.ShowDialog()==DialogResult.OK)
            {
                    projectPath = project.FileName.Substring(0,project.FileName.LastIndexOf('\\'));
                    projectFile = project.FileName;
                    //try
                    //{
                        Xmlbuilder();
                        ProjXML.Save(projectFile);  
                    //}
                    //catch (XMLException)
                    //{
                    //    MessageBox.Show("Error When Trying To Create XML File", "Error:Cannot Create File");
                    //    return;
                    //}
            }
        }
        public void Xmlbuilder()
        {
            XmlDeclaration declare=ProjXML.CreateXmlDeclaration("1.0","utf-8",null);
            XmlElement rootNode = ProjXML.CreateElement("TesseractProject");
            ProjXML.InsertBefore(declare, ProjXML.DocumentElement);
            ProjXML.AppendChild(rootNode);
            //elements
            xmlimages = ProjXML.CreateElement("TessImages");
            xmlboxFiles = ProjXML.CreateElement("TessBoxFiles");
            tessdata = ProjXML.CreateElement("FinalTessdata");
            //add to the node xml
            rootNode.AppendChild(xmlimages);
            rootNode.AppendChild(xmlboxFiles);
            rootNode.AppendChild(tessdata);
            createProjectData();
        }
        public void createProjectData()
        {
            projectFolder = projectPath + "\\TrainData";
            Directory.CreateDirectory(projectPath + "\\" + @"TrainData");
            File.WriteAllText(projectFolder + @"\font_properties", "");
        }
        #endregion
        public void addimages()
        {
            OpenFileDialog imagefiles = new OpenFileDialog();
            imagefiles.Filter = "Tiff Images|*.tif;*.tiff";
            if (imagefiles.ShowDialog()==DialogResult.OK)
            {
                files=imagefiles.FileName;
                copyFiles();
            }
        }
        public void copyFiles()
        {
            string boxsource;
            string boxdestination;
            XmlElement element;
            XmlText xmltext;
                //Copy Image If it Does Not Exist in The project folder
                if (!File.Exists(projectFolder + "\\" + files.Substring(files.LastIndexOf('\\'))))
                {
                    File.Copy(files, projectFolder + "\\" + files.Substring(files.LastIndexOf('\\')));
                    element = ProjXML.CreateElement("Images");       
                    xmltext = ProjXML.CreateTextNode(files.Substring(files.LastIndexOf('\\') + 1));
                    images.Add(files.Substring(files.LastIndexOf('\\') + 1));
                    element.AppendChild(xmltext);
                    xmlimages.AppendChild(element);
                    ProjXML.Save(projectFile);
                }
                else
                {
                    MessageBox.Show("ImageFile Already Exist","File Exist",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                if (File.Exists(files.Substring(0, files.LastIndexOf('.')) + ".box"))
                {
                    boxsource = files.Substring(0, files.LastIndexOf('.')) + ".box";
                    boxdestination = projectFolder + "\\" + boxsource.Substring(boxsource.LastIndexOf('\\')+1);
                    if (!File.Exists(boxdestination))
                    {
                        File.Copy(boxsource, boxdestination);
                        element = ProjXML.CreateElement("BoxFiles");
                        xmltext = ProjXML.CreateTextNode(boxsource.Substring(boxsource.LastIndexOf('\\') + 1));
                        element.AppendChild(xmltext);
                        xmlboxFiles.AppendChild(element);
                        ProjXML.Save(projectFile);
                    }
                    else
                    {
                        MessageBox.Show("Box Files Already Exist");
                    }
                }
                else
                {
                    Box_Creator cr = new Box_Creator(files);
                    cr.Show();
                }
        }
        public void openProject()
        {
            OpenFileDialog openpro = new OpenFileDialog();
            openpro.Filter = "Tesseract ser Project(*.ser)|*.ser";
            if (openpro.ShowDialog()==DialogResult.OK)
            {
                projectFile = openpro.FileName;
                projectPath = projectFile.Substring(0, projectFile.LastIndexOf('\\'));
                projectFolder = projectPath + "\\TrainData";
                //Fonts.font_properties=File.ReadAllLines(projectFolder + @"\font_properties");
                ProjXML.Load(openpro.FileName);
                XmlNode tessimages = ProjXML.SelectSingleNode("TesseractProject/TessImages");
                XmlNode tessbox = ProjXML.SelectSingleNode("TesseractProject/TessBoxFiles");
                xmlimages = (XmlElement)tessimages;
                xmlboxFiles = (XmlElement)tessbox;
                XmlNodeList tempimagenode = tessimages.SelectNodes("Images");
                foreach (XmlNode item in tempimagenode)
                {
                    images.Add(item.InnerText);
                }
                //TODO:load dictionary if exists

            }
        }
        public void setFontProperties()
        {
            string[] fonts;
            try{
                fonts=File.ReadAllLines(projectFolder+"\\"+@"font_properties");
            }
            catch(IOException)
            {
                MessageBox.Show("File not found");
            }
        }
        #region TesseractCMD Executor
        public void TrainTesseract()
        {            
            ShellExcutor sh = new ShellExcutor();
            foreach (var item in images)
            {
                if (File.Exists(projectFolder+'\\'+item.ToString().Substring(0,item.ToString().LastIndexOf('.'))+".box"))
                {
                    sh.cmdExcute("tesseract.exe", ShellExcutor.tesseractlocation," "+item+ " " +item.ToString().Substring(0,item.ToString().LastIndexOf('.')) + " nobatch box.train", projectFolder);
                }
                else
                {
                    MessageBox.Show("Box File is Missing", "Error Cannot continue excution");
                    return;
                }
            }
            string[] files = Directory.GetFiles(projectFolder);
            //Compute the Character Set  
            string boxfilesingleline = null ;
            string trfilessigleline = null;
            foreach (string  item in files)
            {
                if (item.EndsWith(".box"))
                {
                    boxfilesingleline += " " + item.Substring(item.LastIndexOf('\\')+1) + " ";
                }
                if (item.EndsWith(".tr"))
                {
                    trfilessigleline += " " + item.Substring(item.LastIndexOf('\\') + 1) + " ";
                }
            }
            sh.cmdExcute("unicharset_extractor.exe", ShellExcutor.tesseractlocation, boxfilesingleline, projectFolder);
            //Clustering
            sh.cmdExcute("shapeclustering.exe", ShellExcutor.tesseractlocation, " -F font_properties -U unicharset " + trfilessigleline, projectFolder);
            sh.cmdExcute("mftraining.exe", ShellExcutor.tesseractlocation, " -F font_properties -U unicharset -O " + ShellExcutor.isolang + ".unicharset " + trfilessigleline, projectFolder);
            sh.cmdExcute("cntraining.exe", ShellExcutor.tesseractlocation, trfilessigleline, projectFolder);
        }
        #endregion
        #region DawgfilecreationandMAnipulation

        public void savefreqwords(string[] freqlisttext)
        {
            File.WriteAllLines(projectFolder + @"\freq-dawg", freqlisttext, Encoding.UTF8);
        }

        public void createNewFreqWordList(string[] freqlisttext)
        {
            if (!File.Exists(projectFolder + @"\freq-dawg"))
            {
                File.WriteAllLines(projectFolder + @"\freq-dawg", freqlisttext, Encoding.UTF8);
            }
            else
            {
                DialogResult rs = MessageBox.Show("File Already Exist Do you Want To Replace It?", "File Exist", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (rs == DialogResult.Yes)
                {
                    File.WriteAllLines(projectFolder + @"\freq-dawg", freqlisttext, Encoding.UTF8);
                }
            }
        }

        public void browsefreqwords(string freqlisttext)
        {
            if (!File.Exists(projectFolder + @"\freq-dawg"))
            {
                File.Copy(freqlisttext, projectFolder + @"\freq-dawg");
            }
            else
            {
                DialogResult rs=MessageBox.Show("File Already Exist Do you Want To Replace It?", "File Exist", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (rs==DialogResult.Yes)
                {
                    File.Copy(freqlisttext, projectFolder + @"\freq-dawg", true);
                }
            }
        }

        public void browseDictionary(string wordlisttext)
        {
            if (!File.Exists(projectFolder + @"\word-list"))
            {
                File.Copy(wordlisttext, projectFolder + @"\word-list");
            }
            else
            {
                DialogResult rs = MessageBox.Show("File Already Exist Do you Want To Replace It?", "File Exist", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (rs == DialogResult.Yes)
                {
                    File.Copy(wordlisttext, projectFolder + @"\word-list", true);
                }
            }
        }

        public void createNewDictionary(string[] rt)
        {
            if (!File.Exists(projectFolder + @"\word-list"))
            {
                File.WriteAllLines(projectFolder + @"\word-list", rt, Encoding.UTF8);
            }
            else
            {
                DialogResult rs = MessageBox.Show("File Already Exist Do you Want To Replace It?", "File Exist", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (rs == DialogResult.Yes)
                {
                    File.WriteAllLines(projectFolder + @"\word-list", rt, Encoding.UTF8);
                }
            }
        }

        public void savewordlist(string[] wordlisttxt)
        {
            File.WriteAllLines(projectFolder + @"\word-list", wordlisttxt, Encoding.UTF8);
        }

        public void browseUnicharAmbig(string unichartext)
        {
            if (!File.Exists(projectFolder + @"\unambig-dawg"))
            {
                File.Copy(unichartext, projectFolder + @"\unambig-dawg");
            }
            else
            {
                DialogResult rs = MessageBox.Show("File Already Exist Do you Want To Replace It?", "File Exist", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (rs == DialogResult.Yes)
                {
                    File.Copy(unichartext, projectFolder + @"\unambig-dawg", true);
                }
            }
        }

        internal void createNewUnicharambig(string[] unichartext)
        {
            if (!File.Exists(projectFolder + @"\unambig-dawg"))
            {
                File.WriteAllLines(projectFolder + @"\unambig-dawg", unichartext, Encoding.UTF8);
            }
            else
            {
                DialogResult rs = MessageBox.Show("File Already Exist Do you Want To Replace It?", "File Exist", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (rs == DialogResult.Yes)
                {
                    File.WriteAllLines(projectFolder + @"\unambig-dawg", unichartext, Encoding.UTF8);
                }
            }
        }

        internal void saveUnicharAmbig(string[] unichartext)
        {
            File.WriteAllLines(projectFolder + @"\unambig-dawg", unichartext, Encoding.UTF8);
        }
#endregion

        public void combineTessDatamethod()
        {
            if (!Directory.Exists(projectFolder + @"\Tessdata"))
            {
                Directory.CreateDirectory(projectFolder + @"\Tessdata");
            }
                ShellExcutor sh = new ShellExcutor();
                if (File.Exists(projectFolder+@"\word-list"))
                {
                    sh.cmdExcute("wordlist2dawg.exe", ShellExcutor.tesseractlocation, " word-list " + ShellExcutor.isolang + ".word-dawg " + ShellExcutor.isolang + ".unicharset ", projectFolder);
                }
                if (File.Exists(projectFolder + @"\unambig-dawg"))
                {
                    sh.cmdExcute("wordlist2dawg.exe", ShellExcutor.tesseractlocation, " unambig-dawg " + ShellExcutor.isolang + ".unicharambigs " + ShellExcutor.isolang + ".unicharset ", projectFolder);
                }
                if (File.Exists(projectFolder + @"\freq-dawg"))
                {
                    sh.cmdExcute("wordlist2dawg.exe", ShellExcutor.tesseractlocation, " freq-dawg " + ShellExcutor.isolang + ".freq-dawg " + ShellExcutor.isolang + ".unicharset ", projectFolder);
                }
                try
                {
                    File.Copy(projectFolder + @"\inttemp", projectFolder + '\\' + ShellExcutor.isolang + @".inttemp",true);
                    File.Copy(projectFolder + @"\shapetable", projectFolder + '\\' + ShellExcutor.isolang + @".shapetable",true);
                    File.Copy(projectFolder + @"\normproto", projectFolder + '\\' + ShellExcutor.isolang + @".normproto",true);
                    File.Copy(projectFolder + @"\pffmtable", projectFolder + '\\' + ShellExcutor.isolang + @".pffmtable",true);
                    sh.cmdExcute("combine_tessdata.exe", ShellExcutor.tesseractlocation, " " + ShellExcutor.isolang + ".",projectFolder);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }               
                try
                {
                    File.Copy(projectFolder + '\\' + ShellExcutor.isolang + ".traineddata", projectFolder + @"\Tessdata\" + ShellExcutor.isolang + @".traineddata",true);
                    MessageBox.Show("Creation of Tessdata is Succesfull", "Completed Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
        }

        public string[] recognizeimage(string imagepath,string lang)
        {
            ShellExcutor sh = new ShellExcutor();
            sh.cmdExcute("tesseract.exe",ShellExcutor.tesseractlocation," \""+imagepath+"\" \""+imagepath.Substring(0,imagepath.LastIndexOf('\\'))+"\\output\" -l "+lang,imagepath.Substring(0,imagepath.LastIndexOf('\\')));
            return (File.ReadAllLines(imagepath.Substring(0,imagepath.LastIndexOf('\\'))+"\\output.txt",Encoding.UTF8));
        }
        List<string> originalwordlist = new List<string>();
        List<string> recognizedwordlist = new List<string>();
        int totalwords;
        public bool BrowseRatingWord(string file,string[] text)
        {
            string[] originaltxt=File.ReadAllLines(file);
            foreach (string item in originaltxt)
            {
                foreach (string subitem in item.Split(' '))
                {
                    originalwordlist.Add(subitem);
                }
            }
            foreach (string item in text)
            {
                foreach (string substring in item.Split(' '))
                {
                    recognizedwordlist.Add(substring);
                }
            }
            if (originaltxt.Count<string>() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public float returnScore()
        {
            int correctwords = 0; 
            IEnumerable<string> distrecognized = recognizedwordlist.Distinct<string>();
            IEnumerable<string> distoriginal = originalwordlist.Distinct<string>();
            totalwords = distoriginal.Count<string>(); //total number of words
            foreach (string item1 in distoriginal)
            {
                foreach (string item2 in distrecognized)
                {
                    if (item2 == item1)
                    {
                        correctwords++;
                    }
                }
            }
            float tempscore;    //Percent Must not Exced 100%
            if (correctwords<=totalwords)
            {
                tempscore = (float)correctwords / (float)totalwords * 100;
            }
            else
            {
                tempscore = (float)totalwords / (float)correctwords * 100;
            }
            double score = Math.Round(tempscore, 2);
            return (float)score;
        }

        public void removeItem(int p)
        {
            XmlNode tempnode1 = ProjXML.SelectSingleNode("TesseractProject/TessImages");
            XmlNode tempnodebox = ProjXML.SelectSingleNode("TesseractProject/TessBoxFiles");
            XmlNodeList nodes = tempnode1.SelectNodes("Images");
            XmlNodeList nodesbox = tempnodebox.SelectNodes("BoxFiles");
            try
            {
                if (File.Exists(projectFolder + "\\" + images[p].ToString()))
                {
                    File.Delete(projectFolder + "\\" + images[p].ToString());
                    images.RemoveAt(p);
                    nodes[p].ParentNode.RemoveChild(nodes[p]);
                }
                if (File.Exists(projectFolder + "\\" + images[p].ToString().Substring(0, images[p].ToString().LastIndexOf('.')) + ".box"))
                {
                    File.Delete(projectFolder + "\\" + images[p].ToString().Substring(0, images[p].ToString().LastIndexOf('.')) + ".box");
                    nodesbox[p].ParentNode.RemoveChild(nodesbox[p]);
                }
                ProjXML.Save(projectFile);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Error Has Occurred Make sure You Have Selected An item", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }  
        }
    }
}

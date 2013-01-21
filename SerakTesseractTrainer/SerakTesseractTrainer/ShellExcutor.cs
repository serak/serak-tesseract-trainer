using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SerakTesseractTrainer
{
    class ShellExcutor
    {
        public static string tesseractlocation;
        public static string isolang;
        public void cmdExcute(string command, string TessractFolder,string parameter, string projectFolder)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.UseShellExecute = true;
            info.WorkingDirectory = projectFolder;
            info.CreateNoWindow = true;
            info.Arguments = parameter;
            info.FileName = TessractFolder + '\\' + command;
            Process p = Process.Start(info);
            p.WaitForExit();
        }
    }
}

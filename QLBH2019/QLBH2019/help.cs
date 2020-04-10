using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QLBH2019
{
    class help
    {
        public class HTMLHelpClass
        {
            static public string HelpNamespace { get; set; }

            // GetLocalHelpFileName() returns the full filename with path
            // to the help file located in the same directory with the
            // compiled EXE file
            static public string GetLocalHelpFileName(string FileName)
            {
                string ExeName = Environment.GetCommandLineArgs()[0];
                string DirName = Path.GetDirectoryName(ExeName);
                string HelpFileName = DirName + "\\" + FileName;
                return HelpFileName;
            }
        }

    }
}

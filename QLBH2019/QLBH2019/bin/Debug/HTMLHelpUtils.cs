// This simple module provides some utility functions that help you
// integrate an HTML Help system with your C# application.
//
// Copyright © 2009 HelpSmith.com. All rights reserved.
// http://www.helpsmith.com - Making Help Authoring a Pleasure to Do

using System;
using System.IO;

namespace HTMLHelpUtils
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
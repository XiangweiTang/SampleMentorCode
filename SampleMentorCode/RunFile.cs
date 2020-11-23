using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SampleMentorCode
{
    public static class RunFile
    {
        /// <summary>
        /// A general function for run a file.
        /// The user just need to provide different parameters when call it.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="argument"></param>
        /// <param name="useShell"></param>
        /// <param name="workingDirectory"></param>
        public static void Run(string fileName, string argument, bool useShell, string workingDirectory)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = fileName;
            proc.StartInfo.Arguments = argument;
            proc.StartInfo.UseShellExecute = useShell;
            proc.StartInfo.WorkingDirectory = workingDirectory;
            proc.Start();
            proc.WaitForExit();
        }
    }

    public class CallRunFile
    {
        public CallRunFile()
        {
            string fileName = @"\\PATH\OF\FILE";
            // Call some file directly.
            RunFile.Run(fileName, "", false, "");

            string argument = "ARG0 ARG1 ARG2";
            // Call the file, with certain arguments.
            RunFile.Run(fileName, argument, false, "");

            bool useShell = true;
            // Call the file, with certain arguments, and create an extra window when executing.
            RunFile.Run(fileName, argument, useShell, "");

            string workingDirectory = @"\\PATH\OF\WORKING\DIRECTORY";
            RunFile.Run(fileName, argument, useShell, workingDirectory);
        }
    }
}

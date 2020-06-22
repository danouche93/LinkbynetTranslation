using System;
using System.Diagnostics;
using System.IO;

namespace DownloadTranslation
{
    class Program
    {
        public static string directory = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
        static void Main(string[] args)
        {
            var proc1 = new ProcessStartInfo();
            string anyCommand = "";
            proc1.UseShellExecute = true;
            proc1.WorkingDirectory = directory;
            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            proc1.WindowStyle = ProcessWindowStyle.Hidden;

            anyCommand = "lokalise2 --token f18c80496d07c67b91487342ec0a0f3cd7d7abe0 --project-id 768798215edc9e65e24ac2.96282430 file download --format json" +
                                        " --unzip-to ./ --original-filenames=true --directory-prefix .";

            proc1.Arguments = "/c " + anyCommand;
            var cmd = Process.Start(proc1);
            cmd.WaitForExit();
        }
    }
}

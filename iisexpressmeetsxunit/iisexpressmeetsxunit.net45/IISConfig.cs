using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iisexpressmeetsxunit.net45
{
    public class IISConfig
    {

        public FileInfo GetIISExpress()
        {
            string iisExpress = @"IIS Express\iisexpress.exe";

            if (Environment.Is64BitOperatingSystem)
            {
                return new System.IO.FileInfo(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonProgramFiles), iisExpress));

            }
            else
            {
                return new System.IO.FileInfo(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonProgramFilesX86), iisExpress));
            }            
        }
    }
}

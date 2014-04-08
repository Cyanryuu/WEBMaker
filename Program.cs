using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Collections;
namespace WebmShitter
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //make some fucking folders and drop ffmpeg for some webm shitting
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\bin"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\bin");

                using (var resource = Assembly.GetExecutingAssembly().GetManifestResourceStream("WEBMaker.Resources.ffmpeg.exe"))
                {

                    using (var file = new FileStream(Directory.GetCurrentDirectory() + "\\bin\\ffmpeg.exe", FileMode.Create, FileAccess.Write))
                    {
                        resource.CopyTo(file);
                    }
                }

                using (var resource = Assembly.GetExecutingAssembly().GetManifestResourceStream("WEBMaker.Resources.list"))
                {

                    using (var file = new FileStream(Directory.GetCurrentDirectory() + "\\bin\\list", FileMode.Create, FileAccess.Write))
                    {
                        resource.CopyTo(file);
                    }
                }
            }
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\output"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\output");
            }


            Application.Run(new Form1());
        }
    }
}

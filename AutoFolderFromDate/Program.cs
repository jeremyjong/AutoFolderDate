using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFolderFromDate
{
    class Program
    {
        

        static void Main(string[] args)
        {



            DateTime today = DateTime.Today;
            
            var files = Directory.GetFiles("L:\\(Manga)\\");

            


            foreach (var f in files)
            {

                FileInfo fInfo = new FileInfo(f);

                var fLastTime = fInfo.LastWriteTime.ToString("yyyyMMdd");
                string destinationDirectory = "L:\\(Manga)\\" + fLastTime;

                System.IO.Directory.CreateDirectory(destinationDirectory);
                System.IO.File.Move(f, destinationDirectory + "\\" + Path.GetFileName(f));
                
            }


        }
    }
}

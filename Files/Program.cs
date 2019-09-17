using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourcePath = @"C:\Users\shail\bob.jpg";
            var destPath = @"C:\Users\shail\Desktop\bobcopy.jpg";
            File.Copy(sourcePath, destPath , true);
            
            if(File.Exists(destPath))
            {
                File.Delete(destPath);
            }
            var fileContent = File.ReadAllBytes(sourcePath);
            foreach (var item in fileContent)
                Console.WriteLine(item);

            var fileInfo = new FileInfo(sourcePath);
            fileInfo.CopyTo("...");
            fileInfo.Delete();// no path required
            if(fileInfo.Exists) // Exists is a property and not a function
            {
                // Do something
            }
            fileInfo.OpenRead();
        }
    }
}

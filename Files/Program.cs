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
            /*var sourcePath = @"C:\Users\shail\bob.jpg";
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
            fileInfo.OpenRead();*/

            //Directory.CreateDirectory(@"c:\Users\shail\TempFolder");
            /*var jpgFiles = Directory.GetFiles(@"c:\Users\shail", "*.*");
            foreach (var item in jpgFiles)
                Console.Write(item + " ");

            var directories = Directory.GetDirectories(@"C:\Users\shail\OneDrive\Desktop\CareerDevs", "*.*", SearchOption.AllDirectories);
            foreach (var item in directories)
                Console.WriteLine(item + " ");
            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();*/

            var path = @"C:\Projects\HelloWorld\HelloWorld.sln";

            Console.WriteLine("Extension: "+Path.GetExtension(path));
            Console.WriteLine("FileName: " + Path.GetFileName(path));
            Console.WriteLine("FileName without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
        }
    }
}

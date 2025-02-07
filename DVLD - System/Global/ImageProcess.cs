using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___System.Global
{
    static public class ImageProcess
    {
        static public bool isImagePathExist(string path)
        {
            return File.Exists(path);
        }
        static public string GenerateGuid()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }
        public static string ReplaceFileNameWithGUID(string sourceFile)
        {
            // Full file name. Change your file name   
            string extn = new FileInfo(sourceFile).Extension;

            return GenerateGuid() + extn;

        }
        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {
            // Check if the folder exists
            if (Directory.Exists(FolderPath)) return true;

            try
            {
                // If it doesn't exist, create the folder
                Directory.CreateDirectory(FolderPath);
            }
            catch { return false; }

            return true;
        }


        public static bool CopyImageToSystemFolder(ref string sourceFile)
        {
            // this funciton will copy the image to the
            // project images foldr after renaming it
            // with GUID with the same extention, then it will update the sourceFileName with the new name.

            string DestinationFolder = @"C:\DVLD - profiles\";
            if (!CreateFolderIfDoesNotExist(DestinationFolder)) return false;

            string destinationFile = DestinationFolder + ReplaceFileNameWithGUID(sourceFile);

            try
            {
                File.Copy(sourceFile, destinationFile, true);
            }
            catch { return false; }

            sourceFile = destinationFile;
            return true;
        }

        static public bool DeleteImage(string path)
        {
            if(!File.Exists(path)) return false;

            try
            { File.Delete(path); }
            catch { return false; }

            return true;
        }
    }
}

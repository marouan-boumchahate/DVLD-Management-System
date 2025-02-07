using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___System.Global
{
    public class Generate
    {
        private static string Characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~\r\n";
        static public string GenerateCode(int length, bool onlyDigits = true)
        {
            string targetPass = "";
            Random rand = new Random();

            int min = !onlyDigits ? 0 : Characters.IndexOf('0');
            int max = !onlyDigits ? Characters.Length : Characters.IndexOf('9');


            for (int i = 0; i < length; i++)
                targetPass += Characters[rand.Next(min, max)];

            return targetPass;
        }
    }
}

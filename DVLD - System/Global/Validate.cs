using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___System.Global
{
    public class Validate
    {
        // Valide Email's name characters
        static HashSet<char> allowedEmailCharacters = new HashSet<char>
        {
            '!', '#', '$', '%', '&', '\'', '*', '+', '/', '=', '?', '^', '_', '{', '|', '}', '~',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.'
        };

        static public bool EmailFormat(string email)
        {
            // email must be in this form 'example@example.domain'
            // ---------------------------------------------------

            // Find @ character
            int atIndex = -1;

            for (int i = email.Length - 1; i >= 0; i--)
                if (email[i] == '@') { atIndex = i; break; }

            if (atIndex == -1) return false;

            // Seperate Email
            string username = email.Substring(0, atIndex);

            // Check if name correct
            if (username[0] == '.' || username[username.Length - 1] == '.' ) return false;
            char currentChar = ' ';

            foreach(char c in username)
            {
                // Prevent name to have two consecutively dots (..)
                if(c == '.' && currentChar == c) return false;
                currentChar = c;

                if(!allowedEmailCharacters.Contains(c)) return false;
            }

            return true;
        }
    }
}

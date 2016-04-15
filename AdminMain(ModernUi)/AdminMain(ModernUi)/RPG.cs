using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminMain_ModernUi_
{
    public class RPG
    {
        public string rndmpwrd()
        {
            string[] characters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

            Random R = new Random();
            string pass = null;
            for (int i = 0; i < 8; i++)
            {
                pass += characters[R.Next(0, characters.Length)];
            }

            return pass;
        }
    }
}

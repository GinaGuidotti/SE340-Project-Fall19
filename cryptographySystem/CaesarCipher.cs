/*******************************************************************
** Name         : Gina Guidotti, Justin Marsland and Paiktra Nom  **
** Due Date     : December 1st, 2019                              **
** Class        : SE 340                                          **
** Instructor   : Xiaoli Mao                                      **
** Functionality: CaesarCipher Class used in the Program.cs file  **
**                to run this project.                            **
*******************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace cryptographySystem
{
    public class CaesarCipher
    {
        public CaesarCipher()
        {
            Console.Write("Creation of the Caesar Cipher:\n");
        }

        //To be called to Encrypt the text string
        public string Encipher(string text, int key)
        {
            string output = string.Empty;

            foreach (char ch in text)
                output += cipher(ch, key);

            return output;
        }

        //To be called to Decrypt the text string
        public string Decipher(string text, int key)
        {
            return Encipher(text, 26 - key);
        }

        //The method that does all the work with each character and the key integer
        public char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);

        }
    }

}
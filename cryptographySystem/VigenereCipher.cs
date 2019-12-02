/*******************************************************************
** Name         : Gina Guidotti, Justin Marsland and Paiktra Nom  **
** Due Date     : December 1st, 2019                              **
** Class        : SE 340                                          **
** Instructor   : Xiaoli Mao                                      **
** Functionality: VigenereCipher Class used in the Program.cs file**
**                to run this project.                            **
*******************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace cryptographySystem
{
    class VigenereCipher
    {      
        public VigenereCipher()
        {
            Console.Write("Creation of the Vigenere Cipher:\n");
        }

        
        //The method that does all the work
        private string Cipher(string input, string key, bool encipher)
        {
            for (int i = 0; i < key.Length; ++i)
                if (!char.IsLetter(key[i]))
                    return "Error: Not a letter";  

            string output = string.Empty;
            int nonAlphaCharCount = 0;

            for (int i = 0; i < input.Length; ++i)
            {
                if (char.IsLetter(input[i]))
                {
                    bool cIsUpper = char.IsUpper(input[i]);
                    char offset = cIsUpper ? 'A' : 'a';
                    int keyIndex = (i - nonAlphaCharCount) % key.Length;
                    int k = (cIsUpper ? char.ToUpper(key[keyIndex]) : char.ToLower(key[keyIndex])) - offset;
                    k = encipher ? k : -k;
                    char ch = (char)((Mod(((input[i] + k) - offset), 26)) + offset);
                    output += ch;
                }
                else
                {
                    output += input[i];
                    ++nonAlphaCharCount;
                }
            }

            return output;
        }

        //To be called for encrypting the input string
        public string Encrypt(string input, string key)
        {
            return Cipher(input, key, true);
        }

        //To be called for decrypting the input string
        public string Decrypt(string input, string key)
        {
            return Cipher(input, key, false);
        }

        //To be called for printing the input string
        public void PrintStringText(string input)
        {
            Console.WriteLine("Text: " + input);
        }
        
        //To be called for doing the mod operation
        private static int Mod(int a, int b)
        {
            return (a % b + b) % b;
        }

    }

}


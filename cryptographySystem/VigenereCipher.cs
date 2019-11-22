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
        private const char LowChar = 'A';
        private const char HighChar = 'Z';
        private const int AlphaSize = HighChar - LowChar + 1;

        public string Encrypt(string plaintext, string key)
        {
            plaintext = PrepareInput(plaintext);
            key = PrepareInput(key);

            var ciphertext = new StringBuilder();
            for (var i = 0; i < plaintext.Length; i++)
            {
                var offset = key[i % key.Length] - LowChar + 1;
                var encrypted = plaintext[i] + offset;
                if (encrypted > HighChar)
                {
                    encrypted -= AlphaSize;
                }

                ciphertext.Append((char)encrypted);
            }

            return ciphertext.ToString();
        }

        public string Decrypt(string ciphertext, string key)
        {
            ciphertext = PrepareInput(ciphertext);
            key = PrepareInput(key);

            var plaintext = new StringBuilder();
            for (var i = 0; i < ciphertext.Length; i++)
            {
                var offset = key[i % key.Length] - LowChar + 1;
                var decrypted = ciphertext[i] - offset;
                if (decrypted < LowChar)
                {
                    decrypted += AlphaSize;
                }

                plaintext.Append((char)decrypted);
            }

            return plaintext.ToString();
        }

        private static string PrepareInput(string input)
        {
            var regex = new Regex("[^A-Z]");
            return regex.Replace(input.ToUpper(), string.Empty);
        }

        public void PrintStringText(string input)
        {
            Console.WriteLine("Text: " + input);
        }

    }

}


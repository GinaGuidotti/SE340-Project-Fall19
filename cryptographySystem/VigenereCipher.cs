﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace cryptographySystem
{
    class VigenereCipher
    {
        private const char LowerBound = 'A';
        private const char UpperBound = 'Z';
        private const int AlphabetSize = UpperBound - LowerBound + 1;

        public string Encrypt(string plaintext, string key)
        {
            plaintext = PrepareInput(plaintext);
            key = PrepareInput(key);

            var ciphertext = new StringBuilder();
            for (var i = 0; i < plaintext.Length; i++)
            {
                var offset = key[i % key.Length] - LowerBound + 1;
                var encrypted = plaintext[i] + offset;
                if (encrypted > UpperBound)
                {
                    encrypted -= AlphabetSize;
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
                var offset = key[i % key.Length] - LowerBound + 1;
                var decrypted = ciphertext[i] - offset;
                if (decrypted < LowerBound)
                {
                    decrypted += AlphabetSize;
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


/**************************************************************
** Name: Gina Guidotti, Justin Marsland and Paiktra Nom      **
** Due Date: December 1st, 2019                              **
** Class: SE 340                                             **
** Instructor: Xiaoli Mao                                    **
** Functionality: Main Program to run Project                **
***************************************************************/
using System;

namespace cryptographySystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            const string key = "softwarearchitecture";
            string plaintext = "";
            string encrypttext = "";
            string decrypttext = "";
            int choice;
            VigenereCipher theCipher = new VigenereCipher();
            Console.WriteLine("Enter a string to be encrypted: ");
            plaintext = Console.ReadLine();

            /* Pipe 1 */
            Console.Write("Plaintext ");
            theCipher.PrintStringText(plaintext);

            /* Filter 1 */
            encrypttext = theCipher.Encrypt(plaintext, key);

            /* Pipe 2 */
            Console.Write("Encrypted ");
            theCipher.PrintStringText(encrypttext);

            /* Filter 2 */
            decrypttext = theCipher.Decrypt(encrypttext, key);

            /* Pipe 3 */
            Console.Write("Decrypted ");
            theCipher.PrintStringText(decrypttext);
        }


    }



}

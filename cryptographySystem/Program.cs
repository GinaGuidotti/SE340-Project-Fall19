/*******************************************************************
** Name         : Gina Guidotti, Justin Marsland and Paiktra Nom  **
** Due Date     : December 1st, 2019                              **
** Class        : SE 340                                          **
** Instructor   : Xiaoli Mao                                      **
** Functionality: Main program that runs this System.             **
*******************************************************************/
using System;

namespace cryptographySystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            string key = "softwarearchitecture";    //Default key value            
            int choice = 1;                         //Default to Vigenere Cipher First
            string plaintext, encrypttext, decrypttext = "";


            Console.WriteLine("Welcome to the Cryptography System");
            Console.WriteLine("\nThe purpose of this system is to show how the Vigenere and Caesar cipher works.");
            
            do
            {
                Console.WriteLine("==================");
                Console.WriteLine("Menu Options: ");
                Console.WriteLine("==================");
                Console.WriteLine("1. Vigenere Cipher");
                Console.WriteLine("2. Caesar Cipher ");
                Console.WriteLine("0. Exit System ");
                Console.WriteLine("==================");
                Console.WriteLine("\nEnter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) 
                {
                    case 1: 
                        //Vigenere Cipher
                        VigenereCipher theVCipher = new VigenereCipher();
                        Console.WriteLine("\nEnter a string to be encrypted: ");
                        plaintext = Console.ReadLine();

                        Console.WriteLine("Enter a string to be used as the key: ");
                        key = Console.ReadLine();


                        Console.Write("Plaintext Given: ");
                        theVCipher.PrintStringText(plaintext);

                        encrypttext = theVCipher.Encrypt(plaintext, key);

                        Console.Write("Encrypted String:  ");
                        theVCipher.PrintStringText(encrypttext);

                        decrypttext = theVCipher.Decrypt(encrypttext, key);

                        Console.Write("Decrypted String:  ");
                        theVCipher.PrintStringText(decrypttext);
                        break;

                    case 2:
                        //Caesar Cipher
                        CaesarCipher theCCipher = new CaesarCipher();
                        Console.WriteLine("\nEnter a string to be encrypted: ");
                        plaintext = Console.ReadLine();

                        Console.WriteLine("Enter an integer to be used as the key: ");
                        int caesarKey = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Encrypted Data: ");
                        encrypttext = theCCipher.Encipher(plaintext, caesarKey);
                        Console.WriteLine(encrypttext);

                        Console.WriteLine("Decrypted Data: ");
                        decrypttext = theCCipher.Decipher(encrypttext, caesarKey);
                        Console.WriteLine(decrypttext);
                        break;

                    case 0:
                        Console.WriteLine("Thank you for using the Cryptography System."); 
                        break;
                }                 
            } while (choice != 0);
        }

    }   

}

using System;
using System.Text;
using System.Collections.Generic;

namespace Palindrome_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Palindrome Challenge

            Console.WriteLine("Let's begin:");

            bool loop = true;
            string checkword ="";

            while(loop)
            {
                var userInput = Console.ReadLine();
                int counter = userInput.Length -1;

                while(counter != -1)
                {
                    checkword += string.Concat(userInput[counter]);
                    counter--;
                }

                if (checkword == userInput)
                {
                    Console.WriteLine($"The word {checkword} is palindrome and length is {checkword.Length}");
                    checkword = "";
                }
                else if(userInput == "exit")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine($"The word {checkword} is not a palindrome");
                    checkword = "";
                }

            }

            Console.ReadLine();
            

        }
    }
}

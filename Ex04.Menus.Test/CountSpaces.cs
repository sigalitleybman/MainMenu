using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountSpaces : MenuItem, IRunnable
    {
        public CountSpaces(string i_Operation) : base(i_Operation)
        {

        }

        public void Run()
        {
            string userSentence = string.Empty;
            int counterOfSpaces = 0;

            Console.WriteLine("Please enter a sentence");
            userSentence = Console.ReadLine();
            foreach (char letter in userSentence)
            {
                if (letter == ' ')
                {
                    counterOfSpaces++;
                }
            }

            Console.WriteLine("There were " + counterOfSpaces + " spaces");
        }
    }
}

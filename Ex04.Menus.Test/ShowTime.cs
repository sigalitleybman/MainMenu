using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTime : MenuItem, IRunnable
    {
        public ShowTime(string i_Operation) : base(i_Operation)
        {

        }

        public void Run()
        {
            Console.WriteLine("The current time is: " + DateTime.Now);
        }
    }
}

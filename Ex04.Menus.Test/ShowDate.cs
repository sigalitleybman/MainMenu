using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDate : MenuItem, IRunnable
    {
        public ShowDate(string i_Operation) : base (i_Operation)
        {
        }

        public void Run()
        {
            Console.WriteLine("The current date is: " + DateTime.Today.Day + "\\" + DateTime.Today.Month + "\\" + DateTime.Today.Year);
        }

        public static void ShowDateDelegate()
        {
            Console.WriteLine("The current date is: " + DateTime.Today.Day + "\\" + DateTime.Today.Month + "\\" + DateTime.Today.Year);
        }
    }
}

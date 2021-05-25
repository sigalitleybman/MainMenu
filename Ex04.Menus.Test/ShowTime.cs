using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;
//using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class ShowTime : MenuItem, IRunnable
    {
        public ShowTime(string i_Operation) : base(i_Operation)
        {

        }

        public void Run()
        {
            Console.WriteLine("The current time is: {0:00}:{1:00}:{2:00} ",DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }

        public static void ShowTimeDelegate()
        {
            Console.WriteLine("The current time is: {0:00}:{1:00}:{2:00} ", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }
    }
}

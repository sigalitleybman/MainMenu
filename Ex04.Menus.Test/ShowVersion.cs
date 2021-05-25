using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;
//using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class ShowVersion : MenuItem, IRunnable
    {
        public ShowVersion(string i_Operation) : base(i_Operation)
        {

        }

        public void Run()
        {
            Console.WriteLine("Version: 21.1.4.8930");
        }

        public static void ShowVersionDelegate() 
        {
            Console.WriteLine("Version: 21.1.4.8930");
        }


    }
}

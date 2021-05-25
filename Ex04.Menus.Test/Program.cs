﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    class Program
    {
        public static void Main()
        {
            InterfaceUI interfaceObj = new InterfaceUI();
            DelegateUI delegatesObj = new DelegateUI();

            interfaceObj.EntryPoint();
            delegatesObj.EntryPoint();
        }
    }
}

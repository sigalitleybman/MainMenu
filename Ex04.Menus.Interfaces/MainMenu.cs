using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    class MainMenu
    {
       

        private UnderMenu m_GeneralMenu;
        //private readonly int m_MenuLevel = 1;

        public MainMenu(UnderMenu i_GeneralMenu, int i_MenuLevel, string i_MenuName)
        {
            m_GeneralMenu = new UnderMenu();
        }

        public static void show()
        {

        }

    }
}

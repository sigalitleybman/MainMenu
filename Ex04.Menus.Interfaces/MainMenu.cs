using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    class MainMenu
    {
        public enum eLevel
        {
           First = 1,
           Second = 2,
        }

        private UnderMenu m_GeneralMenu = new UnderMenu();
        private readonly eLevel m_MenuLevel = eLevel.First;


    }
}

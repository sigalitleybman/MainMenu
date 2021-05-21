using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    class MainMenu
    {
       

        private UnderMenu m_GeneralMenu;
        //private readonly int m_MenuLevel = 1;

        public MainMenu(string i_PressedButton, int i_MenuLevel, string i_MenuName)
        {
            m_GeneralMenu = new UnderMenu(i_PressedButton, i_MenuLevel, i_MenuName);
        }

        ////Properties:
        public UnderMenu GeneralMenu
        {
            get
            {
                return m_GeneralMenu;
            }

            set
            {
                m_GeneralMenu = value;
            }
        }

       
        public void show()
        {

            GeneralMenu.show();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private UnderMenu m_GeneralMenu;
        private const byte k_MenuLevel = 1;

        public MainMenu(string i_MenuName)
        {
            m_GeneralMenu = new UnderMenu(i_MenuName);
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

        public void AddItem(MenuItem newItem)
        {
            m_GeneralMenu.AddMenu(newItem);
        }

        public void Show()
        {

            GeneralMenu.Show(k_MenuLevel);
        }

    }
}

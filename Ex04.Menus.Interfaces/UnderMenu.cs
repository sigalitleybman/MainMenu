using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    class UnderMenu:MenuItem
    {
        
        private string m_LastPressedButton;
        private int m_CurrentLevel;
        private const int m_IndexBackOrExit = 0;
        private const string m_Back = "Back";
        private const string m_Exit = "Exit";
        Dictionary<int, MenuItem> m_MenuOptions;
        
        public UnderMenu(string i_LastPressedButton, int i_CurrentLevel, string i_MenuName):base(i_MenuName)
        {

        }
    }
}

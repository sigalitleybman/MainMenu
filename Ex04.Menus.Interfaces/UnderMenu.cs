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
        private Dictionary<int, MenuItem> m_MenuOptions;
        
        public UnderMenu(string i_LastPressedButton, int i_CurrentLevel, string i_MenuName):base(i_MenuName)
        {
            m_LastPressedButton = i_LastPressedButton;
            m_CurrentLevel = i_CurrentLevel;
            m_MenuOptions = new Dictionary<int, MenuItem>();
        }

        public void Show()
        {
            StringBuilder menuBody = new StringBuilder();
            string separateLine = new string('~', 20);
            string options = string.Empty;

            menuBody.Append("Level " + this.m_LastPressedButton + " - " + this.MenuName);
            menuBody.Append(Environment.NewLine);
            menuBody.Append(separateLine);
            foreach(KeyValuePair<int,MenuItem> menuOption in m_MenuOptions)
            {
                options = string.Format("{0}) {1}", menuOption.Key, menuOption.Value);
                menuBody.Append(options);
                menuBody.Append(Environment.NewLine);
            }

            Console.WriteLine(menuBody);
            //UserChoice()
        }
    }
}

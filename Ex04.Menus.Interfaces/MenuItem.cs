using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private string m_MenuName;

        public MenuItem(string i_MenuName)
        {
            m_MenuName = i_MenuName;
        }

        ////Properties:
       public string MenuName
        {
            get
            {
                return m_MenuName;
            }

            set
            {
                m_MenuName = value;
            }
        }
    }
}

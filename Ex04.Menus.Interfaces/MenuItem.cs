using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem//buttom
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

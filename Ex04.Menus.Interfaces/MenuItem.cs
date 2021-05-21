using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    class MenuItem//buttom
    {
        private string m_MenuName;

        internal MenuItem(string i_MenuName)
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

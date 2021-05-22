using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceUI
    {
        public void EntryPoint()
        {
            MainMenu menu = new MainMenu("Main Menu");
            UnderMenu spacesAndVersion = new UnderMenu("Spaces and Version");
            UnderMenu showDateAndTime = new UnderMenu("Show Date/Time");
            MenuItem version = new MenuItem("Show Version");
            MenuItem space = new MenuItem("Count Spaces");
            MenuItem time = new MenuItem("Show Time");
            MenuItem date = new MenuItem("Show Date");

            menu.AddItem(spacesAndVersion);
            menu.AddItem(showDateAndTime);
            spacesAndVersion.AddMenu(version);
            spacesAndVersion.AddMenu(space);
            showDateAndTime.AddMenu(time);
            showDateAndTime.AddMenu(date);
            
            menu.Show();
        }
    }
}

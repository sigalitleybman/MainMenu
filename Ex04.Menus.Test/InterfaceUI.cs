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
            ShowVersion version = new ShowVersion("Show Version");
            CountSpaces space = new CountSpaces("Count Spaces");
            ShowTime time = new ShowTime("Show Time");
            ShowDate date = new ShowDate("Show Date");

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

using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelegateUI
    {
        public void EntryPoint()
        {
            MainMenu menu = new MainMenu("Main Menu - Delegates");
            UnderMenu spacesAndVersion = new UnderMenu("Spaces and Version");
            UnderMenu showDateAndTime = new UnderMenu("Show Date/Time");
            Action version = new Action("Show Version");
            Action space = new Action("Count Spaces");
            Action time = new Action("Show Time");
            Action date = new Action("Show Date");

            menu.AddItem(spacesAndVersion);
            menu.AddItem(showDateAndTime);
            spacesAndVersion.AddMenu(version);
            spacesAndVersion.AddMenu(space);
            showDateAndTime.AddMenu(time);
            showDateAndTime.AddMenu(date);
            version.pickedChoice += ShowVersion.ShowVersionDelegate;
            space.pickedChoice += CountSpaces.CountSpacesDelegate;
            time.pickedChoice += ShowTime.ShowTimeDelegate;
            date.pickedChoice += ShowDate.ShowDateDelegate;
            menu.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class Action : MenuItem
    {
        public delegate void PickedChoiceHandler();

        public Action(string i_ItemName) : base(i_ItemName)
        {
        }

        public event PickedChoiceHandler pickedChoice;

        protected virtual void OnPickedChoice()
        {
            if (pickedChoice != null)
            {
                pickedChoice.Invoke();
            }
        }

        public void ExcutePickedChoice()
        {
            OnPickedChoice();
        }
    }
}
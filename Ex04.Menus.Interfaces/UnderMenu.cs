using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class UnderMenu : MenuItem
    {
        private byte m_CurrentLevel;
        private const byte k_IndexBackOrExit = 0;
        private const string k_Back = "Back";
        private const string k_Exit = "Exit";
        private Dictionary<byte, MenuItem> m_MenuOptions;
        private byte m_OptionNumber = 1;

        public UnderMenu(string i_MenuName) : base(i_MenuName)
        {
            m_MenuOptions = new Dictionary<byte, MenuItem>();
            m_MenuOptions.Add(0, null);
        }

        public void Show(byte i_CurerrentLevel)
        {
            StringBuilder menuBody = new StringBuilder();
            string separateLine = new string('~', 20);
            string options = string.Empty;
            byte choice = 1;

            m_CurrentLevel = i_CurerrentLevel;
            while (choice != k_IndexBackOrExit)
            {
                menuBody.Append(MenuName);
                menuBody.Append(Environment.NewLine);
                menuBody.Append(separateLine);
                menuBody.Append(Environment.NewLine);
                foreach (KeyValuePair<byte, MenuItem> menuOption in m_MenuOptions)
                {
                    if (menuOption.Key == 0)
                    {
                        options = BackOrExitTreatment(m_CurrentLevel);
                    }
                    else
                    {
                        options = String.Format("{0}) {1}", menuOption.Key, menuOption.Value.MenuName);
                    }

                    menuBody.Append(options);
                    menuBody.Append(Environment.NewLine);
                }

                Console.WriteLine(menuBody);
                menuBody.Remove(0, menuBody.Length);
                choice = UserChoice();
                Console.Clear();
                if (choice != 0)
                {
                    if (m_MenuOptions[choice] is UnderMenu)
                    {
                        byte nextLevel =(byte)(m_CurrentLevel+ 1);
                        (m_MenuOptions[choice] as UnderMenu).Show(nextLevel);
                    }
                    else if (m_MenuOptions[choice] is IRunnable)
                    {
                        ((IRunnable)m_MenuOptions[choice]).Run();
                    }
                }
            }
        }

        public string BackOrExitTreatment(byte i_CurrentLevel)
        {
            string backOrExit = string.Empty;

            if (i_CurrentLevel == 1)
            {
                backOrExit = string.Format("{0}) {1}", 0, k_Exit);
            }

            else
            {
                backOrExit = string.Format("{0}) {1}", 0, k_Back);
            }

            return backOrExit;
        }

        public byte UserChoice()
        {
            string choice = string.Empty;
            byte updatedChoice = 0;

            Console.WriteLine("Please enter your choice.");
            choice = Console.ReadLine();
            while (!byte.TryParse(choice, out updatedChoice) || (updatedChoice < 0 || updatedChoice > m_MenuOptions.Count - 1))
            {
                Console.WriteLine("You entered a wrong choice. Please try again.");
                choice = Console.ReadLine();
            }   

            return updatedChoice;
        }

        public void AddMenu(MenuItem i_NewItem)
        {
            m_MenuOptions.Add(m_OptionNumber, i_NewItem);
            m_OptionNumber++;
        }
    }
}

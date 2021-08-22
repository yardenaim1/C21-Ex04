using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{

    public class MenuItemInter : IMenu
    {
        private const int k_GoBack = 0;
        private readonly List<MenuItemInter> r_ItemsList = new List<MenuItemInter>();
        private readonly string r_Title;
        private string m_PrevItem = null;

        public MenuItemInter(string i_Title)
        {
            this.r_Title = i_Title;
        }

        void IMenu.OnItemChosen()
        {
            /// bla bla
        }

        private static int getChoiceFromUser(int i_MinNumber, int i_itemCount)
        {
            bool validInput;
            string msgToUser = string.Format(@"{0}Please select option ({1}-{2}):", Environment.NewLine, i_MinNumber, i_itemCount);

            Console.WriteLine(msgToUser);
            validInput = int.TryParse(Console.ReadLine(), out int inputNumber);

            while (!validInput || inputNumber > i_itemCount || inputNumber < i_MinNumber)
            {
                msgToUser = string.Format(@"Invalid input, please try again:({0}-{1})", i_MinNumber, i_itemCount);
                Console.WriteLine(msgToUser);
                validInput = int.TryParse(Console.ReadLine(), out inputNumber);
            }

            return inputNumber;
        }

        public void AddItem(MenuItemInter i_ItemToAdd)
        {
            r_ItemsList.Add(i_ItemToAdd);
            i_ItemToAdd.PrevItem = this.Title;
        }

        public void DisplayInnerMenu()
        {
            int itemCounter = 0;
            int userInput;

            do
            {
                Console.Clear();
                Console.WriteLine(Title);
                Console.WriteLine(string.Format(@"{0}){1}", itemCounter++, m_PrevItem == null ? "Exit" : "Back"));

                foreach (MenuItemInter item in r_ItemsList)
                {
                    Console.WriteLine(string.Format(@"{0}){1}", itemCounter++, item.Title));
                }

                userInput = getChoiceFromUser(k_GoBack, itemCounter - 1);

                if (userInput != k_GoBack)
                {
                    Console.Clear();
                    (this.r_ItemsList[userInput - 1] as IMenu).OnItemChosen();
                }

                itemCounter = 0;
            } while (userInput != k_GoBack);

            Console.Clear();
        }

        public string PrevItem
        {
            get
            {
                return this.r_Title;
            }
            set
            {
                this.m_PrevItem = value;
            }
        }

        public string Title
        {
            get
            {
                return this.r_Title;
            }
        }
    }
}

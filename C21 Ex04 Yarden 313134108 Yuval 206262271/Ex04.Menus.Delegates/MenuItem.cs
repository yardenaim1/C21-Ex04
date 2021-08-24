using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        private const int k_GoBack = 0;
        private readonly List<MenuItem> r_ItemsList = new List<MenuItem>();
        private readonly string r_Title;
        private string m_PrevItem;

        public event Action<MenuItem> ItemChosen;

        public string PrevItem
        {
            get
            {
                return this.m_PrevItem;
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

        public MenuItem(string i_Title)
        {
            this.r_Title = i_Title;
        }
        
        public void AddItem(MenuItem i_ItemToAdd)
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
                Console.WriteLine(String.Format(@"{0}){1}", itemCounter++, m_PrevItem == null ? "Exit" : "Back"));

                foreach (MenuItem item in r_ItemsList)
                {
                    Console.WriteLine(String.Format(@"{0}){1}", itemCounter++, item.Title));
                }

                userInput = getChoiceFromUser(k_GoBack, itemCounter - 1);

                if (userInput != k_GoBack)
                {
                    Console.Clear();
                    r_ItemsList[userInput - 1].OnItemChosen();
                }

                itemCounter = 0;
            }
            while (userInput != k_GoBack);

            Console.Clear();
        }

        private static int getChoiceFromUser(int i_MinNumber, int i_ItemCount)
        {
            bool validInput;
            string msgToUser = string.Format(@"{0}Please select option ({1}-{2}):", Environment.NewLine, i_MinNumber, i_ItemCount);

            Console.WriteLine(msgToUser);
            validInput = int.TryParse(Console.ReadLine(), out int inputNumber);

            while (!validInput || inputNumber > i_ItemCount || inputNumber < i_MinNumber)
            {
                msgToUser = string.Format(@"Invalid input, please try again:({0}-{1})", i_MinNumber, i_ItemCount);
                Console.WriteLine(msgToUser);
                validInput = int.TryParse(Console.ReadLine(), out inputNumber);
            }

            return inputNumber;
        }

        protected virtual void OnItemChosen()
        {
            if (ItemChosen != null)
            {
                ItemChosen.Invoke(this);
            }
        }
    }  
}

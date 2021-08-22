using System;

namespace Ex04.Menus.Interfaces
{
    public struct DisplayItem : IMenuItemOperation
    {
        public void DisplayInnerMenu(MenuItem i_MenuItem)
        {

            int goBack = 0;
            int itemCounter = 0;
            int userInput;

            do
            {
                Console.Clear();
                Console.WriteLine(i_MenuItem.Title);
                Console.WriteLine(string.Format(@"{0}){1}", itemCounter++, i_MenuItem.PrevItem == null ? "Exit" : "Back"));

                foreach (MenuItem item in i_MenuItem.ItemList)
                {
                    Console.WriteLine(string.Format(@"{0}){1}", itemCounter++, item.Title));
                }

                userInput = getChoiceFromUser(goBack, itemCounter - 1);

                if (userInput != goBack)
                {
                    Console.Clear();
                    i_MenuItem.ItemList[userInput - 1].ItemChosen();
                }

                itemCounter = 0;
            } while (userInput != goBack);

            Console.Clear();
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

        void IMenuItemOperation.OnItemChosen(MenuItem i_MenuItem)
        {
            DisplayInnerMenu(i_MenuItem);
        }
    }
}

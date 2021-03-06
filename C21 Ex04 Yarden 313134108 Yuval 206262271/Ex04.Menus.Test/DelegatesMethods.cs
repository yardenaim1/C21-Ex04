using System;
using System.Linq;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public static class DelegatesMethods 
    {
        public static void MenuItem_ItemChosen_CountSpaces(MenuItem i_MenuItem)
        {
            int spacesCount = 0;
            Console.WriteLine("Please enter a string to count its spaces and press 'enter':");
            string toCount = Console.ReadLine();
            if (toCount != null)
            {
                spacesCount = toCount.Count(i_Ch => i_Ch == ' ');
            }

            Console.WriteLine("There are {0} spaces.", spacesCount);
            Program.ContinueIfKeyPressed();
        }

        public static void MenuItem_ItemChosen_ShowVersion(MenuItem i_MenuItem)
        {
            Console.WriteLine("Version: 21.3.4.8933");
            Program.ContinueIfKeyPressed();
        }

        public static void MenuItem_ItemChosen_ShowTime(MenuItem i_MenuItem)
        {
            Console.WriteLine(
                    "The time is: {0}:{1}:{2}",
                    DateTime.Now.Hour,
                    DateTime.Now.Minute,
                    DateTime.Now.Second);
            Program.ContinueIfKeyPressed();
        }

        public static void MenuItem_ItemChosen_ShowDate(MenuItem i_MenuItem)
        {
            Console.WriteLine(
                "The date is: {0}/{1}/{2}",
                DateTime.Now.Day,
                DateTime.Now.Month,
                DateTime.Now.Year);
            Program.ContinueIfKeyPressed();
        }

        public static void MenuItem_ItemChosen_DisplayInnerMenu(MenuItem i_MenuItem)
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
                    i_MenuItem.ItemList[userInput - 1].ItemChosenFunc();
                }

                itemCounter = 0;
            }
            while (userInput != goBack);

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
    }
}

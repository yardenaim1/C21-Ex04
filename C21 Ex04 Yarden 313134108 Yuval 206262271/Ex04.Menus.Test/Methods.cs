using System;
using System.Linq;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountSpaces : IMenuItemOperation
    {
        private void countSpaces()
        {
            Console.WriteLine("Please enter a string to count its spaces and press 'enter':");
            string toCount = Console.ReadLine();
            int spacesCount = toCount.Count(x => x == ' ');
            Console.WriteLine("There are {0} spaces.", spacesCount);
        }

        public void OnItemChosen(MenuItem i_MenuItem)
        {
            countSpaces();
            MenuItem.ContinueIfKeyPressed();
        }
    }

    public struct ShowVersion : IMenuItemOperation
    {
        public void OnItemChosen(MenuItem i_MenuItem)
        {
            Console.WriteLine("Version: 21.3.4.8933");
            MenuItem.ContinueIfKeyPressed();
        }
    }

    public struct ShowTime : IMenuItemOperation
    {
        public void OnItemChosen(MenuItem i_MenuItem)
        {
            Console.WriteLine(
                    "The time is: {0}:{1}:{2}",
                    DateTime.Now.Hour,
                    DateTime.Now.Minute,
                    DateTime.Now.Second);
            MenuItem.ContinueIfKeyPressed();
        }
    }

    public struct ShowDate : IMenuItemOperation
    {
        public void OnItemChosen(MenuItem i_MenuItem)
        {
            Console.WriteLine(
                "The date is: {0}/{1}/{2}",
                DateTime.Now.Day,
                DateTime.Now.Month,
                DateTime.Now.Year);
            MenuItem.ContinueIfKeyPressed();
        }
    }
}

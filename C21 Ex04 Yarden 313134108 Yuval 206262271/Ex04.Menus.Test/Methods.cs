using System;
using System.Linq;

namespace Ex04.Menus.Test
{
    public static class Methods
    {
        public static void CountSpaces(Delegates.MenuItem menuItem)
        {
            Console.WriteLine("Please enter a string to count its spaces and press 'enter':");
            string toCount = Console.ReadLine();
            int spacesCount = toCount.Count(x => x == ' ');
            Console.WriteLine("There are {0} spaces.", spacesCount);
            continueIfKeyPressed();
        }

        public static void ShowVersion(Delegates.MenuItem menuItem)
        {
            Console.WriteLine(menuItem.Title);
            Console.WriteLine("Version: 21.3.4.8933");
            continueIfKeyPressed();
        }

        public static void ShowTime(Delegates.MenuItem menuItem)
        {
            Console.WriteLine(menuItem.Title);
            Console.WriteLine(
                    "The time is: {0}:{1}:{2}",
                    DateTime.Now.Hour,
                    DateTime.Now.Minute,
                    DateTime.Now.Second);
            continueIfKeyPressed();
        }

        public static void ShowDate(Delegates.MenuItem menuItem)
        {
            Console.WriteLine(menuItem.Title);
            Console.WriteLine(
              "The date is: {0}/{1}/{2}",
              DateTime.Now.Day,
              DateTime.Now.Month,
              DateTime.Now.Year);
            continueIfKeyPressed();
        }

        private static void continueIfKeyPressed()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}

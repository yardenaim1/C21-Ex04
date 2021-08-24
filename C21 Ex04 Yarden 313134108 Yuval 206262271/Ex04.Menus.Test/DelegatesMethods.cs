using System;
using System.Linq;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public static class DelegatesMethods 
    {
        public static void CountSpaces(MenuItem i_MenuItem)
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

        public static void ShowVersion(MenuItem i_MenuItem)
        {
            Console.WriteLine("Version: 21.3.4.8933");
            Program.ContinueIfKeyPressed();
        }

        public static void ShowTime(MenuItem i_MenuItem)
        {
            Console.WriteLine(
                    "The time is: {0}:{1}:{2}",
                    DateTime.Now.Hour,
                    DateTime.Now.Minute,
                    DateTime.Now.Second);
            Program.ContinueIfKeyPressed();
        }

        public static void ShowDate(MenuItem i_MenuItem)
        {
            Console.WriteLine(
                "The date is: {0}/{1}/{2}",
                DateTime.Now.Day,
                DateTime.Now.Month,
                DateTime.Now.Year);
            Program.ContinueIfKeyPressed();
        }
    }
}

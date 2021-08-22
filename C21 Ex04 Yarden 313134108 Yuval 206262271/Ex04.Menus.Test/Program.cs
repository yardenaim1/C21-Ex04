using System;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void main()
        {
            MenuDelegates();
        }

        public static void MenuDelegates()
        {
            Delegates.MainMenu mainMenu = new Delegates.MainMenu("Main Delegates");
            Delegates.MenuItem versionAndSpaces = new Delegates.MenuItem("Version And Spaces");
            Delegates.MenuItem dateAndTime = new Delegates.MenuItem("Show Data/Time");
            mainMenu.AddItem(versionAndSpaces);
            mainMenu.AddItem(dateAndTime);

            Delegates.MenuItem countSpaces = new Delegates.MenuItem("Count Spaces");
            Delegates.MenuItem showVersion = new Delegates.MenuItem("Show Version");
            versionAndSpaces.AddItem(countSpaces);
            versionAndSpaces.AddItem(showVersion);


            Delegates.MenuItem showTime = new Delegates.MenuItem("Show Time");
            Delegates.MenuItem showDate = new Delegates.MenuItem("Show Date");
            dateAndTime.AddItem(showDate);
            dateAndTime.AddItem(showTime);


          
        }

        public static void CountSpaces(Delegates.MenuItem i_menuItem)
        {
        }

        public static void ShowVersion()
        {
        }
    }

}

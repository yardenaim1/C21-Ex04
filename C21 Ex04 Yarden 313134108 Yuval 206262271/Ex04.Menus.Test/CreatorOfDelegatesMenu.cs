using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class CreatorOfDelegatesMenu
    {
        public static MainMenu CreateMenu()
        {
            MainMenu mainMenu = new MainMenu("Main Delegates");
            MenuItem versionAndSpaces = new MenuItem("Version And Spaces");
            MenuItem dateAndTime = new MenuItem("Show Date/Time");

            mainMenu.AddMenuItem(versionAndSpaces);
            mainMenu.AddMenuItem(dateAndTime);

            MenuItem countSpaces = new MenuItem("Count Spaces");
            MenuItem showVersion = new MenuItem("Show Version");

            MenuItem showTime = new MenuItem("Show Time");
            MenuItem showDate = new MenuItem("Show Date");

            countSpaces.ItemChosen += Methods.CountSpaces;
            showVersion.ItemChosen += Methods.ShowVersion;
            showTime.ItemChosen += Methods.ShowTime;
            showDate.ItemChosen += Methods.ShowDate;


            versionAndSpaces.AddItem(countSpaces);
            versionAndSpaces.AddItem(showVersion);

            dateAndTime.AddItem(showDate);
            dateAndTime.AddItem(showTime);

            return mainMenu;
        }
    }
}

using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public static class CreatorOfInterfacesMenu
    {
        public static MainMenuInter CreateMenu()
        {
            MainMenuInter mainMenu = new MainMenuInter("Main Delegates");
            MenuItemInter versionAndSpaces = new MenuItemInter("Version And Spaces");
            MenuItemInter dateAndTime = new MenuItemInter("Show Date/Time");

            mainMenu.AddItem(versionAndSpaces);
            mainMenu.AddItem(dateAndTime);

            MenuItemInter countSpaces = new MenuItemInter("Count Spaces");
            MenuItemInter showVersion = new MenuItemInter("Show Version");

            MenuItemInter showTime = new MenuItemInter("Show Time");
            MenuItemInter showDate = new MenuItemInter("Show Date");

            /*countSpaces.ItemChosen += Methods.CountSpaces;
            showVersion.ItemChosen += Methods.ShowVersion;
            showTime.ItemChosen += Methods.ShowTime;
            showDate.ItemChosen += Methods.ShowDate;*/
            

            versionAndSpaces.AddItem(countSpaces);
            versionAndSpaces.AddItem(showVersion);

            dateAndTime.AddItem(showDate);
            dateAndTime.AddItem(showTime);

            return mainMenu;
        }
    }
}

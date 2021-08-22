using System;
using Ex04.Menus;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            Delegates.MainMenu menuDelegates = CreatorOfDelegatesMenu.CreateMenu();
            menuDelegates.Show();
        }
    }
}

namespace Ex04.Menus.Interfaces
{
    public class MainMenuInter
    {
        private readonly MenuItemInter r_MainMenuItem;

        public MainMenuInter(string i_MenuTitle)
        {
            r_MainMenuItem = new MenuItemInter(i_MenuTitle);
        }

        public void AddItem(MenuItemInter i_ItemToAdd)
        {
            r_MainMenuItem.AddItem(i_ItemToAdd);
        }

        public void Show()
        {
            r_MainMenuItem.DisplayInnerMenu();
        }
    }
}

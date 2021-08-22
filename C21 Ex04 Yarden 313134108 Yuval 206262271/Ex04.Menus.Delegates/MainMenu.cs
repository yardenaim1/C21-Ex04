namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private readonly MenuItem r_MenuItemList;

        public MainMenu(string i_MenuTile)
        {
            MenuItem r_menuItemList = new MenuItem(i_MenuTile);
        }

        public void AddItem(MenuItem i_ItemToAdd)
        {
            r_MenuItemList.AddItem(i_ItemToAdd);
        }

        public void MenuItem_ShowMenu_OnItemClicked(MenuItem i_ItemWasClicked)
        {
            int const k_


        }
     
    }
}

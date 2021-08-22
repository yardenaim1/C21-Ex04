namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private readonly MenuItem r_MenuItemList;

        public MainMenu(string i_MenuTile)
        {
            r_MenuItemList = new MenuItem(i_MenuTile);
        }

        public void AddItem(MenuItem i_ItemToAdd)
        {
            r_MenuItemList.AddItem(i_ItemToAdd);
        }

        public void AddMenuItem(MenuItem i_ItemToAdd)
        {
            r_MenuItemList.AddItem(i_ItemToAdd);
            i_ItemToAdd.ItemChosen += MenuItem_ItemChosen;
        }

        private void MenuItem_ItemChosen(MenuItem i_MenuItem)
        {
            i_MenuItem.DisplayInnerMenu();
        }

        public void Show()
        {
            r_MenuItemList.DisplayInnerMenu();
        }
    }
}

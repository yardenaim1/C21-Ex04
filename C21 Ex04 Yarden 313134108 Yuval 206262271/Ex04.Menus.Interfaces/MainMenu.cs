namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly MenuItem r_MainMenuItem;

        public MainMenu(string i_MenuTitle)
        {
            r_MainMenuItem = new MenuItem(i_MenuTitle);
            r_MainMenuItem.itemOperation = new DisplayItem();
        }

        public void AddItem(MenuItem i_ItemToAdd)
        {
            r_MainMenuItem.AddItem(i_ItemToAdd);
        }

        public void AddMenuItem(MenuItem i_ItemToAdd)
        {
            r_MainMenuItem.AddItem(i_ItemToAdd);
            i_ItemToAdd.itemOperation = new DisplayItem();
        }

        public void Show()
        {
            r_MainMenuItem.ItemChosen();
        }
    }
}

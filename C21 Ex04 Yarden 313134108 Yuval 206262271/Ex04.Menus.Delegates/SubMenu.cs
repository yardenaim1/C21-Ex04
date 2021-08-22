namespace Ex04.Menus.Delegates
{
    using System.Collections.Generic;

    public class SubMenu : MenuItem
    {
        private const int k_GoBack = 0;
        private readonly List<MenuItem> r_ItemsList = null;

        public SubMenu(string i_Title) : base(i_Title)
        {
            this.r_ItemsList = new List<MenuItem>();
        }

        public override void OnChosen()
        {
            
        }
    }
}

namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        private readonly string r_Title;

        public MenuItem(string i_Title)
        {
            this.r_Title = i_Title;
        }

        public abstract void OnChosen();

        public string Title
        {
            get
            {
                return this.r_Title;
            }
        }
    }
}

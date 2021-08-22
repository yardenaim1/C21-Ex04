using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{

    public delegate void Action();

    public class MenuItem
    {
        private const int k_GoBack = 0;
        private readonly string r_Title;
        private readonly List<MenuItem> r_ItemsList = null;

        public event Action<MenuItem> ItemChosen;
        
        public string Title
        {
            get
            {
                return this.r_Title;
            }
        }
       
        public MenuItem(string i_Title)
        {
            this.r_Title = i_Title;
        }

        public void AddItem(MenuItem i_ItemToAdd)
        {
            r_ItemsList.Add(i_ItemToAdd);
        }

        protected virtual void OnItemChosen()
        {
            if(ItemChosen != null)
            {
                ItemChosen.Invoke(this);
            }
        }

    }
}

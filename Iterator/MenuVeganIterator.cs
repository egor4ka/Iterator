using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class MenuVeganIterator : IIterator<MenuItem>
    {
        private List<MenuItem> menuItems;
        private int position;

        public MenuVeganIterator(List<MenuItem> items)
        {
            menuItems = items;
            position = 0;
        }

        public bool HasNext()
        {
            while (position < menuItems.Count && !menuItems[position].IsVegan)
            {
                position++;
            }
            return position < menuItems.Count;
        }

        public MenuItem Next()
        {
            if (HasNext())
            {
                return menuItems[position++];
            }
            else
            {
                throw new InvalidOperationException("Больше нет веганских блюд");
            }
        }
    }
}

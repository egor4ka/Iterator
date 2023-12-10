using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class MenuArrayIterator : IIterator<MenuItem>
    {
        private MenuItem[] menuItems;
        private int position;

        public MenuArrayIterator(MenuItem[] items)
        {
            menuItems = items;
            position = 0;
        }

        public bool HasNext()
        {
            return position < menuItems.Length;
        }

        public MenuItem Next()
        {
            if (HasNext())
            {
                return menuItems[position++];
            }
            else
            {
                throw new InvalidOperationException("No more elements");
            }
        }
    }
}

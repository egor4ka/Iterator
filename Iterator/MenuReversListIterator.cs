using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class MenuReverseListIterator : IIterator<MenuItem>
    {
        private List<MenuItem> menuItems;
        private int position;

        public MenuReverseListIterator(List<MenuItem> items)
        {
            menuItems = items;
            position = items.Count - 1;
        }

        public bool HasNext()
        {
            return position >= 0;
        }

        public MenuItem Next()
        {
            if (HasNext())
            {
                return menuItems[position--];
            }
            else
            {
                throw new InvalidOperationException("Больше нет блюд");
            }
        }
    }

}

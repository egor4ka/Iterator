using Iterator;
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        MenuItem[] menuItemsArray = {
            new MenuItem("Салат", true),
            new MenuItem("Стейк", false),
            new MenuItem("Веганский Бургер", true),
            new MenuItem("Мороженое", false)
        };

        List<MenuItem> menuItemsList = new List<MenuItem>(menuItemsArray);

        IIterator<MenuItem> arrayIterator = new MenuArrayIterator(menuItemsArray);
        IIterator<MenuItem> reverseListIterator = new MenuReverseListIterator(menuItemsList);
        IIterator<MenuItem> veganIterator = new MenuVeganIterator(menuItemsList);

        Console.WriteLine("Меню :");
        PrintMenu(arrayIterator);

        Console.WriteLine("\nОбратное меню:");
        PrintMenu(reverseListIterator);

        Console.WriteLine("\nВеганское меню :");
        PrintMenu(veganIterator);
    }

    static void PrintMenu(IIterator<MenuItem> iterator)
    {
        while (iterator.HasNext())
        {
            MenuItem menuItem = iterator.Next();
            Console.WriteLine($"{menuItem.Name} (Веганское: {menuItem.IsVegan})");
        }
    }
}

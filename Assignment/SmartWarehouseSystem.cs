/*using System;
using System.Diagnostics;
using System.Xml.Linq;

abstract class WareHouseItem
{
    public abstract string Name { get; set; }
    public abstract double Price { get; set; }
    public abstract void DisplayItem();
}

class Electronics : WareHouseItem
{
    public override string Name { get; set; }
    public override double Price { get; set; }
    public override void DisplayItem()
    {
        Console.WriteLine($"[Electronics] Name: {Name}, Price: ${Price}");
    }

}


class Groceries : WareHouseItem
{
    public override string Name { get; set; }
    public override double Price { get; set; }
    public override void DisplayItem()
    {
        Console.WriteLine($"[Groceries] Name: {Name}, Price: ${Price}");
    }

}


class Furniture : WareHouseItem
{
    public override string Name { get; set; }
    public override double Price { get; set; }
    public override void DisplayItem()
    {
        Console.WriteLine($"[Furniture] Name: {Name}, Price: ${Price}");
    }

}

class Storage<T> where T :WareHouseItem
{
    List<T> items = new List<T>();

    public void AddItem( T item)
    {
        items.Add( item );
    }

    public void DisplayAllItems()
    {
        Console.WriteLine("\nItems in Storage:");
        foreach (var item in items)
        {
            item.DisplayItem();
        }
    }
}

class Program1
{
    static void Main()
    {
        //Storage for Electronics
        Storage<Electronics> electronisStorage = new Storage<Electronics>();
        electronisStorage.AddItem(new Electronics { Name = "Tablet", Price = 50000 });
        electronisStorage.AddItem(new Electronics { Name = "Laptop", Price = 15000  });
        electronisStorage.DisplayAllItems();

        //Storage for Groceries
        Storage<Groceries> groceriesStorage = new Storage<Groceries>();
        groceriesStorage.AddItem(new Groceries { Name = "Cake", Price = 300 });
        groceriesStorage.AddItem(new Groceries { Name = "Wheat", Price = 1000 });
        groceriesStorage.DisplayAllItems();

        // Storage for Furniture
        Storage<Furniture> furnitureStorage = new Storage<Furniture>();
        furnitureStorage.AddItem(new Furniture { Name = "Chair", Price = 120 });
        furnitureStorage.AddItem(new Furniture { Name = "Table", Price = 300 });
        furnitureStorage.DisplayAllItems();
    }
}
*/
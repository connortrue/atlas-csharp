using System;
using InventoryLibrary;
using System.Collections.Generic;

public class Item : BaseClass
{
    public string name { get; set; }
    public string description { get; set; }
    public float price { get; set; }
    public List<string> tags { get; set; }

    public Item()
    {
        price = (float)Math.Round(price, 2);
    }
}

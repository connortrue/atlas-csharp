using InventoryLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class JSONStorage
{
    private Dictionary<string, object> objects = new Dictionary<string, object>();

    public Dictionary<string, object> All()
    {
        return objects;
    }

    public void New(object obj)
    {
        string key = $"{obj.GetType().Name}.{((BaseClass)obj).id}";
        objects[key] = obj;
    }

    public void Save()
    {
        string json = JsonSerializer.Serialize(objects);
        File.WriteAllText(@"storage\inventory_manager.json", json);
    }

    public void Load()
    {
        if (!File.Exists(@"storage\inventory_manager.json"))
            return;

        string json = File.ReadAllText(@"storage\inventory_manager.json");
        objects = JsonSerializer.Deserialize<Dictionary<string, object>>(json);
    }
}

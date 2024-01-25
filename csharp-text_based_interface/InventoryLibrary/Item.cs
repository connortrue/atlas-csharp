public class Item : BaseClass
{
    public string name { get; set; }
    public string description { get; set; }
    public float price { get; set; }
    public List<string> tags { get; set; }

    public Item()
    {
        price = Math.Round(price, 2); // Limit to 2 decimal points
    }
}

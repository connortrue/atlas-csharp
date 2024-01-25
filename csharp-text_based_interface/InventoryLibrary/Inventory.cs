public class Inventory : BaseClass
{
    public string user_id { get; set; }
    public string item_id { get; set; }
    public int quantity { get; set; } = 1;

    public Inventory()
    {
        if (quantity < 0)
            throw new ArgumentOutOfRangeException("Quantity cannot be less than 0");
    }
}

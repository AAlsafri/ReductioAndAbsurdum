public class Product()
{
    public string Name {get; set;}
    public decimal Price {get; set;}
    public bool Sold {get; set;}
    public int ProductTypeId {get; set;}
    public DateTime DateStocked {get; set;}
    public int DaysOnShelf
    {
        get
        {
            TimeSpan TimeOnShelf = DateTime.Now - DateStocked;
            return TimeOnShelf.Days;
        }
    }

    public override string ToString()
    {
        return $"Name: {Name}, Price: {Price}, Sold: {(Sold ? "Yes" : "No")}, Days on Shelf: {DaysOnShelf}";
    }
}
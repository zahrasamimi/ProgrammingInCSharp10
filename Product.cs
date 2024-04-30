using BaseBackend.ProgrammingInCSharp10.Contracts;

namespace BaseBackend.ProgrammingInCSharp10.Models;

public class Product : BaseEntity
{
    public Product()
    {

    }

    public Product(string name, string brandName, decimal price, int count) : base(false, 1, 1000)
    {
        Name = name;
        BrandName = brandName;
        Price = price;
        Count = count;
    }

    public string Name { get; set; }
    public string BrandName { get; set; }
    public decimal Price { get; set; }
    public int Count { get; set; }

    public override bool IsActivateItem()
    {
        throw new NotImplementedException();
    }
}

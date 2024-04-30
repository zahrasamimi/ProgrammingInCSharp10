using BaseBackend.ProgrammingInCSharp10.Contracts;

namespace BaseBackend.ProgrammingInCSharp10.Models;

public class OrderItem : BaseEntity
{
    //public Order Order { get; set; }
    public int OrderId { get; set; }
    public decimal CurrentPrice { get; set; }
    //public Product Product { get; set; }
    public int ProductId { get; set; }
    public int Count { get; set; }
    public override bool IsActivateItem()
    {
        throw new NotImplementedException();
    }
}

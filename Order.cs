using BaseBackend.ProgrammingInCSharp10.Contracts;

namespace BaseBackend.ProgrammingInCSharp10.Models;

public class Order : BaseEntity
{
    public string? Code { get; set; }
    public DateTime OrderDate { get; set; }
    public int AddressId { get; set; }
    public int CustomerId { get; set; }
    //public List<OrderItem> OrderItems { get; set; }
    public override bool IsActivateItem()
    {
        throw new NotImplementedException();
    }
}

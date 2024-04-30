using BaseBackend.ProgrammingInCSharp10.Contracts;

namespace BaseBackend.ProgrammingInCSharp10.Models;

public class Address : BaseEntity
{
    //public Customer Customer { get; set; }
    public int CustomerId { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string Pelak { get; set; }

    public override bool IsActivateItem()
    {
        throw new NotImplementedException();
    }
}

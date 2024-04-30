using BaseBackend.ProgrammingInCSharp10.Contracts;
using BaseBackend.ProgrammingInCSharp10.Models;
using System.Configuration;

namespace BaseBackend.ProgrammingInCSharp10.Repositories;

public class OrderRespository : IGenericRepository<Order>
{
    private readonly string connectionString = ConfigurationManager.ConnectionStrings["ShoppingSystem"].ToString();

    public bool AddItem(Order item)
    {
        throw new NotImplementedException();
    }

    public bool DeleteItem(int id)
    {
        throw new NotImplementedException();
    }

    public List<Order> GetAll()
    {
        throw new NotImplementedException();
    }

    public Order GetById(object id)
    {
        throw new NotImplementedException();
    }

    public bool UpdateItem(Order item)
    {
        throw new NotImplementedException();
    }
}

using BaseBackend.ProgrammingInCSharp10.Contracts;
using BaseBackend.ProgrammingInCSharp10.Models;
using System.Configuration;

namespace BaseBackend.ProgrammingInCSharp10.Repositories
{
    public class AddressRepository : IGenericRepository<Address>
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ShoppingSystem"].ToString();

        public bool DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        bool IGenericRepository<Address>.AddItem(Address item)
        {
            throw new NotImplementedException();
        }

        bool IGenericRepository<Address>.DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        List<Address> IGenericRepository<Address>.GetAll()
        {
            throw new NotImplementedException();
        }

        Address IGenericRepository<Address>.GetById(object id)
        {
            throw new NotImplementedException();
        }

        bool IGenericRepository<Address>.UpdateItem(Address item)
        {
            throw new NotImplementedException();
        }
    }
}

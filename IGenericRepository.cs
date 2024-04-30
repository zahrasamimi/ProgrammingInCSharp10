namespace BaseBackend.ProgrammingInCSharp10.Contracts;

public interface IGenericRepository<T> where T : class
{
    T GetById(object id);
    List<T> GetAll();
    bool AddItem(T item);
    bool UpdateItem(T item);
    bool DeleteItem(int id);
}

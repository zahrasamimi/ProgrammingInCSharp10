using BaseBackend.ProgrammingInCSharp10.Contracts;
using BaseBackend.ProgrammingInCSharp10.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace BaseBackend.ProgrammingInCSharp10.Repositories;

public class ProductRepository : IGenericRepository<Product>
{
    private readonly string connectionString = ConfigurationManager.ConnectionStrings["ShoppingSystem"].ToString();

    public ProductRepository()
    {
    }

    public bool AddItem(Product item)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                // Create a SQL command to insert a new person record
                string query = $"INSERT INTO dbo.Product ([Name],[Price],[Count]) " +
                               "VALUES (@Name,@Price,@Count)";
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to the SQL command
                command.Parameters.AddWithValue("@Name", item.Name);
                command.Parameters.AddWithValue("@Price", item.Price);
                command.Parameters.AddWithValue("@Count", item.Count);

                // Execute the insert query
                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }

    public bool DeleteItem(int id)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                // Create a SQL command to insert a new person record
                string query = $"delete dbo.Product where Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to the SQL command
                command.Parameters.AddWithValue("@Id", id);

                // Execute the insert query
                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }

    public List<Product> GetAll()
    {

        List<Product> products = new List<Product>();

        // Replace "YourTableName" with the actual name of the table you want to query
        string tableName = "dbo.Product";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                // Create a SQL command to select data from the table
                string query = $"SELECT * FROM {tableName}";
                SqlCommand command = new SqlCommand(query, connection);

                // Create a data reader to fetch the data
                SqlDataReader reader = command.ExecuteReader();

                // Read data and map it to Person objects
                while (reader.Read())
                {
                    Product product = new Product
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        BrandName = reader["BrandName"] != DBNull.Value ? reader["BrandName"].ToString(): String.Empty,
                        Count = (int)reader["Count"],
                        IsActive = (bool)reader["IsActive"],
                        Price = (decimal)reader["Price"],
                        CreationDate = (DateTime)reader["CreationDate"],
                    };

                    products.Add(product);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();

            }
            return products;
        }
    }

    public Product GetById(object id)
    {
        Product customer = null;
        // Replace "YourTableName" with the actual name of the table you want to query
        string tableName = "dbo.Product";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                // Create a SQL command to select data from the table
                string query = $"SELECT * FROM {tableName} Where Id =  @Id";
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to the SQL command
                command.Parameters.AddWithValue("@Id", id);

                // Create a data reader to fetch the data
                SqlDataReader reader = command.ExecuteReader();

                // Read data and map it to Person objects
                if (reader.Read())
                {
                    customer = new Product
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"].ToString(),
                        Count = (int)reader["Name"],
                        BrandName = reader["BrandName"] != DBNull.Value ? reader["BrandName"].ToString() : null,
                        Price = (decimal)reader["Price"],
                        IsActive = (bool)reader["IsActive"],
                        CreationDate = (DateTime)reader["CreationDate"],
                    };
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();

            }
            return customer;
        }
    }

    public bool UpdateItem(Product item)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                // Create a SQL command to insert a new person record
                string query = $"UPDATE dbo.Product " +
                    $"SET [Name] = @Name," +
                    $"[Price] = @Price," +
                    $"[Count] = @Count,"+
                    $" WHERE Id = @Id ";
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to the SQL command
                command.Parameters.AddWithValue("@Id", item.Id);
                command.Parameters.AddWithValue("@Name", item.Name);
                command.Parameters.AddWithValue("@Price", item.Price);
                command.Parameters.AddWithValue("@Count", item.Count);

                // Execute the insert query
                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

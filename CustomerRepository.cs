using BaseBackend.ProgrammingInCSharp10.Contracts;
using BaseBackend.ProgrammingInCSharp10.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace BaseBackend.ProgrammingInCSharp10.Repositories;

public class CustomerRepository : IGenericRepository<Customer>
{
    private readonly string connectionString = ConfigurationManager.ConnectionStrings["ShoppingSystem"].ToString();

    public CustomerRepository()
    {
    }

    public bool AddItem(Customer item)
    {
        //Connect To DB
        //InSert INto
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                // Create a SQL command to insert a new person record
                string query = $"INSERT INTO dbo.Customer (Username,[Password],[FirstName],[LastName],[Email],[PhoneNumber],[GenderId]) " +
                               "VALUES (@Username,@Password,@FirstName, @LastName,@Email,@PhoneNumber,@GenderId)";
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to the SQL command
                command.Parameters.AddWithValue("@Username", item.Username);
                command.Parameters.AddWithValue("@Password", item.Password);
                command.Parameters.AddWithValue("@FirstName", item.FirstName);
                command.Parameters.AddWithValue("@LastName", item.LastName);
                command.Parameters.AddWithValue("@Email", item.Email);
                command.Parameters.AddWithValue("@PhoneNumber", item.PhoneNumber);
                command.Parameters.AddWithValue("@GenderId", (short)item.Gender);

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
                string query = $"delete dbo.Customer where Id = @Id";
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

    public List<Customer> GetAll()
    {
        List<Customer> customers = new List<Customer>();

        // Replace "YourTableName" with the actual name of the table you want to query
        string tableName = "dbo.Customer";
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
                    Customer customer = new Customer
                    {
                        Id = (int)reader["Id"],
                        BirthDate = reader["BirthDate"] != DBNull.Value ? (DateTime)reader["BirthDate"] : null,
                        IsValidEmail = (bool)reader["IsValidEmail"],
                        IsValidPhoneNumber = (bool)reader["IsValidPhoneNumber"],
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString(),
                        Email = reader["Email"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        IsActive = (bool)reader["IsActive"],
                        CreationDate = (DateTime)reader["CreationDate"],
                    };

                    customers.Add(customer);
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
            return customers;
        }
    }

    public Customer GetById(object id)
    {
        Customer customer = null;
        // Replace "YourTableName" with the actual name of the table you want to query
        string tableName = "dbo.Customer";
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
                    customer = new Customer
                    {
                        Id = (int)reader["Id"],
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        BirthDate = reader["BirthDate"] != DBNull.Value ? (DateTime)reader["BirthDate"] : null,
                        IsValidEmail = (bool)reader["IsValidEmail"],
                        IsValidPhoneNumber = (bool)reader["IsValidPhoneNumber"],
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString(),
                        Email = reader["Email"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
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

    public bool UpdateItem(Customer item)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                // Create a SQL command to insert a new person record
                string query = $"UPDATE dbo.Customer " +
                    $"SET FirstName = @FirstName," +
                    $"LastName = @LastName," +
                    $"Email=@Email," +
                    $"PhoneNumber = @PhoneNumber," +
                    $"GenderId = @GenderId" +
                    $" WHERE Id = @Id ";
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to the SQL command
                command.Parameters.AddWithValue("@Id", item.Id);
                command.Parameters.AddWithValue("@FirstName", item.FirstName);
                command.Parameters.AddWithValue("@LastName", item.LastName);
                command.Parameters.AddWithValue("@Email", item.Email);
                command.Parameters.AddWithValue("@PhoneNumber", item.PhoneNumber);
                command.Parameters.AddWithValue("@GenderId", (short)item.Gender);

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

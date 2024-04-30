using BaseBackend.ProgrammingInCSharp10.Contracts;
using BaseBackend.ProgrammingInCSharp10.Enums;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.Serialization;

namespace BaseBackend.ProgrammingInCSharp10.Models;

public class Customer : User
{
    public Customer()
    {

    }

    public Customer(string phoneNumber,string firstName,string lastName,string email,Gender gender,string username,string password)
    {
        PhoneNumber = phoneNumber;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Gender = gender;
        Username = username;
        Password = password;
    }

    public string Email { get; set; }
    public string PersianBirthDate
    {
        get
        {
            if (BirthDate is not null)
            {
                string persianD = BirthDate?.ToString("yyyy/mm/dd", new CultureInfo("fa-IR"));
                return persianD;
            }
            else
            {
                return null;
            }
            
        }
    }
    
    public string PhoneNumber { get; set; }
    public bool IsValidPhoneNumber { get; set; }
    public bool IsValidEmail { get; set; }
}

using BaseBackend.ProgrammingInCSharp10.Contracts;
using BaseBackend.ProgrammingInCSharp10.Enums;

namespace BaseBackend.ProgrammingInCSharp10.Models;

public class User: BaseEntity
{
    public Gender Gender { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime? BirthDate { get; set; }
    public string FullName { get {
            return $"{FirstName} {LastName}";
        } 
    }

    public override bool IsActivateItem()
    {
        if (BirthDate is not null) { 
            if (BirthDate < DateTime.Now)
                return true;
            else
                return false;
        }
        else
        {
            return false;
        }
    }
}

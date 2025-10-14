

using System.Collections.Generic;
using System.Runtime;
using HealthCareSystem;

namespace HealthCareSystem
{


  public interface IUser

  {
    // Interface för samtliga användare: Patient, Admin och Personal - alla användare behöver ha Email och TryLogin

    public bool TryLogin(string email, string password);
    public string Email { get; }


  }

}


public class User : IUser

{
  public string Email { get; private set; }
  private string _password;

  public User(string email, string password, Role role)
  {
    Email = email;
    _password = password;
    _role = role;

  }

  public bool TryLogin(string email, string password)
  {
    return Email == email && _password == password;
  }

  private Role _role;
  public enum Role // ska definera användarens roll.
  {
    Personnel,
    Admin,
    Patient,

  }
  public Role GetRole() // Returnerar användares roll, i detta fall personal, admin, och patient.
  {
    return _role;


  }
}


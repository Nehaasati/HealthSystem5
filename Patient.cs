using System;

namespace HealthSystem;

class Patient :IUser
{
    // fields (no get/set)
    public string FullName;
    public string PersonalNumber;
    public string Email;
    public string Phone;
    public string Username;
    public string Password;

    public Patient()
    {
        FullName = "";
        PersonalNumber = "";
        Email = "";
        Phone = "";
        Username = "";
        Password = "";
    }
       public bool TryLogin(string username, string password)
    {
        return Username == username && Password == password;
    }

    public bool IsRole(Role role)
    {
        return role == Role.Patient;
    }

    public Role GetRole()
    {
        return Role.Patient;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {FullName}");
        Console.WriteLine($"Personal Number: {PersonalNumber}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Phone: {Phone}");
    }
}



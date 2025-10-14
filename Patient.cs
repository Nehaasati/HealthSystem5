using System;

namespace HealthSystem;

class Patient 
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
}
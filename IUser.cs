namespace HealthSystem;

interface IUser
{
    bool TryLogin(string username, string password);
    bool IsRole(Role role);
    Role GetRole();
}

enum Role
{
    None,
    Personal,
    Patient,
    Admin,
}
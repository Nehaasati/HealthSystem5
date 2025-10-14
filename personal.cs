//view paintent journal enteries
//Registration
// approve appointment
namespace Healthcaresystem
{
    public class Personal
    {
        public string Username;
        private string _password;
        public string FullName;

        public Personal(string username, string password, string fullName)
        {
            Username = username;
            _password = password;
            FullName = fullName;
        }

        public bool TryLogin(string username, string password)
        {
            return username == Username && password == _password;
        }

        public Role GetRole()
        {
            return Role.Personal;
        }
    }

    public enum Role
    {
        Guest,
        User,
        Personal
    }
}
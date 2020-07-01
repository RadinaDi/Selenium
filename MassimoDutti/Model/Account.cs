using MassimoDutti.Model.Enums;

namespace MassimoDutti.Model
{
    public class Account
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Gender Gender { get; set; }
    }
}

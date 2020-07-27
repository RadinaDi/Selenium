using AbvBg.Model.Enums;
using System;

namespace AbvBg.Model
{
    public class Account
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string User { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        public bool AntiSpam { get; set; }
    }
}

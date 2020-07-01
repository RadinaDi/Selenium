using MassimoDutti.Extensions;
using MassimoDutti.Model;
using MassimoDutti.Model.Enums;
using System;

namespace MassimoDutti.Data
{
    public static class AccountData
    {
        private static Random random = new Random();

        public static Account NewAccount()
        {
            return new Account()
            {
                Email = random.NextEmail(),
                Password = random.NextString(maxLength: 256),
                FirstName = random.NextString(maxLength: 256),
                LastName = random.NextString(maxLength: 256),
                Gender = (Gender)random.Next(1, 2),
            };
        }

        public static Account WithFirstName(this Account account, string firstName)
        {
            account.FirstName = firstName;
            return account;
        }

        public static Account WithLastName(this Account account, string lastName)
        {
            account.LastName = lastName;
            return account;
        }

        public static Account WithEmail(this Account account, string email)
        {
            account.Email = email;
            return account;
        }

        public static Account WithPassword(this Account account, string password)
        {
            account.Password = password;
            return account;
        }

        private static string NextEmail(this Random random)
        {
            int num = random.Next(99999);
            return $"username{num:D5}@gmail.com";
        }
    }
}

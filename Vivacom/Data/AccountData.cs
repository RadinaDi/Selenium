using System;
using Vivacom.Extensions;
using Vivacom.Model;

namespace Vivacom.Data
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
            };
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

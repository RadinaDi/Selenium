using AbvBg.Extentions;
using AbvBg.Model;
using AbvBg.Model.Enums;
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
                AntiSpam = random.NextBool(),
                User = random.NextString(maxLength: 256),
                PhoneNumber = random.NextString(maxLength: 9),
                BirthDate = random.NextBirthDate(),
            };
        }

        public static Account WithAntiSpam(this Account account, bool isChecked)
        {
            account.AntiSpam = isChecked;
            return account;
        }

        public static Account WithUser(this Account account, string user)
        {
            account.User = user;
            return account;
        }

        public static Account WithPhoneNumber(this Account account, string phoneNumber)
        {
            account.PhoneNumber = phoneNumber;
            return account;
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

        private static DateTime NextBirthDate(this Random random)
        {
            int day = random.Next(1, 28);
            int month = random.Next(1, 12);
            int year = random.Next(1920, 2006);

            return new DateTime(year, month, day);
        }
    }
}

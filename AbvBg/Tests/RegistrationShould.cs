using AbvBg.Pages.HomePage;
using AbvBg.Pages.RegistrationPage;
using MassimoDutti.Data;
using Xunit;

namespace AbvBg.Tests
{
    public class RegistrationShould : BaseTest
    {
        [Fact]
        public void BeOpenSuccessfully()
        {
            var registrationPage = this.OpenRegistrationPage();
            registrationPage.AssertRegistration();
        }

        [Theory]
        [InlineData("Моля попълнете полето Име", "")]

        public void ValidateFirstName(string error, string firstName)
        {
            var account = AccountData.NewAccount().WithFirstName(firstName);
            var registrationPage = this.OpenRegistrationPage();
            registrationPage.RegisterWith(account);
            registrationPage.AssertFirstNameValidation(error);
        }

        [Theory]
        [InlineData("Моля попълнете полето Фамилия", "")]

        public void ValidateLastName(string error, string lastName)
        {
            var account = AccountData.NewAccount().WithFirstName(lastName);
            var registrationPage = this.OpenRegistrationPage();
            registrationPage.RegisterWith(account);
            registrationPage.AssertLastNameValidation(error);
        }

        [Theory]
        [InlineData("Моля попълнете полето Телефон", "")]

        public void ValidatePhoneNumber(string error, string phoneNumber)
        {
            var account = AccountData.NewAccount().WithPhoneNumber(phoneNumber);
            var registrationPage = this.OpenRegistrationPage();
            registrationPage.RegisterWith(account);
            registrationPage.AssertPhoneNumberValidation(error);
        }

        [Theory]
        [InlineData("Моля попълнете полето АБВ потребител", "")]

        public void ValidateUser(string error, string user)
        {
            var account = AccountData.NewAccount().WithUser(user);
            var registrationPage = this.OpenRegistrationPage();
            registrationPage.RegisterWith(account);
            registrationPage.AssertUserValidation(error);
        }

        [Theory]
        [InlineData("Моля попълнете полето Парола", "")]

        public void ValidatePassword(string error, string password)
        {
            var account = AccountData.NewAccount().WithPassword(password);
            var registrationPage = this.OpenRegistrationPage();
            registrationPage.RegisterWith(account);
            registrationPage.AssertPasswordValidation(error);
        }

        [Theory]
        [InlineData("Моля попълнете полето Повтори парола", "")]

        public void ValidateConfirmPassword(string error, string password2)
        {
            var account = AccountData.NewAccount().WithPassword(password2);
            var registrationPage = this.OpenRegistrationPage();
            registrationPage.RegisterWith(account);
            registrationPage.AssertConfirmPasswordValidation(error);
        }

        [Theory]
        [InlineData("Моля попълнете полето Антиспам верификация", false)]

        public void ValidateAntiSpam(string error, bool isChecked)
        {
            var account = AccountData.NewAccount().WithAntiSpam(isChecked);
            var registrationPage = this.OpenRegistrationPage();
            registrationPage.RegisterWith(account);
            registrationPage.AssertAntiSpamValidation(error);
        }

        private RegistrationPage OpenRegistrationPage()
        {
            var homePage = new HomePage(this.Driver);
            homePage.OpenSite();
            homePage.RegistrationLink.Click();

            var registrationPage = new RegistrationPage(this.Driver);
            registrationPage.RegisterButton.Click();

            return new RegistrationPage(this.Driver);
        }
    }
}

using MassimoDutti.Data;
using MassimoDutti.Pages.HomePage;
using MassimoDutti.Pages.RegistrationPage;
using MassimoDutti.Pages.SignInPage;
using Xunit;

namespace MassimoDutti.Tests
{
    public class RegistrationShould : BaseTest
    {
        [Fact]
        public void BeOpenSuccessfully()
        {
            var registrationPage = this.OpenRegistrationPage();
            registrationPage.AssertHeader();
        }

        [Theory]
        [InlineData("Това поле е задължително", "")]

        public void ValidateFirstName(string error, string firstName)
        {
            var account = AccountData.NewAccount().WithFirstName(firstName);
            var registrationPage = this.OpenRegistrationPage();
            registrationPage.RegisterWith(account);
            registrationPage.AssertFirstNameValidation(error);
        }

        [Theory]
        [InlineData("Това поле е задължително", "")]
        public void ValidateLastName(string error, string lasstName)
        {
            var account = AccountData.NewAccount().WithLastName(lasstName);
            var registrationPage = this.OpenRegistrationPage();
            registrationPage.RegisterWith(account);
            registrationPage.AssertLastNameValidation(error);
        }

        [Theory]
        [InlineData("Това поле е задължително", "")]
        [InlineData("Моля, въведете валиден имейл адрес", "abcdefg")]
        public void ValidateEmail(string error, string email)
        {
            var account = AccountData.NewAccount().WithEmail(email);
            var registrationPage = this.OpenRegistrationPage();
            registrationPage.RegisterWith(account);
            registrationPage.AssertEmailValidation(error);
        }

        private RegistrationPage OpenRegistrationPage()
        {
            var homePage = new HomePage(this.Driver);
            homePage.OpenSite();
            homePage.SignInLink.Click();

            var signInPage = new SignInPage(this.Driver);
            signInPage.RegistrationButton.Click();

            return new RegistrationPage(this.Driver);
        }
    }
}

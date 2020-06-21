using Xunit;
using Zalando.Pages.HomePage;
using Zalando.Pages.RegistrationPage;

namespace Zalando.Tests
{
    public class RegistrationShould : BaseTest
    {
        [Fact]
        public void BeOpenSuccessfully()
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.NavigateToRegistrationPage();

            var registrationPage = new RegistrationPage(this.Driver);
            registrationPage.AssertHeader();
        }

        [Theory]
        [InlineData("This field is required", "")]
        [InlineData("Entry is too long.", "iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii")]
        public void ValidateFirstName(string error, string firstName)
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.NavigateToRegistrationPage();

            var registrationPage = new RegistrationPage(this.Driver);
            registrationPage.FirstNameField.SendKeys(firstName);
            registrationPage.RegisterButton.Click();
            registrationPage.AsserFirstNameValidationError(error);
        }

        [Theory]
        [InlineData("This field is required", "")]
        [InlineData("Entry is too long.", "iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii")]
        public void ValidateLastName(string error, string lastName)
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.NavigateToRegistrationPage();

            var registrationPage = new RegistrationPage(this.Driver);
            registrationPage.LastNameField.SendKeys(lastName);
            registrationPage.RegisterButton.Click();
            registrationPage.AssertLastNameValidationError(error);
        }

        [Theory]
        [InlineData("This field is required", "")]
        [InlineData("Please enter a valid email address (for example: your.name@domain.com)", "abv")]
        [InlineData("Entry is too long.", "iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii.iiiiiiiiiiiiiii@iiiiiiiiiiiiiiiiiiiiiiiiiiii.ii")]
        public void ValidateEmail(string error, string email)
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.NavigateToRegistrationPage();

            var registrationPage = new RegistrationPage(this.Driver);
            registrationPage.EmailField.SendKeys(email);
            registrationPage.RegisterButton.Click();
            registrationPage.AssertEmailValidationError(error);
        }

        [Fact]
        public void CheckForExistingEmail()
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.NavigateToRegistrationPage();

            var registrationPage = new RegistrationPage(this.Driver);
            registrationPage.FirstNameField.SendKeys("aaaa");
            registrationPage.LastNameField.SendKeys("aaaaa");
            registrationPage.EmailField.SendKeys("radina.di@gmail.com");
            registrationPage.PasswordField.SendKeys("123456");
            registrationPage.JavaScriptClick(registrationPage.TermsAndConditionsField);
            registrationPage.RegisterButton.Click();
            registrationPage.AssertExistingEmailValidationError();
        }

        [Theory]
        [InlineData("This field is required", "")]
        [InlineData("For security, your password needs to be at least 6 characters. Spaces don’t count.", "radi")]
        public void ValidatePassword(string error, string password)
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.NavigateToRegistrationPage();

            var registrationPage = new RegistrationPage(this.Driver);
            registrationPage.PasswordField.SendKeys(password);
            registrationPage.RegisterButton.Click();
            registrationPage.AssertPasswordValidationError(error);
        }

        [Fact]
        public void ValidateTermsAndConditionsAgreement()
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.NavigateToRegistrationPage();

            var registrationPage = new RegistrationPage(this.Driver);
            registrationPage.RegisterButton.Click();
            registrationPage.AssertTermsAndConditionsValidationError();
        }
    }
}

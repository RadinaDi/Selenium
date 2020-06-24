using MassimoDutti.Pages.HomePage;
using MassimoDutti.Pages.SignInPage;
using Xunit;

namespace MassimoDutti.Tests
{
    public class SignInShould : BaseTest
    {
        [Fact]
        public void OpenSuccessfully()
        {
            var homePage = new HomePage(this.Driver);
            homePage.OpenSite();
            homePage.SignInLink.Click();

            var signInPage = new SignInPage(this.Driver);
            signInPage.AssertHeader();
        }

        [Theory]
        [InlineData("Това поле е задължително", "")]
        [InlineData("Моля, въведете валиден имейл адрес", "abcdefg")]
        public void ValidateEmail(string error, string email)
        {
            var homePage = new HomePage(this.Driver);
            homePage.OpenSite();
            homePage.SignInLink.Click();

            var signInPage = new SignInPage(this.Driver);
            signInPage.EmailField.SendKeys(email);
            signInPage.SignInButton.Click();
            signInPage.AssertEmailValidation(error);
        }

        [Theory]
        [InlineData("Това поле е задължително", "")]
        public void ValidatePassword(string error, string password)
        {
            var homePage = new HomePage(this.Driver);
            homePage.OpenSite();
            homePage.SignInLink.Click();

            var signInPage = new SignInPage(this.Driver);
            signInPage.PasswordField.SendKeys(password);
            signInPage.SignInButton.Click();
            signInPage.AssertPasswordValidation(error);
        }
    }
}

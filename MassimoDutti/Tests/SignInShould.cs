using MassimoDutti.Data;
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
            var signInPage = this.OpenSignInPage();
            signInPage.AssertHeader();
        }

        [Theory]
        [InlineData("Това поле е задължително", "")]
        [InlineData("Моля, въведете валиден имейл адрес", "abcdefg")]
        public void ValidateEmail(string error, string email)
        {
            var account = AccountData.NewAccount().WithEmail(email);
            var signInPage = this.OpenSignInPage();
            signInPage.SignInWith(account);
            signInPage.AssertEmailValidation(error);
        }

        [Theory]
        [InlineData("Това поле е задължително", "")]
        public void ValidatePassword(string error, string password)
        {
            var account = AccountData.NewAccount().WithPassword(password);
            var signInPage = this.OpenSignInPage();
            signInPage.SignInWith(account);
            signInPage.AssertPasswordValidation(error);
        }

        private SignInPage OpenSignInPage()
        {
            var homePage = new HomePage(this.Driver);
            homePage.OpenSite();
            homePage.SignInLink.Click();

            return new SignInPage(this.Driver);
        }
    }
}

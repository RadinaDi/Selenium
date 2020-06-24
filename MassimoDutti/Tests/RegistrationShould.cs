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
            var homePage = new HomePage(this.Driver);
            homePage.OpenSite();
            homePage.SignInLink.Click();

            var signInPage = new SignInPage(this.Driver);
            signInPage.RegistrationButton.Click();

            var registrationPage = new RegistrationPage(this.Driver);
            registrationPage.AssertHeader();
        }
    }
}

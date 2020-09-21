using Vivacom.Data;
using Vivacom.Pages.HomePage;
using Vivacom.Pages.LoginPage;
using Vivacom.Pages.SmsPage;
using Xunit;

namespace Vivacom.Tests
{
    public class SmsPageShould : BaseTest
    {
        [Fact]
        public void OpenSuccessfully()
        {
            var smsPage = this.OpenSmsPage();
            smsPage.AssertHeader();
        }

        [Fact]
        public void SendSms()
        {
            var sms = SmsData.NewSms()
                             .WithFromNumber(this.Settings.FromNumber)
                             .WithToNumber(this.Settings.ToNumber);
            var smsPage = this.OpenSmsPage();
            smsPage.Send(sms);
        }

        private SmsPage OpenSmsPage()
        {
            var homePage = new HomePage(this.Driver);
            homePage.Open();
            homePage.MyVivacomLink.Click();
            homePage.SmsLink.Click();

            var account = AccountData.NewAccount()
                                     .WithEmail(this.Settings.Username)
                                     .WithPassword(this.Settings.Password);

            var loginPage = new LoginPage(this.Driver);
            loginPage.LoginWith(account);

            return new SmsPage(this.Driver);
        }
    }
}

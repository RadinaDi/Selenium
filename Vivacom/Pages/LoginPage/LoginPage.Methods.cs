using OpenQA.Selenium;
using Vivacom.Model;
using Vivacom.Pages.HomePage;

namespace Vivacom.Pages.LoginPage
{
    public partial class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver)
           : base(driver)
        {
        }

        public void LoginWith(Account account)
        {
            this.EmailField.SendKeys(account.Email);
            this.PasswordField.SendKeys(account.Password);
            this.LoginButton.Click();
        }
    }
}

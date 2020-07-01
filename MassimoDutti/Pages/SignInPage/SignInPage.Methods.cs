using MassimoDutti.Model;
using OpenQA.Selenium;

namespace MassimoDutti.Pages.SignInPage
{
    public partial class SignInPage : BasePage
    {
        public SignInPage(IWebDriver driver)
            : base(driver)
        {
        }

        public void SignInWith(Account account)
        {
            this.EmailField.SendKeys(account.Email);
            this.PasswordField.SendKeys(account.Password);
            this.SignInButton.Click();
        }
    }
}

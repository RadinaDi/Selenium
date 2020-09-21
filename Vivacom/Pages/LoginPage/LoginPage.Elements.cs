using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Vivacom.Pages.HomePage;

namespace Vivacom.Pages.LoginPage
{
    public partial class LoginPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'vivacom-first-text-login')]")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='username']")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='psw']")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='vivacom-login-button-orange-background']")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='error-msg']")]
        public IWebElement LoginErrorMessage { get; set; }
    }
}
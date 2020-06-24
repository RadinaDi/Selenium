using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MassimoDutti.Pages.SignInPage
{
    public partial class SignInPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='login']/div[1]/h2")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='login']/div[2]/form/div[1]/div[1]/input")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='login']/div[2]/form/div[1]/div[1]/div/span")]
        public IWebElement EmailValidation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='login']/div[2]/form/div[1]/div[2]/input")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='login']/div[2]/form/div[1]/div[2]/div/span")]
        public IWebElement PasswordValidation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='login']/div[2]/form/div[4]/div/div[1]/button")]
        public IWebElement SignInButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='wrapper-header']/div[3]/itx-user-access/div[3]/a")]
        public IWebElement RegistrationButton { get; set; }
    }
}

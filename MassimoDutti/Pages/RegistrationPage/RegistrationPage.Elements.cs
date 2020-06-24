using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MassimoDutti.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='register']/div/div[1]/h2")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='register']/div/div[2]/form/div[1]/div[2]/label")]
        public IWebElement GenderFemale { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='register']/div/div[2]/form/div[1]/div[1]/label")]
        public IWebElement GenderMale { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='register']/div/div[2]/form/div[2]/div[3]/input")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='register']/div/div[2]/form/div[2]/div[3]/div/span")]
        public IWebElement EmailErrorField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='register']/div/div[2]/form/div[2]/div[4]/div[1]/input")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='register']/div/div[2]/form/div[2]/div[4]/div[2]/ul")]
        public IWebElement PasswordErrorField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='privacyPolicyAccepted_terms_5']")]
        public IWebElement TermsAndConditionsField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='register']/div/div[2]/form/terms-conditions/div/div[1]/div/label/div/div/div[3]/span")]
        public IWebElement TermsAndConditionsErrorField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='register']/div/div[2]/form/div[4]/button[1]")]
        public IWebElement RegisterButton { get; set; }
    }
}

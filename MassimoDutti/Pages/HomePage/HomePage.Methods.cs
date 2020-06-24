using OpenQA.Selenium;

namespace MassimoDutti.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver)
            : base(driver)
        {
        }

        public void OpenSite()
        {
            this.Driver.Navigate().GoToUrl("https://www.massimodutti.com/bg/");

            this.AcceptCookiesOkButton.Click();
            this.LanguageButton.Click();
        }
    }
}

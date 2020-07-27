using OpenQA.Selenium;

namespace AbvBg.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver)
            : base(driver, 10)
        {
        }

        public void OpenSite()
        {
            this.Driver.Navigate().GoToUrl("https://www.abv.bg/");
            this.Driver.SwitchTo().Frame(this.AbvGdprFrame);
            this.Driver.SwitchTo().Frame(this.CmpFaktorIoFrame);
            this.AcceptCookiesButton.Click();
        }
    }
}

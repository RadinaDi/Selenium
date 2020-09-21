using OpenQA.Selenium;

namespace Vivacom.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver)
            : base(driver)
        {
        }

        public void Open()
        {
            this.Driver.Url = "https://www.vivacom.bg/bg";
        }
    }
}
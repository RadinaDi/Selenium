using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Vivacom.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//ul[@id='main-big-menu']/li[4]/a")]
        public IWebElement MyVivacomLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//ul[@id='main-big-menu']/li[4]/ul/li[4]/a")]
        public IWebElement SmsLink { get; set; }
    }
}

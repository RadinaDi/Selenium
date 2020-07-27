using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AbvBg.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='toplinks']/a[2]")]
        public IWebElement RegistrationLink { get; set; }

        [FindsBy(How = How.Id, Using = "acceptAll")]
        public IWebElement AcceptCookiesButton { get; set; }

        [FindsBy(How = How.Id, Using = "abv-GDPR-frame")]
        public IWebElement AbvGdprFrame { get; set; }

        [FindsBy(How = How.Id, Using = "cmp-faktor-io")]
        public IWebElement CmpFaktorIoFrame { get; set; }
    }
}

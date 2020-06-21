using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Zalando.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        [FindsBy(How = How.Id, Using = "uc-btn-accept-banner")]
        public IWebElement AcceptCookiesOkButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class, 'z-navicat-header_navToolItem-profile')]/a/span/span")]
        public IWebElement LoginMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='z-navicat-header_userAccountContainer']/div/a[1]")]
        public IWebElement LoginLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='z-navicat-header_userAccountContainer']/div/a[2]")]
        public IWebElement RegistrationLink { get; set; }
    }
}

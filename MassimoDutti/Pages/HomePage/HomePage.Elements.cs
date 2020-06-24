using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MassimoDutti.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//itx-cookies/div/div/button")]
        public IWebElement AcceptCookiesOkButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='page']/itx-footer/footer/itx-banners/div/itx-redirect-store/div/div[2]/div/button[2]")]
        public IWebElement LanguageButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='wrapper-header']/div[2]/header/div[2]/div/ul/li[2]/a")]
        public IWebElement SignInLink { get; set; }
    }
}

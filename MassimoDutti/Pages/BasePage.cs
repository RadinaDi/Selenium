using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;

namespace MassimoDutti.Pages
{
    public class BasePage
    {
        public BasePage(IWebDriver driver, int timeoutSec = 3)
        {
            this.Driver = driver;
            this.Builder = new Actions(driver);

            var locator = new RetryingElementLocator(driver, new TimeSpan(0, 0, timeoutSec));
            PageFactory.InitElements(this, locator);
        }

        protected IWebDriver Driver { get; private set; }

        protected Actions Builder { get; private set; }
    }
}

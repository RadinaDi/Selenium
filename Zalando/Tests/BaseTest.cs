using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Zalando.Tests
{
    public class BaseTest : IDisposable
    {
        public BaseTest()
        {
            //Disabled because of ElementNotInteractableException
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
            this.Driver = new ChromeDriver(/*options*/);
            this.Driver.Manage().Window.Maximize();
        }

        protected IWebDriver Driver { get; private set; }

        public void Dispose()
        {
            this.Driver.Quit();
        }
    }
}

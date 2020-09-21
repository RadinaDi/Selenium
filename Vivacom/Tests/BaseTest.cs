using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Vivacom.Configurations;

namespace Vivacom.Tests
{
    public class BaseTest : IDisposable
    {
        public BaseTest()
        {
            var config = new ConfigurationBuilder()
            .AddJsonFile("local.settings.json", false, false)
            .Build();

            this.Settings = new AppSettings(config);

            this.Driver = new ChromeDriver();
            this.Driver.Manage().Window.Maximize();
        }

        protected AppSettings Settings { get; set; }

        protected IWebDriver Driver { get; private set; }

        public void Dispose()
        {
            this.Driver.Quit();
        }
    }
}

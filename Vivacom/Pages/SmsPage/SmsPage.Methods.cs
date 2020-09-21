using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using Vivacom.Model;
using Vivacom.Pages.HomePage;

namespace Vivacom.Pages.SmsPage
{
    public partial class SmsPage : BasePage
    {
        public SmsPage(IWebDriver driver)
          : base(driver, 10)
        {
        }

        public void Send(Sms sms)
        {
            this.FromPhoneNumberArrowField.Click();
            var fromPhoneNumberInput = this.GetPhoneNumberInput();
            fromPhoneNumberInput.SendKeys(sms.FromNumber);
            fromPhoneNumberInput.SendKeys(Keys.Enter);

            this.ToPhoneNumberArrowField.Click();
            var toPhoneNumberInput = this.GetPhoneNumberInput();
            toPhoneNumberInput.SendKeys(sms.ToNumber);

            this.MessageField.Click();
            this.MessageField.SendKeys(sms.Message);
            this.SendButton.Click();
        }

        private IWebElement GetPhoneNumberInput()
        {
            WebDriverWait wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(2));
            return wait.Until(d => d.FindElement(By.XPath("//input[@class='select2-search__field']")));
        }
    }
}
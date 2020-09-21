using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Vivacom.Pages.HomePage;

namespace Vivacom.Pages.SmsPage
{
    public partial class SmsPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@id='mega-menu-small-tabs']/div[1]/div[1]/div[1]/a[1]/div[1]/p")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[16]/div[1]/section/div/div[4]/div/div/div[1]/em")]
        public IWebElement SmsSendingLink { get; set; }

        [FindsBy(How = How.Id, Using = "select2-senderMsisdnSelect-container")]
        public IWebElement FromPhoneNumberField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='sendSmsMessageForm']/div[1]/div/div[1]/div/div/div[2]/span/span[1]/span/span[2]")]
        public IWebElement FromPhoneNumberArrowField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='senderMsisdn.errors']")]
        public IWebElement FromPhoneNumberErrorField { get; set; }

        [FindsBy(How = How.Id, Using = "select2-select-write-container")]
        public IWebElement ToPhoneNumberField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='sendSmsMessageForm']/div[1]/div/div[2]/div/div/div/span/span[1]/span/span[2]")]
        public IWebElement ToPhoneNumberArrowField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='receiverMsisdn.errors']")]
        public IWebElement ToPhoneNumberErrorField { get; set; }

        [FindsBy(How = How.XPath, Using = "//textarea[@id='sms-message-textarea']")]
        public IWebElement MessageField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='message.errors']")]
        public IWebElement MessageErrorField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='sendSmsMessageForm']/div[1]/div/div[4]/div[2]/button")]
        public IWebElement SendButton { get; set; }
    }
}

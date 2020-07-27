using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AbvBg.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "/html/body/article/div/div[1]/nav/ul/li[2]/a")]
        public IWebElement RegistrationMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='regformUsername']")]
        public IWebElement UserField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='regform']/div[1]/div[2]")]
        public IWebElement UserErrorField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='fname']")]
        public IWebElement FirstNameField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='regform']/div[8]/div[2]")]
        public IWebElement FirstNameErrorField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='lname']")]
        public IWebElement LastNameField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='regform']/div[9]/div[2]")]
        public IWebElement LastNameErrorField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='phoneRecovery1']")]
        public IWebElement PhoneNumberPasswordRestorationField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='mobilePhone']")]
        public IWebElement PhoneNumberField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='regform']/div[6]/div[2]")]
        public IWebElement PhoneNumberErrorField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='regform']/div[10]/div/label[2]")]
        public IWebElement GenderFemale { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='regform']/div[10]/div/label[1]")]
        public IWebElement GenderMale { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='password']")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='regform']/div[3]/div[2]")]
        public IWebElement PasswordErrorField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='password2']")]
        public IWebElement ConfirmPasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='regform']/div[4]/div[2]")]
        public IWebElement ConfirmPasswordErrorField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='bDay']/ul/li[1]")]
        public IWebElement BirthDateDayField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='bMonth']/ul/li[1]")]
        public IWebElement BirthDateMonthField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='bYear']/ul/li[1]")]
        public IWebElement BirthDateYearField { get; set; }

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement BirthDateErrorField { get; set; }

        [FindsBy(How = How.Id, Using = "recaptcha")]
        public IWebElement ReCaptchaFrame { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='g-recaptcha']/div/div/iframe")]
        public IWebElement ReCaptchaInnerFrame { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='recaptcha-anchor']/div[1]")]
        public IWebElement IAmNotARobotField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='regform']/div[12]/div[2]")]
        public IWebElement IAmNotARobotErrorField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='regform']/div[13]/div/input")]
        public IWebElement RegisterButton { get; set; }
    }
}

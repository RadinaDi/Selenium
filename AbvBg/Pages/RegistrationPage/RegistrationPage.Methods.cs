using AbvBg.Model;
using AbvBg.Model.Enums;
using OpenQA.Selenium;

namespace AbvBg.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver)
            : base(driver)
        {
        }

        public void RegisterWith(Account account)
        {
            switch (account.Gender)
            {
                case Gender.Male:
                    this.GenderMale.Click();
                    break;
                case Gender.Female:
                    this.GenderFemale.Click();
                    break;
            }

            this.FirstNameField.SendKeys(account.FirstName);
            this.LastNameField.SendKeys(account.LastName);
            this.UserField.SendKeys(account.User);
            this.PasswordField.SendKeys(account.Password);

            this.Driver.SwitchTo().Frame(this.ReCaptchaFrame);
            this.Driver.SwitchTo().Frame(this.ReCaptchaInnerFrame);
            this.IAmNotARobotField.Click();

            this.RegisterButton.Click();
        }
    }
}

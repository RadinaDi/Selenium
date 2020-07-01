using MassimoDutti.Model;
using MassimoDutti.Model.Enums;
using OpenQA.Selenium;

namespace MassimoDutti.Pages.RegistrationPage
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
            this.EmailField.SendKeys(account.Email);
            this.PasswordField.SendKeys(account.Password);
            this.TermsAndConditionsField.Click();
            this.RegisterButton.Click();
        }
    }
}

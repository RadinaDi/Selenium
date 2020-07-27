using Xunit;

namespace AbvBg.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        public void AssertRegistration()
        {
            Assert.Equal("Регистрация", this.RegistrationMenu.Text);
        }

        public void AssertUserValidation(string expected)
        {
            Assert.Equal(expected, this.UserErrorField.Text);
        }

        public void AssertFirstNameValidation(string expected)
        {
            Assert.Equal(expected, this.FirstNameErrorField.Text);
        }

        public void AssertLastNameValidation(string expected)
        {
            Assert.Equal(expected, this.LastNameErrorField.Text);
        }

        public void AssertPasswordValidation(string expected)
        {
            Assert.Equal(expected, this.PasswordErrorField.Text);
        }

        public void AssertConfirmPasswordValidation(string expected)
        {
            Assert.Equal(expected, this.ConfirmPasswordErrorField.Text);
        }

        public void AssertPhoneNumberValidation(string expected)
        {
            Assert.Equal(expected, this.PhoneNumberErrorField.Text);
        }

        public void AssertAntiSpamValidation(string expected)
        {
            Assert.Equal(expected, this.IAmNotARobotErrorField.Text);
        }
    }
}

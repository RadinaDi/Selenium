using Xunit;

namespace MassimoDutti.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        public void AssertHeader()
        {
            Assert.Equal("Създаване на профил", this.Header.Text);
        }

        public void AssertFirstNameValidation(string expected)
        {
            Assert.Equal(expected, this.FirstNameErrorField.Text);
        }

        public void AssertLastNameValidation(string expected)
        {
            Assert.Equal(expected, this.LastNameErrorField.Text);
        }

        public void AssertEmailValidation(string expected)
        {
            Assert.Equal(expected, this.EmailErrorField.Text);
        }

        public void AssertPasswordValidation(string expected)
        {
            Assert.Equal(expected, this.PasswordErrorField.Text);
        }
    }
}

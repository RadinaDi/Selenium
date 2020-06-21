using Xunit;

namespace Zalando.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        public void AssertHeader()
        {
            Assert.Equal("I’m new here", this.Header.Text);
        }

        public void AsserFirstNameValidationError(string error)
        {
            Assert.Equal(error, this.FirstNameErrorField.Text);
        }

        public void AssertLastNameValidationError(string error)
        {
            Assert.Equal(error, this.LastNameErrorField.Text);
        }

        public void AssertEmailValidationError(string error)
        {
            Assert.Equal(error, this.EmailErrorField.Text);
        }

        public void AssertExistingEmailValidationError()
        {
            Assert.Equal("The email address entered already exists in our database - try logging in or entering a different email address.", this.EmailErrorField.Text);
        }

        public void AssertPasswordValidationError(string error)
        {
            Assert.Equal(error, this.PasswordErrorField.Text);
        }

        public void AssertTermsAndConditionsValidationError()
        {
            Assert.Equal("This field is required", this.TermsAndConditionsErrorField.Text);
        }
    }
}

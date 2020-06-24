using Xunit;

namespace MassimoDutti.Pages.SignInPage
{
    public partial class SignInPage : BasePage
    {
        public void AssertHeader()
        {
            Assert.Equal("Начало на сесията", this.Header.Text);
        }

        public void AssertEmailValidation(string expected)
        {
            Assert.Equal(expected, this.EmailValidation.Text);
        }

        public void AssertPasswordValidation(string expected)
        {
            Assert.Equal(expected, this.PasswordValidation.Text);
        }
    }
}

using Xunit;

namespace MassimoDutti.Pages.RegistrationPage
{
    public partial class RegistrationPage : BasePage
    {
        public void AssertHeader()
        {
            Assert.Equal("Създаване на профил", this.Header.Text);
        }
    }
}

using Vivacom.Pages.HomePage;
using Xunit;

namespace Vivacom.Pages.SmsPage
{
    public partial class SmsPage : BasePage
    {
        public void AssertHeader()
        {
            Assert.Equal("Изпрати SMS", this.Header.Text);
        }

        public void AssertFromNumber(string expected)
        {
            Assert.Equal(expected, this.FromPhoneNumberErrorField.Text);
        }

        public void AssertToNumber(string expected)
        {
            Assert.Equal(expected, this.ToPhoneNumberErrorField.Text);
        }

        public void AssertMessage(string expected)
        {
            Assert.Equal(expected, this.MessageErrorField.Text);
        }
    }
}

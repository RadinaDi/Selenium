using System;
using System.Collections.Generic;
using System.Text;
using Vivacom.Pages.HomePage;
using Xunit;

namespace Vivacom.Pages.LoginPage
{
    public partial class LoginPage : BasePage
    {
        public void AssertHeader()
        {
            Assert.Equal("My VIVACOM Вход", this.Header.Text);
        }

        public void AssertEmailField(string expected)
        {
            Assert.Equal(expected, this.LoginErrorMessage.Text);
        }
    }
}

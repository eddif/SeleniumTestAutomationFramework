using WIWDemoFramework;
using NUnit.Framework;

namespace WIWDemoTests
{
    [TestFixture]
    public class SmokeTests : TestBase
    {

        [Test]
        public void CanAccessLoginPage()
        {
            Pages.Login.Goto();
            Assert.IsTrue(Pages.Login.IsAt());
        }

        [Test]
        public void CanAccessResetPasswordPage()
        {
            Pages.Login.Goto();
            Pages.Login.ClickForgotPasswordButton();
            Assert.IsTrue(Browser.CurrentURL.Contains("forgot"));
        }

        [Test]
        public void CanAccessRegisterPage()
        {
            Pages.Login.Goto();
            Pages.Login.ClickRegisterNowButton();
            Assert.IsTrue(Browser.CurrentURL.Contains("register"));
        }

        [Test]
        [Ignore("SAMPLE - NOT TESTED, BUT COULD WORK - DID NOT WANT TO TEST FATE AND BLOAT DATABASE")]
        public void CanRegisterAsNewUser()
        {
            Pages.Login.Goto();
            Pages.Login.ClickRegisterNowButton();
            Pages.Register.RegisterNewUser();
            Assert.IsTrue(Browser.CurrentURL.Contains("Home"));
        }

        
    }


}

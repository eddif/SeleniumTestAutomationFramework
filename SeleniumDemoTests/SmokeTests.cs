using SeleniumDemoFramework;
using NUnit.Framework;

namespace SeleniumDemoTests
{
    [TestFixture]
    public class SmokeTests : TestBase
    {

        [Test]
        public void CanAccessAboutPage()
        {
            Pages.Login.Goto();
            Assert.IsTrue(Pages.Login.IsAt());
        }

        [Test]
        public void CanAccessContactPage()
        {
            Pages.Login.Goto();
            Pages.Login.ClickForgotPasswordButton();
            Assert.IsTrue(Browser.CurrentURL.Contains("forgot"));
        }

        [Test]
        public void CanAccessProductsPage()
        {
            Pages.Login.Goto();
            Pages.Login.ClickForgotPasswordButton();
            Assert.IsTrue(Browser.CurrentURL.Contains("forgot"));
        }

        [Test]
        public void CanAccessCartPage()
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
        public void CanAccessLoginPage()
        {
            Pages.Login.Goto();
            Pages.Login.ClickRegisterNowButton();
            Assert.IsTrue(Browser.CurrentURL.Contains("register"));
        }

        [Test]
        public void CanRegisterAsNewUser()
        {
            Pages.Login.Goto();
            Pages.Login.ClickRegisterNowButton();
            Pages.Register.RegisterNewUser();
            Assert.IsTrue(Browser.CurrentURL.Contains("Home"));
        }

        
    }


}

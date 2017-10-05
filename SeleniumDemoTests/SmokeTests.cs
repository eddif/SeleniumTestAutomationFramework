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
            Pages.Home.Goto();
            Pages.TopNavigation.clickAboutLink();
            Assert.IsTrue(Pages.About.IsAt());
            Assert.IsTrue(Browser.CurrentURL.Contains("About"));
        }

        [Test]
        public void CanAccessContactPage()
        {
            Pages.Home.Goto();
            Pages.TopNavigation.clickContactLink();
            Assert.IsTrue(Pages.Contact.IsAt());
            Assert.IsTrue(Browser.CurrentURL.Contains("Contact"));
        }

        [Test]
        public void CanAccessProductsPage()
        {
            Pages.Home.Goto();
            Pages.TopNavigation.clickProductsLink();
            Assert.IsTrue(Pages.Products.IsAt());
            Assert.IsTrue(Browser.CurrentURL.Contains("Products"));
        }

        [Test]
        public void CanAccessCartPage()
        {
            Pages.Home.Goto();
            Pages.TopNavigation.clickCartLink();
            Assert.IsTrue(Pages.Cart.IsAt());
            Assert.IsTrue(Browser.CurrentURL.Contains("ShoppingCart"));
        }

        [Test]
        public void CanAccessRegisterPage()
        {
            Pages.Home.Goto();
            Pages.TopNavigation.clickRegisterLink();
            Assert.IsTrue(Pages.Register.IsAt());
            Assert.IsTrue(Browser.CurrentURL.Contains("Register"));
        }

        [Test]
        public void CanAccessLoginPage()
        {
            Pages.Home.Goto();
            Pages.TopNavigation.clickLoginLink();
            Assert.IsTrue(Pages.Login.IsAt());
            Assert.IsTrue(Browser.CurrentURL.Contains("Log in"));
        }

        [Test]
        public void CanRegisterAsNewUser()
        {
            Pages.Register.Goto();
            Pages.Register.RegisterNewUser();

            Assert.IsTrue(Pages.Register.IsAt());

            //TBD - confirm two factor authentication (e.g. user must validate email before completing registration)
        }

        [Test]
        public void CanLoginAsUser()
        {
            Pages.Login.Goto();
            Pages.Login.LogInAsLastRegisteredUser();

            Assert.IsTrue(Pages.TopNavigation.userName.Displayed);
        }

        [Test]
        public void CanLoginAsAdminUser()
        {
            Pages.Login.LogIn("AdminUser");

            Assert.IsTrue(Pages.TopNavigation.userName.Displayed);
        }
    }


}

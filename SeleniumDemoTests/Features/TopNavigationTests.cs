using SeleniumDemoFramework;
using NUnit.Framework;

namespace SeleniumDemoTests.Features
{
    [TestFixture]
    class TopNavigationTests : TestBase
    {

        [Test]
        public void AllLinksVisibleToUser()
        {
            Pages.Login.Goto();
            Assert.IsTrue(Pages.Login.IsAt());
        }

        [Test]
        public void AllLinksVisibleToAdmin()
        {
            Pages.Login.Goto();
            Assert.IsTrue(Pages.Login.IsAt());
        }

        [TestCase("Homepage")]
        [TestCase("About")]
        [TestCase("Contact")]
        [TestCase("Products")]
        [TestCase("Register")]
        [TestCase("Login")]
        public void TopNavigationVisibleOnAllPages(string page)
        {
            Pages.Login.Goto();

            switch (page)
            {
                case "Homepage":
                    Pages.Home.Goto();
                    Assert.IsTrue(Pages.Home.IsAt());
                    break;
                case "About":
                    Pages.About.Goto();
                    Assert.IsTrue(Pages.About.IsAt());
                    break;
                case "Contact":
                    Pages.Contact.Goto();
                    Assert.IsTrue(Pages.Contact.IsAt());
                    break;
                case "Products":
                    Pages.Products.Goto();
                    Assert.IsTrue(Pages.Products.IsAt());
                    break;
                case "Register":
                    Pages.Register.Goto();
                    Assert.IsTrue(Pages.Register.IsAt());
                    break;
                case "Login":
                    Pages.Login.Goto();
                    Assert.IsTrue(Pages.Login.IsAt());
                    break;
            }
                
        }

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

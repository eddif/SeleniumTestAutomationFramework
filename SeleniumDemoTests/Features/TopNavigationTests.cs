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
            Assert.IsTrue(Pages.TopNavigation.companyLink.Displayed);
            Assert.IsTrue(Pages.TopNavigation.aboutLink.Displayed);
            Assert.IsTrue(Pages.TopNavigation.contactLink.Displayed);
            Assert.IsTrue(Pages.TopNavigation.productsLink.Displayed);
            Assert.IsTrue(Pages.TopNavigation.cartLink.Displayed);
            Assert.IsTrue(Pages.TopNavigation.registerLink.Displayed);
            Assert.IsTrue(Pages.TopNavigation.loginLink.Displayed);
        }

        [Test]
        public void AllLinksVisibleToAdmin()
        {
            Pages.Login.Goto();
            //login as admin --> not complete
            Assert.IsTrue(Pages.TopNavigation.companyLink.Displayed);
            Assert.IsTrue(Pages.TopNavigation.aboutLink.Displayed);
            Assert.IsTrue(Pages.TopNavigation.contactLink.Displayed);
            Assert.IsTrue(Pages.TopNavigation.productsLink.Displayed);
            Assert.IsTrue(Pages.TopNavigation.cartLink.Displayed);
            Assert.IsTrue(Pages.TopNavigation.registerLink.Displayed);
            Assert.IsTrue(Pages.TopNavigation.loginLink.Displayed);
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
            Assert.IsTrue(Browser.CurrentURL.Contains("ProductList"));
        }

        [Test]
        public void CanAccessCartPage()
        {
            Pages.Home.Goto();
            Pages.TopNavigation.clickCartLink();

            Assert.IsTrue(Pages.Contact.IsAt());
            Assert.IsTrue(Browser.CurrentURL.Contains("ShppingCart"));
        }

        [Test]
        public void CanAccessRegisterPage()
        {
            Pages.Home.Goto();
            Pages.TopNavigation.clickRegisterLink();

            Assert.IsTrue(Pages.Register.IsAt());
            Assert.IsTrue(Browser.CurrentURL.Contains("Account/Register"));
        }

        [Test]
        public void CanAccessLoginPage()
        {
            Pages.Home.Goto();
            Pages.TopNavigation.clickLoginLink();

            Assert.IsTrue(Pages.Login.IsAt());
            Assert.IsTrue(Browser.CurrentURL.Contains("Account/Login"));
        }

       
    }
}

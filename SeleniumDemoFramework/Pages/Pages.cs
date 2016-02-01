using SeleniumDemoFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumDemoFramework
{
    public static class Pages
    {

       // public static IWebDriver _driver;

        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            IWebDriver driver = Browser._Driver;
            PageFactory.InitElements(Browser.Driver, page);
            
            return page;
        }

        public static HomePage Home
        {
            get { return GetPage<HomePage>(); }
        }

        public static AboutPage About
        {
            get { return GetPage<AboutPage>(); }
        }

        public static ContactPage Contact
        {
            get { return GetPage<ContactPage>(); }
        }

        public static ProductsPage Products
        {
            get { return GetPage<ProductsPage>(); }
        }

        public static CartPage Cart
        {
            get { return GetPage<CartPage>(); }
        }

        public static RegisterPage Register
        {
            get { return GetPage<RegisterPage>(); }
        }

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

        public static ResetPasswordPage ForgotPassword
        {
            get { return GetPage<ResetPasswordPage>(); }
        }

        public static TopNavigationBar TopNavigation
        {
            get { return GetPage<TopNavigationBar>(); }
        }
    }
}

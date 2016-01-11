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

        public static TopNavigation TopNavigation
        {
            get { return GetPage<TopNavigation>(); }
        }

        public static TestimonialsPage Home
        {
            get { return GetPage<TestimonialsPage>(); }
        }

        public static RegisterPage Register
        {
            get { return GetPage<RegisterPage>(); }
        }

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

        public static ForgotPasswordPage ForgotPassword
        {
            get { return GetPage<ForgotPasswordPage>(); }
        }

        public static PricingPage Pricing
        {
            get { return GetPage<PricingPage>(); }
        }
    }
}

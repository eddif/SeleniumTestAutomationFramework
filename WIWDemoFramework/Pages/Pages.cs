using WIWDemoFramework;
using OpenQA.Selenium.Support.PageObjects;

namespace WIWDemoFramework
{
    public static class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
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
    }
}

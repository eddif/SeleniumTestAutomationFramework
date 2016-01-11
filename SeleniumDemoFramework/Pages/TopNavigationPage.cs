using SeleniumDemoFramework.Generators;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumDemoFramework
{
    public class TopNavigation
    {
        [FindsBy(How = How.LinkText, Using = "Testimonials")]
        private IWebElement testimonialsLink;

        [FindsBy(How = How.LinkText, Using = "Features")]
        private IWebElement featuresLink;

        [FindsBy(How = How.LinkText, Using = "New Employees")]
        private IWebElement newEmployeesLink;

        [FindsBy(How = How.LinkText, Using = "Pricing")]
        private IWebElement pricingLink;

        [FindsBy(How = How.CssSelector, Using = "#login > a")]
        private IWebElement emailLink;

        [FindsBy(How = How.ClassName, Using = "login-link-grey")]
        private IWebElement logInLink;


        public void Testimonials()
        {
            testimonialsLink.Click();
        }

        public void Features()
        {
            featuresLink.Click();
        }

        public void NewEmployees()
        {
            newEmployeesLink.Click();
        }

        public void Pricing()
        {
            pricingLink.Click();
        }

        public void LogIn()
        {
            logInLink.Click();
        }

    }
}
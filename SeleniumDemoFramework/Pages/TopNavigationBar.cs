using SeleniumDemoFramework.Generators;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumDemoFramework
{
    public class TopNavigationBar
    {
        [FindsBy(How = How.ClassName, Using = "sel-companyLink")]
        private IWebElement companyLink;

        [FindsBy(How = How.ClassName, Using = "sel-aboutLink")]
        private IWebElement aboutLink;

        [FindsBy(How = How.ClassName, Using = "sel-contactLink")]
        private IWebElement contactLink;

        [FindsBy(How = How.ClassName, Using = "sel-productsLink")]
        private IWebElement productsLink;

        [FindsBy(How = How.ClassName, Using = "sel-cartLink")]
        private IWebElement cartLink;

        [FindsBy(How = How.ClassName, Using = "sel-registerLink")]
        private IWebElement registerLink;

        [FindsBy(How = How.ClassName, Using = "sel-loginLink")]
        private IWebElement loginLink;



        public void clickCompanyLink()
        {
            companyLink.Click();
        }

        public void clickAboutLink()
        {
            aboutLink.Click();
        }

        public void clickConstactLink()
        {
            contactLink.Click();
        }

        public void clickProductsLink()
        {
            productsLink.Click();
        }

        public void clickCartLink()
        {
            cartLink.Click();
        }

        public void clickRegisterLink()
        {
            registerLink.Click();
        }

        public void clickLoginLink()
        {
            loginLink.Click();
        }

    }
}
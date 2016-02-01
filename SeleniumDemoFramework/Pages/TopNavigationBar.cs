using SeleniumDemoFramework.Generators;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumDemoFramework
{
    public class TopNavigationBar
    {
        [FindsBy(How = How.ClassName, Using = "sel-companyLink")]
        public IWebElement companyLink;

        [FindsBy(How = How.ClassName, Using = "sel-aboutLink")]
        public IWebElement aboutLink;

        [FindsBy(How = How.ClassName, Using = "sel-contactLink")]
        public IWebElement contactLink;

        [FindsBy(How = How.ClassName, Using = "sel-productsLink")]
        public IWebElement productsLink;

        [FindsBy(How = How.ClassName, Using = "sel-cartLink")]
        public IWebElement cartLink;

        [FindsBy(How = How.ClassName, Using = "sel-registerLink")]
        public IWebElement registerLink;

        [FindsBy(How = How.ClassName, Using = "sel-loginLink")]
        public IWebElement loginLink;

        [FindsBy(How = How.ClassName, Using = "sel-username")]
        public IWebElement userName;



        public void clickCompanyLink()
        {
            companyLink.Click();
        }

        public void clickAboutLink()
        {
            aboutLink.Click();
        }

        public void clickContactLink()
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
using SeleniumDemoFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumDemoFramework
{
    public class HomePage
    {

        public void Goto()
        {
            Browser.Goto("/");
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("Welcome");
        }

    }
}

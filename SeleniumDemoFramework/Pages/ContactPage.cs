using SeleniumDemoFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumDemoFramework
{
    public class ContactPage
    {
        public void Goto()
        {
            Browser.Goto("/Contact");
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("Contact");
        }
    }
}
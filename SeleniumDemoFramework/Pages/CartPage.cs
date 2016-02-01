using SeleniumDemoFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumDemoFramework
{
    public class CartPage
    {
        public void Goto()
        {
            Browser.Goto("ShoppingCart");
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("Your Cart");
        }
    }
}

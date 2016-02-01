using SeleniumDemoFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumDemoFramework
{
   public class ProductsPage
    {
        public void Goto()
        {
            Browser.Goto("ProductList");
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("Products");
        }
    }
}

using System;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace SOpenQA.Selenium
{
    public static class IWebDriverExtensions
    {

        public static void FindSelectElement(this IWebDriver driver, By bylocator, String text)
        {
            // Finds a select element and then selects
            // the option element using the visible text

            IWebElement selectElement = driver.FindElement(bylocator);
            selectElement.FindElement(By.XPath("//option[contains(text(), '" + text + "')]")).Click();
        }

        public static bool WaitForAjax(this IWebDriver driver)
        {
            try
            {
                while (true) // Handle timeout somewhere
                {
                    var ajaxIsComplete = (bool)(driver as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0");
                    if (ajaxIsComplete)
                        break;
                    Thread.Sleep(100);
                }
            }
            catch (TimeoutException e)
            {
                Console.Error.WriteLine(e.Message + "Error waiting for ajax");
            }

            return true;

        }


    }
}

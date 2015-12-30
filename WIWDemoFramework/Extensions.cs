using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace WIWDemoFramework
{
    public static class Extensions
    {

        public static bool Exists(this IWebElement element)
        {
            try
            {
                var text = element.Text;
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public static void DragAndDrop(int count, int range)
        {

            

            Actions move = new Actions(Browser._Driver);
           // move.DragAndDropToOffset(pricingSider, count, range).Build();
           // move.Perform();
        }

    }
}

using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace SeleniumDemoFramework
{
    public class AboutPage
    {

        public void Goto()
        {
            Browser.Goto("About");
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("About");
        }

    }
}

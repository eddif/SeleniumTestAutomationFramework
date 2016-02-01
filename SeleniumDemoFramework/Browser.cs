using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumDemoFramework
{
    public class Browser
    {
        public IWebDriver WebDriver { get; set; }
        public string environmentURL { get; set; }

        private static string baseUrl = "http://businessco.azurewebsites.net/"; //use app config for determining environment
        private static IWebDriver webDriver = new FirefoxDriver();

        public Browser(IWebDriver webDriver)
        {
            environmentURL = ConfigurationManager.AppSettings["Base_URL"];
            WebDriver = webDriver;
        }

        public static void Initialize()
        {
            
            Goto("");
        }

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static string CurrentURL
        {
            get { return webDriver.Url; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static IWebDriver _Driver
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = baseUrl + url;
        }

        public static void Close()
        {
            //webDriver.Close();
        }

        
    }
}
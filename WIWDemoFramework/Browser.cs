using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace WIWDemoFramework
{
    public static class Browser
    {
        //private static string baseUrl = "http://localhost:12142/";
        private static string baseUrl = "https://wheniwork.com/";

        private static IWebDriver webDriver = new FirefoxDriver();
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
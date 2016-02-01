using SeleniumDemoFramework.Generators;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace SeleniumDemoFramework
{
    public class ResetPasswordPage
    {

        [FindsBy(How = How.Id, Using = "sel-reset")]
        private IWebElement resetButton;


        public void Goto()
        {
            Browser.Goto("/Account/ResetPassword");
        }

        public bool IsAt()
        {
           return Browser.Title.Contains("Reset Password");
        }

        public void ClickResetButton()
        {
            resetButton.Click();
        }


    }
}

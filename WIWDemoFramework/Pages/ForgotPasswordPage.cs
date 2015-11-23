using WIWDemoFramework.Generators;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace WIWDemoFramework
{
    public class ForgotPasswordPage
    {

        [FindsBy(How = How.Id, Using = "id-login-forgot")]
        private IWebElement forgotPasswordButton;


        public void Goto()
        {
            Browser.Goto("/login/forgot");
        }

        public bool IsAt()
        {
           return Browser.Title.Contains("Login");
        }

        public void ClickForgotPasswordButton()
        {
            forgotPasswordButton.Click();
        }


    }
}

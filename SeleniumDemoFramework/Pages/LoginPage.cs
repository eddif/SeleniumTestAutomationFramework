using System.Runtime.InteropServices;
using SeleniumDemoFramework.Generators;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumDemoFramework
{
    public class LoginPage
    {
        [FindsBy(How = How.CssSelector, Using = "sel-email")]
        private IWebElement emailField;

        [FindsBy(How = How.CssSelector, Using = "sel-password")]
        private IWebElement passwordField;

        [FindsBy(How = How.CssSelector, Using = "sel-login")]
        private IWebElement loginButton;

        [FindsBy(How = How.CssSelector, Using = "sel-google")] //not complete
        private IWebElement signInWithGoogleButton;

        [FindsBy(How = How.Id, Using = "RememberMe")]
        private IWebElement rememberMeCheckbox;


        public void Goto()
        {
            Pages.TopNavigation.clickLoginLink();
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("Login");
            
        }

        public void LogInAsLastRegisteredUser()
        {
            LogIn(UserGenerator.LastGeneratedUser);
        }
        
        public void LogInAsLastRegisteredUser(LoginOptions useLastGeneratedPassword)
        {
            var user = new User()
            {
                EmailAddress = UserGenerator.LastGeneratedUser.EmailAddress,
                Password = PasswordGenerator.LastGeneratedPassword
            };
            
            LogIn(user);
        }


        public void ClickRegisterNowButton()
        {
            rememberMeCheckbox.Click();
        }


        private void ClearLoginFields()
        {
            emailField.Clear();
            passwordField.Clear();
        }

        private void LogIn(User user)
        {
            ClearLoginFields();
            emailField.SendKeys(user.EmailAddress);
            passwordField.SendKeys(user.Password);
            loginButton.Click();
        }

        public enum LoginOptions
        {
            UseLastGeneratedPassword
        }

        
    }
}
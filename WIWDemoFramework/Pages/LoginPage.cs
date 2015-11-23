using System.Runtime.InteropServices;
using WIWDemoFramework.Generators;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WIWDemoFramework
{
    public class LoginPage
    {
        [FindsBy(How = How.Id, Using = "login-username")]
        private IWebElement emailAddressTextField;

        [FindsBy(How = How.Id, Using = "login-password")]
        private IWebElement passwordTextField;

        [FindsBy(How = How.CssSelector, Using = "button.button-kit")]
        private IWebElement logInButton;

        [FindsBy(How = How.CssSelector, Using = "btn-google")]
        private IWebElement signInWithGoogleButton;

        [FindsBy(How = How.Id, Using = "id-login-register")]
        private IWebElement registerNowButton;

        [FindsBy(How = How.Id, Using = "id-login-forgot")]
        private IWebElement forgotPasswordButton;

        public void Goto()
        {
            Pages.TopNavigation.LogIn();
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("Login");
            
        }

        public void ClickForgotPasswordButton()
        {
            forgotPasswordButton.Click();
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
            registerNowButton.Click();
        }


        private void ClearLoginFields()
        {
            emailAddressTextField.Clear();
            passwordTextField.Clear();
        }

        private void LogIn(User user)
        {
            ClearLoginFields();
            emailAddressTextField.SendKeys(user.EmailAddress);
            passwordTextField.SendKeys(user.Password);
            logInButton.Click();
        }

        public enum LoginOptions
        {
            UseLastGeneratedPassword
        }

        
    }
}
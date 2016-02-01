using SeleniumDemoFramework.Generators;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumDemoFramework
{
    public class RegisterPage
    {

        [FindsBy(How = How.ClassName, Using = "sel-email")]
        private IWebElement emailAddressField;

        [FindsBy(How = How.ClassName, Using = "sel-password")]
        private IWebElement passwordField;

        [FindsBy(How = How.ClassName, Using = "sel-confirm-password")]
        private IWebElement confirmPasswordField;

        [FindsBy(How = How.ClassName, Using = "sel-register")]
        private IWebElement registerButton;

        public void Goto()
        {
            Browser.Goto("Register");
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("Register");
        }

        public void ClearAllRegirsterUserFormFields()
        {
            emailAddressField.Clear();
            passwordField.Clear();
            confirmPasswordField.Clear();
        }


        public void RegisterNewUser()
        {

            ClearAllRegirsterUserFormFields();

            var user = UserGenerator.Generate();
            emailAddressField.SendKeys(user.EmailAddress);
            passwordField.SendKeys(user.Password);
            confirmPasswordField.SendKeys(user.Password);
            
            registerButton.Click();
        }
    }
}

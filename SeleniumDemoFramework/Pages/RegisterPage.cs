using SeleniumDemoFramework.Generators;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumDemoFramework
{
    public class RegisterPage
    {

        [FindsBy(How = How.Name, Using = "first_name")]
        private IWebElement fullName;

        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement emailAddress;

        [FindsBy(How = How.Name, Using = "phone_number")]
        private IWebElement phoneNumber;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement password;

        [FindsBy(How = How.CssSelector, Using = "login-holder > div:nth-child(2) > div:nth-child(1) > form:nth-child(2) > button:nth-child(2)")]
        private IWebElement registerButton;


        public void ClearAllRegirsterUserFormFields()
        {
            fullName.Clear();
            emailAddress.Clear();
            phoneNumber.Clear();
            password.Clear();
        }


        public void RegisterNewUser()
        {

            ClearAllRegirsterUserFormFields();

            var user = UserGenerator.Generate();
            fullName.SendKeys(user.FullName);
            emailAddress.SendKeys(user.EmailAddress);
            phoneNumber.SendKeys(user.MobileNumber);
            password.SendKeys(user.Password);
            
            registerButton.Click();
        }
    }
}

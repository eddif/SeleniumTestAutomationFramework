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

        #region GENERAL PAGE ELEMENTS

        [FindsBy(How = How.ClassName, Using = "price")]
        private IWebElement priceField;

        #endregion
        #region SELECTED SERVICES

        [FindsBy(How = How.CssSelector, Using = "div.feature:nth-child(1)")]
        private IWebElement schedulingPlan;

        [FindsBy(How = How.CssSelector, Using = "div.feature:nth-child(2)")]
        private IWebElement attendancePlan;

        [FindsBy(How = How.CssSelector, Using = ".scheduling-plan.plan-active")]
        private IWebElement schedulingPlanActive;

        [FindsBy(How = How.CssSelector, Using = ".attendance-plan.plan-active")]
        private IWebElement attendancePlanActive;

        #endregion
        #region PRICING TYPE

        [FindsBy(How = How.Id, Using = "monthly_link")]
        private IWebElement monthlyPricingType;

        [FindsBy(How = How.Id, Using = "annually_link")]
        private IWebElement annuallyPricingType;

        #endregion
        #region SLIDE BAR

        [FindsBy(How = How.ClassName, Using = "handle")]
        private IWebElement pricingSlider;

        [FindsBy(How = How.ClassName, Using = "slider-bar")]
        private IWebElement sliderBar;
        
        #endregion
        #region COUNTRY DROPDOWN

        [FindsBy(How = How.ClassName, Using = "country-select-link")]
        public IWebElement countrySupport { get; set; }

        [FindsBy(How = How.ClassName, Using = "country")]
        public IList<IWebElement> listOfCountries;

        #endregion

        int numberofpixels;
        // private static IWebDriver driver;
        // public IWebDriver driver;

        public void Goto()
        {
            Browser.Goto("pricing");
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("Employee Scheduling and Time Clock Software Pricing");
        }

        public void SelectSchedulingPlan()
        {

            if (Extensions.Exists(schedulingPlanActive))
                return;

            schedulingPlan.Click();
        }

        public void SelectAttendancePlan()
        {
            if (Extensions.Exists(attendancePlanActive))
                return;

            attendancePlan.Click();
        }

        public void SelectBothAttendanceAndSchedulingPlans()
        {
            SelectSchedulingPlan();
            SelectAttendancePlan();
        }

        public void SelectMonthlyPricingType()
        {
           
            annuallyPricingType.Click();
            monthlyPricingType.Click();
        }

        public void SelectAnnuallyPricingType()
        {
            annuallyPricingType.Click();
        }

        public void MovePricingSlider(int count, int range)
        {

            if (count <= 5)
                numberofpixels = -150;
            if (count > 5 && count <= 10)
                numberofpixels = -100;
            if (count > 10 && count <= 20)
                numberofpixels = 0;
            if (count > 20 && count <= 30)
                numberofpixels = 20;

            int widthofslidebar = sliderBar.Size.Width;

            //user set
            Actions slider = new Actions(Browser._Driver);
            slider.ClickAndHold(pricingSlider).MoveByOffset(numberofpixels, range).Build().Perform();
            Thread.Sleep(1000);
        }

        public void SelectCountry(string countryname)
        {

            countrySupport.Click();

            IList<IWebElement> list = listOfCountries;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Text.ToLower() == countryname.ToLower())
                    list[i].Click();
            }

            WaitForAjax();
        }

        public void WaitForAjax()
        {
            try
            {
                while (true) // Handle timeout somewhere
                {
                    var ajaxIsComplete = (bool)(Browser._Driver as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0");
                    if (ajaxIsComplete)
                        break;
                    Thread.Sleep(100);
                }
            }
            catch (Exception e)
            {
            }
        }

        //public GetDisplayedPrice(IList<string> List)
        //{

        //    var results = new List<List<string>>();
        //    var allRows = searchResults.FindElements(By.TagName("tr"));

        //    if (priceField.Text == "")


        //    foreach (var row in allRows)
        //    {
        //        var cells = row.FindElements(By.TagName("td"));
        //        var result = cells.Select(cell => cell.Text).ToList();
        //        results.Add(result);
        //    }

        //    return results;

        //}




    }
}

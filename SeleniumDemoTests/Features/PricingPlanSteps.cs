using System;
using TechTalk.SpecFlow;
using SeleniumDemoFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using NUnit.Framework;


namespace SeleniumDemoTests
{
    [Binding]
    public class PricingPlanSteps
    {
        
        private IWebDriver driver;
        

        [BeforeScenario()]
        public void Setup()
        {
           // driver = new FirefoxDriver();
        }

        [AfterScenario()]
        public void TearDown()
        {
            driver.Quit();
        }


        [Given(@"I am on the Pricing Page")]
        public void GivenIAmOnThePricingPage()
        {
            Pages.Pricing.Goto();
            Pages.Pricing.IsAt();
        }
        
        [Given(@"I have selected the ""(.*)"" service type only")]
        public void GivenIHaveSelectedTheServiceTypeOnly(string service_type)
        {
            Pages.Pricing.SelectSchedulingPlan();
        }
        
        [Given(@"I toggle price plan to ""(.*)""")]
        public void GivenITogglePricePlanTo(string pricing_type)
        {
            Pages.Pricing.SelectMonthlyPricingType();
        }
        
        [Given(@"Local Text Message support is ""(.*)""")]
        public void GivenLocalTextMessageSupportIs(string country)
        {
            Pages.Pricing.SelectCountry(country);
        }

        [When(@"I update Pricing Slider to (.*)")]
        public void WhenIUpdatePricingSliderTo(int numberofusers)
        {
            Pages.Pricing.MovePricingSlider(numberofusers, 0);
        }

        [Then(@"the price amount displayed is (.*)")]
        public void ThenThePriceAmountDisplayedIs(Table table)
        {

            //var results = searchResultsPage.GetResults();
            //var i = 1; //ignore the header

            //foreach (var row in table.Rows)
            //{
            //    Assert.IsTrue(results[i].Contains(row["Event Code"]));
            //    Assert.IsTrue(results[i].Contains(row["Event Name"]));
            //    Assert.IsTrue(results[i].Contains(row["Region"]));
            //    Assert.IsTrue(results[i].Contains(row["Description"]));
            //    i++;
            //}



        }
    }
}

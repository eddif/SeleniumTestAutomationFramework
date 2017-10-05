# Selenium Example - Using C#.NET, Selenium, and the NUnit Test Runner

This solution demonstrates a scalable, maintainable, readable and repeatable Automation Framework:

Key Design Elements:
1. Architecture Layers include Tests, Framework, Selenium Page Objects and Browser.
2. Page Object Pattern - clear seperation of pages versus test cases and represtative of the application.
3. All page classes contructors are called via a Single Generic type of page.
* See: SeleniumDemoFramework/Pages/Page.cs
* Allows webdriver to only be instatiated once versus the overhead of passing the driver from page to page. 
4. Test cases do not include hard coded data, variables or the need to perform instatiation of any object type.
* See: SeleniumDemoTests\SmokeTests.cs
* See: SeleniumDemoTests\Features\TopNavigationTests.cs
* This creates a type of Internal DSL where test cases are written and read as a user might perfrom them. Making test cases easy to write, simple to create, and maintainable.
5. Test cases never manage the state.
6. Extension Methods 
* See: SeleniumDemoFramework/Extensions/
7. Data Generators
* See: SeleniumDemoFramework/Generators/
8. KeyWord driven data via Excel
* See: SeleniumDemoFramework/TestData/
9. Base Class which can be extended to handle Initializations before Test Suites are executed.
* Ideal for Event threading such as realtime reporting

 
To Use:

Required: 

* Firefox installed

Steps to execute:

* Note: All selenium dependencies are included in the solution.

* Extract Zip to local drive

* Open: \packages\nunit_runnable\bin\nunit.exe

* Click File > Open project and open \SeleniumDemoTests\bin\Debug\SeleniumDemoTests.dll

* Select tests to run

* Click Run

Current Versions:
* Visual Studio: 2015 or above
* Selenium WebDriver: 2.48.2
* NUnit 2.6.4
* SpecFlow: 1.9.0.77



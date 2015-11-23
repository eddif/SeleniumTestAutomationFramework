using WIWDemoFramework.Generators;
using NUnit.Framework;

namespace WIWDemoFramework
{
    [TestFixture]
    public class TestBase
    {
        [TestFixtureSetUp]
        public static void Initialize()
        {
            Browser.Initialize();
            UserGenerator.Initialize();
        }        

        [TestFixtureTearDown]
        public static void TestFixtureTearDown()
        {
            Browser.Close();
        }

        [TearDown]
        public static void TearDown()
        {

            // Implement clean logout for user, remove session storage etc...) 

            //will hack for now
            Browser.Goto("");

            //if(Pages.TopNavigation.IsLoggedIn())
            //    Pages.TopNavigation.LogOut();

            //if(UserGenerator.LastGeneratedUser != null)
            //    Browser.Goto("????");
        }
    }
}

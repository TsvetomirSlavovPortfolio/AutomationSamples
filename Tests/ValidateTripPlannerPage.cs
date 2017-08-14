using Framework.AndroidPages;
using NUnit.Framework;

namespace TestsAppium
{
    [TestFixture]
    public class ValidateTripPlannerPage : TestBase
    {
        [Test]
        [Description("Verify the main links in the landing page.")]
        public void TestMethod1()
        {
            Pages.TripPlanner.Goto();
            Assert.AreEqual("System Map", Pages.TripPlanner.FindElement("System Map"), "System Map link is missing.");
            Assert.AreEqual("Train Schedule", Pages.TripPlanner.FindElement("Train Schedule"),
                "Train Schedule link is missing.");
            Assert.AreEqual("Google Trip Planner", Pages.TripPlanner.FindElement("Google Trip Planner"),
                "Google Trip Planner link is missing.");
            Assert.AreEqual("Destinations", Pages.TripPlanner.FindElement("Destinations"),
                "Destinations link is missing.");
            Assert.AreEqual("Tri-Rail Tracker", Pages.TripPlanner.FindElement("Tri-Rail Tracker"),
                "Tri-Rail Tracker link is missing.");
        }

    }
}

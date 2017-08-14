using Framework.AndroidPages;
using NUnit.Framework;

namespace TestsAppium
{
    [TestFixture]
    public class ValidateMainTriRailPage : TestBase
    {
        [Test]
        [NUnit.Framework.Description("Verify the main links in the landing page.")]
        public void TestMethod1()
        {
            Assert.AreEqual("Trip Planner", Pages.TriRailMain.FindElement("Trip Planner"), "Trip Planner link is missing.");
            Assert.AreEqual("Fares", Pages.TriRailMain.FindElement("Fares"), "Fares link is missing.");
            Assert.AreEqual("General Information", Pages.TriRailMain.FindElement("General Information"), "General Information link is missing.");
            Assert.AreEqual("Alerts", Pages.TriRailMain.FindElement("Alerts"), "Alerts link is missing.");
        }

    }
}

using Framework.AndroidPages;
using NUnit.Framework;

namespace TestsAppium
{
    [TestFixture]
    public class ValidateFaresPage : TestBase
    {
        [Test]
        [Description("Verify the main links in the landing page.")]
        public void TestFaresPage()
        {
            Pages.Fares.Goto();
            Assert.AreEqual("Fare Information", Pages.Fares.FindElement("Fare Information"), "Fare Information link is missing.");
            Assert.AreEqual("Fare Calculator", Pages.Fares.FindElement("Fare Calculator"), "Fare Calculator link is missing.");
            Assert.AreEqual("Transfers", Pages.Fares.FindElement("Transfers"), "Transfers link is missing.");
            Assert.AreEqual("Discount Policy", Pages.Fares.FindElement("Discount Policy"), "Discount Policy link is missing.");

        }

    }
}

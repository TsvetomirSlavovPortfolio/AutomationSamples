using Framework;
using Framework.AndroidPages;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TestsAppium
{
    [TestFixture]
    public class Demo : TestBase
    {
        const string param1 = "FareCalculator.xlsx";

        [Test]
        [TestCaseSource(typeof(ExcelDataParser), nameof(Test), new object[] { param1 })]

        public void TestDemo(string departureStation, string arrivalStation, string typeOfTrip, string dayOfTravel, string fare)
        {
            Pages.FareCalculator.Goto();
            Assert.IsTrue(Pages.FareCalculator.CalculateFare(departureStation, arrivalStation, typeOfTrip, dayOfTravel, fare), "Fare Information link is missing.");
            Pages.FareCalculator.Reset();
        }
    }
}

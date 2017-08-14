using Framework;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Pages = Framework.AndroidPages.Pages;

namespace TestsAppium
{
    [TestFixture]
    public class ValidateFareCalculatorPage : TestBase
    {
        /*[Test]
        [Description("Verify the main links in the landing page.")]
        public void ValidateFareCalcuatorPage_old()
        {
            Pages.FareCalculator.Goto();
            //Assert.IsTrue(Pages.FareCalculator.CalculateFare("Delray Beach", "Fort Lauderdale Airport", "One Way", "Weekday", "$  5.65"), "Fare Information link is missing.");

            List<string> rowValue = new List<string> { };

            var ExcelFilePath = @"C:\temp\MobileFramework\AppiumSeleniumPOM\Tests\TestData\FareCalculator.xlsx";

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ExcelFilePath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            for (int i = 2; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    rowValue.Add(xlRange.Cells[i, j].Value2.ToString());
                }
                
                //Console.WriteLine(rowValue[0] + " - " + rowValue[1] + " - " + rowValue[2] + " - " + rowValue[3] + " - " + rowValue[4]);

                departureStation = rowValue[0];
                arrivalStation = rowValue[1];
                typeOfTrip = rowValue[2];
                dayOfTravel = rowValue[3];
                fare = rowValue[4];

                //CalculateFare(departureStation, arrivalStation, typeOfTrip, dayOfTravel, fare);
                Assert.IsTrue(Pages.FareCalculator.CalculateFare(departureStation, arrivalStation, typeOfTrip, dayOfTravel, fare), "Fare Information link is missing.");
                rowValue.Clear();
                Pages.FareCalculator.Reset();
            }
            //Console.Read();
            xlWorkbook.Close();
            xlApp.Quit();
        }*/

        const string param1 = "FareCalculator.xlsx";

        [Test]
        [Description("Verify the main links in the landing page.")]
        [TestCaseSource(typeof(ExcelDataParser), nameof(Test), new object[] { param1 })]

        public void TestDemo(string departureStation, string arrivalStation, string typeOfTrip, string dayOfTravel, string fare)
        {
            Pages.FareCalculator.Goto();
            Assert.IsTrue(Pages.FareCalculator.CalculateFare(departureStation, arrivalStation, typeOfTrip, dayOfTravel, fare), "Fare Information link is missing.");
            Pages.FareCalculator.Reset();
        }
    }
}

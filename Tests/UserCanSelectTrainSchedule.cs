using Framework.AndroidPages;
using NUnit.Framework;

namespace TestsAppium
{
    [TestFixture]
    public class UserCanSelectTrainSchedule : TestBase
    {
        [Test]
        public void TestMethod1()
        {
            Pages.TrainSchedule.Goto();
            Pages.TrainSchedule.SelectSchedule("Boca Raton", "Fort Lauderdale", "Weekday");
            Pages.TrainSchedule.ShowSchedule();
            Assert.IsTrue(Pages.Schedule.IsCorrectSchedule("Boca Raton", "Fort Lauderdale", "Weekday"), "The Schedule for {0} to {1} on {2} was not displayed.", "Boca Raton", "Fort Lauderdale", "Weekday");
            Pages.Schedule.Back();
        }

        [Test]
        public void TestMethod2()
        {
            Pages.TrainSchedule.Goto();
            Pages.TrainSchedule.SelectSchedule("Delray Beach", "Fort Lauderdale Airport", "Weekday");
            Pages.TrainSchedule.ShowSchedule();
            Assert.IsTrue(Pages.Schedule.IsCorrectSchedule("Delray Beach", "Fort Lauderdale Airport", "Weekday"), "The Schedule for {0} to {1} on {2} was not displayed.", "Delray Beach", "Fort Lauderdale Airport", "Weekday");
            Pages.Schedule.Back();
        }

        [Test]
        public void TestMethod3()
        {
            Pages.TrainSchedule.Goto();
            Pages.TrainSchedule.SelectSchedule("West Palm Beach", "Miami Airport", "Weekdend / Holiday");
            Pages.TrainSchedule.ShowSchedule();
            Assert.IsTrue(Pages.Schedule.IsCorrectSchedule("West Palm Beach", "Miami Airport", "Weekdend / Holiday"), "The Schedule for {0} to {1} on {2} was not displayed.", "West Palm Beach", "Miami Airport", "Weekdend / Holiday");
            Pages.Schedule.Back();
        }
    }
}    

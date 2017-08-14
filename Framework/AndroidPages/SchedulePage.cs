using OpenQA.Selenium.Appium.Android;

namespace Framework.AndroidPages
{
    public class SchedulePage
    {
        public bool IsCorrectSchedule(string departureStation, string arrivalStation, string dayOfTravel)
        {
            bool isCorrect = false;

            isCorrect = (App._driver.FindElementByXPath("//android.view.View[@content-desc='" + departureStation + "']").Displayed && App._driver.FindElementByXPath("//android.view.View[@content-desc='" + arrivalStation + "']").Displayed && App._driver.FindElementByXPath("//android.view.View[@content-desc='" + dayOfTravel + "']").Displayed);
            return isCorrect;
        }

        public void Back()
        {
            App._driver.PressKeyCode(AndroidKeyCode.Back);
        }
    }
}
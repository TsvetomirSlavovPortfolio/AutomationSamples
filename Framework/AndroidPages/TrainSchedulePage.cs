namespace Framework.AndroidPages
{
    public class TrainSchedulePage
    {
        public void Goto()
        {
            App.Goto("Trip Planner");
            App.Goto("Train Schedule");
        }

        public void SelectSchedule(string departureStation, string arrivalStation, string dayOfTravel)
        {
            App._driver.FindElementByAndroidUIAutomator("UiSelector().text(\"Departure Station\")").Tap(1,2);
            App._driver.FindElementByXPath("//android.widget.CheckedTextView[@text='" + departureStation + "']").Tap(1, 2);
            App._driver.FindElementByAndroidUIAutomator("UiSelector().text(\"Arrival Station\")").Tap(1,2);
            App._driver.FindElementByXPath("//android.widget.CheckedTextView[@text='" + arrivalStation + "']").Tap(1, 2);
            App._driver.FindElementByAndroidUIAutomator("UiSelector().text(\"Day of Travel\")").Tap(1, 2);
            App._driver.FindElementByXPath("//android.widget.CheckedTextView[@text='" + dayOfTravel + "']").Tap(1, 2);

        }

        public void ShowSchedule()
        {
            App._driver.FindElementByClassName("android.widget.Button").Tap(1, 2);
        }
    }
}
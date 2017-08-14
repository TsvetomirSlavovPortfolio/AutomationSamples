using OpenQA.Selenium.Appium.Android;

namespace Framework.AndroidPages

{
    public class FareCalculatorPage
    {
         public void Goto()
        {
            App.Goto("Fares");
            App.Goto("Fare Calculator");
        }

        public bool CalculateFare(string departureStation, string arrivalStation, string typeOfTrip, string dayOfTravel, string fare)
        {
            App._driver.FindElementByAndroidUIAutomator("UiSelector().text(\"Departure Station\")").Tap(1, 2);
            App._driver.FindElementByXPath("//android.widget.CheckedTextView[@text='" + departureStation + "']").Tap(1, 2);
            App._driver.FindElementByAndroidUIAutomator("UiSelector().text(\"Arrival Station\")").Tap(1, 2);
            App._driver.FindElementByXPath("//android.widget.CheckedTextView[@text='" + arrivalStation + "']").Tap(1, 2);
            App._driver.FindElementByAndroidUIAutomator("UiSelector().text(\"Type of Trip\")").Tap(1, 2);
            App._driver.FindElementByXPath("//android.widget.CheckedTextView[@text='" + typeOfTrip + "']").Tap(1, 2);
            App._driver.FindElementByAndroidUIAutomator("UiSelector().text(\"Day of Travel\")").Tap(1, 2);
            App._driver.FindElementByXPath("//android.widget.CheckedTextView[@text='" + dayOfTravel + "']").Tap(1, 2);
            //Click Calculate button
            App._driver.FindElementByClassName("android.widget.Button").Tap(1, 2);
            return App._driver.FindElementByAndroidUIAutomator("UiSelector().text(" + "\"" + fare + "\")").Displayed;
        }

        public void Reset()
        {
            App._driver.PressKeyCode(AndroidKeyCode.Back);
            App.Goto("Fare Calculator");
        }
    }
}
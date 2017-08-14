namespace Framework.AndroidPages
{
    public class TripPlannerPage
    {
        public string FindElement(string el)
        {
            return App._driver.FindElementByAndroidUIAutomator("UiSelector().text(" + "\"" + el + "\")").GetAttribute("text");
        }

        public void Goto()
        {
            App.Goto("Trip Planner");
        }
    }
}
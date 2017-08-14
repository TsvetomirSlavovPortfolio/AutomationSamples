namespace Framework.AndroidPages
{
    public class TriRailMainPage
    {
        public string FindElement(string el)
        {
            return App._driver.FindElementByAndroidUIAutomator("UiSelector().text(" + "\"" + el + "\")").GetAttribute("text");
        }
    }
}
namespace Framework.AndroidPages
{
    public class FaresPage
    {
        public void Goto()
        {
            App.Goto("Fares");
        }

        public object FindElement(string el)
        {
            return App._driver.FindElementByAndroidUIAutomator("UiSelector().text(" + "\"" + el + "\")").GetAttribute("text");
        }
    }
}
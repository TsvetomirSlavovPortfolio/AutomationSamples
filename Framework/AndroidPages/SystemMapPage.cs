namespace Framework.AndroidPages
{
    public class SystemMapPage
    {
        public void Goto()
        {
            App.Goto("Trip Planner");
            App.Goto("System Map");
        }

        public bool IsPresent()
        {
            return App._driver.FindElementByXPath("//android.widget.Image[@content-desc='system_map_v2']").Displayed;
        }
    }
}
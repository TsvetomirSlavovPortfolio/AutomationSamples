using Framework;
using OpenQA.Selenium;

namespace TestsMyStore
{
    public class MyAccountPage
    {
        private int PAGE_LOAD_TIMEOUT = 10;

        public bool IsAt()
        {
            By element = By.XPath(".//a[@class='account']");
            return Browser.WaitUntilElementIsDisplayed(element, PAGE_LOAD_TIMEOUT);
        }

        public void Logout()
        {
            Browser.FindElement(By.ClassName("loglout")).Click();
        }
    }
}
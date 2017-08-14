using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Firefox;
using Actions = OpenQA.Selenium.Interactions.Actions;

namespace Framework
{
    public enum Drivers
    {
        Chrome,
        Firefox,
        Ie
    }
    public static class Browser
    {

        private static IWebDriver _webDriver;

        private static string _baseUrl = "http://automationpractice.com/index.php";

        internal static void SwitchTabs(int tabIndex)
        {
            var windows = _webDriver.WindowHandles;
            _webDriver.SwitchTo().Window(windows[tabIndex]);
        }

        internal static IWebDriver GetDriver(Drivers driver)
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var relativePath = @"..\..\..\Framework\Drivers";

            switch (driver)
            {
                case Drivers.Chrome:                  
                    var chromeDriverPath = Path.GetFullPath(Path.Combine(outPutDirectory, relativePath));
                    return new ChromeDriver(chromeDriverPath);
                case Drivers.Firefox:
                     return new FirefoxDriver();
                default:
                    throw new NotImplementedException("I do not know the driver that you supplied.");
            }

        }

        public static bool WaitUntilElementIsDisplayed(By element, int timeoutInSeconds)
        {
            for (int i = 0; i < timeoutInSeconds; i++)
            {
                if (ElementIsDisplayed(element))
                {
                    return true;
                }
                Thread.Sleep(1000);
            }
            return false;
        }

        internal static IWebElement FindElement(By by)
        {
            return _webDriver.FindElement(by);
        }

        public static bool ElementIsDisplayed(By element)
        {
            var present = false;
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            try
            {
                present = _webDriver.FindElement(element).Displayed;
            }
            catch (NoSuchElementException)
            {
            }
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return present;
        }

        public static ISearchContext Driver => _webDriver;
        public static string Title => _webDriver.Title;

        public static void Initialize()
        {
            _webDriver = GetDriver(Drivers.Chrome);
            Goto("");
        }

        public static void Close()
        {
            _webDriver.Close();
        }

        public static void Goto(string url, bool useBaseUrl = true)
        {
            if (useBaseUrl)
                _webDriver.Navigate().GoToUrl(string.Format("{0}/{1}", _baseUrl, url));
            else
                _webDriver.Navigate().GoToUrl(url);
        }

        public static void HoverAndSelect(IWebElement hoverElement, string clickElement)
        {
            Actions action = new Actions(_webDriver);
            var el2 = Driver.FindElement(By.XPath(".//*[@title='" + clickElement + "']"));
            action.MoveToElement(hoverElement).Perform();
            action.Click(el2).Perform();
        }

        public static void Quit()
        {
            _webDriver.Quit();
        }

        public static void EmptyCart()
        {
            Actions action = new Actions(_webDriver);
            //Find the cart control
            action.MoveToElement(Driver.FindElement(By.XPath(".//a[@title='View my shopping cart']"))).Perform();

            //Iterate through all items and click the X
            Thread.Sleep(3000);
            IWebElement cartItems = Driver.FindElement(By.ClassName("products"));
            foreach (IWebElement child in cartItems.FindElements(By.XPath(".//a[@class='ajax_cart_block_remove_link']")))
                child.Click();
        }

    }
}
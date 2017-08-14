using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;


namespace Framework
{
    public static class App
    {
        public static AndroidDriver<AndroidElement> _driver;
        private static Uri testServerAddress = new Uri("http://127.0.0.1:4723/wd/hub");
        private static TimeSpan INIT_TIMEOUT_SEC = TimeSpan.FromSeconds(180);
        private static TimeSpan IMPLICIT_TIMEOUT_SEC = TimeSpan.FromSeconds(10);
        public static ISearchContext Driver => _driver;
        

        public static void Initialize()
        {
            DesiredCapabilities capability = new DesiredCapabilities();
            capability.SetCapability("appPackage", "com.trirail.android");
            capability.SetCapability("appActivity", "com.trirail.android.TriRailActivity");
            capability.SetCapability("deviceName", "Galaxy J7 Perx");
            capability.SetCapability("platformVersion", "7.0");
            capability.SetCapability("platformName", "Android");
            capability.SetCapability(MobileCapabilityType.AppiumVersion, "1.6.5");

            _driver = new AndroidDriver<AndroidElement>(testServerAddress, capability, INIT_TIMEOUT_SEC);
            _driver.Manage().Timeouts().ImplicitWait = IMPLICIT_TIMEOUT_SEC;
        }

        public static void Quit()
        {
            Thread.Sleep(3000);
            _driver.Quit();
        }

        public static void Goto(string page)
        {
           _driver.FindElementByAndroidUIAutomator("UiSelector().text(" + "\"" + page + "\")").Tap(1, 2);
        }
       
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Remote;



namespace Tests
{
    [TestFixture]
    public class TestBase1
    {
        private static AndroidDriver<AndroidElement> _driver;
        private static Uri testServerAddress = new Uri("http://10.0.0.112:4723/wd/hub");
        private static TimeSpan INIT_TIMEOUT_SEC = TimeSpan.FromSeconds(180);
        private static TimeSpan IMPLICIT_TIMEOUT_SEC = TimeSpan.FromSeconds(10);
        DesiredCapabilities capability = new DesiredCapabilities();

    }
    [Setup]
    public void Init()
        {
            App.Initialize();
        }
    }

    public static class App
    {
        private static AndroidDriver<AndroidElement> _driver;
        private static Uri testServerAddress = new Uri("http://10.0.0.112:4723/wd/hub");
        private static TimeSpan INIT_TIMEOUT_SEC = TimeSpan.FromSeconds(180);
        private static TimeSpan IMPLICIT_TIMEOUT_SEC = TimeSpan.FromSeconds(10);

        public static void Initialize()
        {
            DesiredCapabilities capability = new DesiredCapabilities();
            capability.SetCapability("appPackage", "com.trirail.android");
            capability.SetCapability("appActivity", "com.trirail.android.TriRailActivity");
            capability.SetCapability("deviceName", "Galaxy J7 Perx");
            //capability.SetCapability("deviceName", "Cosmic Charley");
            capability.SetCapability("platformVersion", "7.0");
            capability.SetCapability("platformName", "Android");
            capability.SetCapability(MobileCapabilityType.AppiumVersion, "1.6.5");

            _driver = new AndroidDriver<AndroidElement>(testServerAddress, capability, INIT_TIMEOUT_SEC);
            _driver.Manage().Timeouts().ImplicitlyWait(IMPLICIT_TIMEOUT_SEC);
        }
    }
}

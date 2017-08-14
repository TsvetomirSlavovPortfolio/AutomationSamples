using System;
using Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace TestsMyStore
{
    public class HomePage
    {
        private int PAGE_LOAD_TIMEOUT = 10;

        public void Goto()
        {
            Browser.Goto("http://automationpractice.com/index.php", false);
        }

        public void HoverAndSelect(string hoverElement, string clickElement)
        {
            var el = Browser.Driver.FindElements(By.XPath(".//*[@title='" + hoverElement + "']"))[0];
            Browser.HoverAndSelect(el, clickElement);
        }

        public void EmptyCart()
        {
            Browser.EmptyCart();
        }

        public bool CartIsEmpty()
        {
            By element = By.XPath(".//a[@title='View my shopping cart']/*[contains(text(), '(empty)')]");
            return Browser.WaitUntilElementIsDisplayed(element, PAGE_LOAD_TIMEOUT);
        }
    }
}
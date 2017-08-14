using System;
using System.Threading;
using OpenQA.Selenium;

namespace Framework.WebPages
{
    public class ItemCartPage
    {
        private int PAGE_LOAD_TIMEOUT = 10;

        public void ContinueShopping()
        {
            Browser.WaitUntilElementIsDisplayed(By.XPath("//*[contains(@title,\'Continue shopping\')]"), PAGE_LOAD_TIMEOUT);
            Browser.FindElement(By.XPath("//*[contains(@title,\'Continue shopping\')]")).Click();
        }

        public bool CorrectCartItems(int quantity, string size, string color)
        {
            bool isCorrect = false;
            Browser.WaitUntilElementIsDisplayed(By.Id("layer_cart_product_attributes"), PAGE_LOAD_TIMEOUT);
            Browser.WaitUntilElementIsDisplayed(By.Id("layer_cart_product_quantity"), PAGE_LOAD_TIMEOUT);
            isCorrect = (Browser.FindElement(By.Id("layer_cart_product_attributes")).Text.Contains(color + ", " + size) && Browser.FindElement(By.Id("layer_cart_product_quantity")).Text.Contains(Convert.ToString(quantity)));
            return isCorrect;
        }
    }
}
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.WebPages
{
    public class ProductPage
    {
        public void SelectAndAddToCart(int quantity, string size, string color)
        {
            //Set the Quantity of items
            for (int i = 1; i < quantity; i++)
                Browser.FindElement(By.ClassName("icon-plus")).Click();

            //Select the Size
            var sizeElement = Browser.FindElement(By.Id("group_1"));
            var selectElement = new SelectElement(sizeElement);
            selectElement.SelectByText(size);

            //Select the Color
            Browser.FindElement(By.Name(color)).Click();

            //Click Add to cart
            Browser.FindElement(By.Id("add_to_cart")).Click();

        }
    }
}
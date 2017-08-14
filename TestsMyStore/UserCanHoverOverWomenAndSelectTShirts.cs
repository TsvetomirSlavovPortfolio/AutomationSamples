using Framework.WebPages;
using NUnit.Framework;

namespace TestsMyStore
{
    public class UserCanHoverOverWomenAndSelectTShirts : TestBase
    {
        [Test]
        public void UserCanHoverOverWomenAndSelectTShirts1()
        {
            WebPages.Home.Goto();
            WebPages.Home.HoverAndSelect("Women", "T-shirts");
            Assert.IsTrue(WebPages.Catalog.IsTopic("T-shirts"));
        }

        [Test]
        public void UserCanSelectBlueTshirtAndAddToCart()
        {
            int quantity = 2;
            string size = "M";
            string color = "Blue";
            string item = "Faded Short Sleeve T-shirts";

            WebPages.Home.Goto();
            WebPages.Home.HoverAndSelect("Women", "T-shirts");
            WebPages.Home.HoverAndSelect(item, item);
            WebPages.Product.SelectAndAddToCart(quantity, size, color);
            Assert.IsTrue(WebPages.ItemCart.CorrectCartItems(quantity, size, color));
            WebPages.ItemCart.ContinueShopping();
        }
    }
}

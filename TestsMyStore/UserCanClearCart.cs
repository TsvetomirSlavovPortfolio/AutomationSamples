using System.Threading;
using Framework.WebPages;
using NUnit.Framework;


namespace TestsMyStore
{
    public class UserCanClearCart : TestBase
    {
        [Test]
        public void UserCanClearCartOfAllSelectedItems1()
        {
            int quantity = 1;
            string size1 = "L";
            string color1 = "Orange";
            string item1 = "Faded Short Sleeve T-shirts";

            string size2 = "M";
            string color2 = "Yellow";
            string item2 = "Printed Summer Dress";

            //Select first item
            WebPages.Home.Goto();
            WebPages.Home.HoverAndSelect("Women", "T-shirts");
            WebPages.Home.HoverAndSelect(item1, item1);
            WebPages.Product.SelectAndAddToCart(quantity, size1, color1);
            Assert.IsTrue(WebPages.ItemCart.CorrectCartItems(quantity, size1, color1));
            WebPages.ItemCart.ContinueShopping();
            //Select 2nd item
            WebPages.Home.Goto();
            WebPages.Home.HoverAndSelect("Women", "Summer Dresses");
            WebPages.Home.HoverAndSelect(item1, item2);
            WebPages.Product.SelectAndAddToCart(quantity, size2, color2);
            Assert.IsTrue(WebPages.ItemCart.CorrectCartItems(quantity, size2, color2));
            WebPages.ItemCart.ContinueShopping();
            Thread.Sleep(3000);
            //Empty the cart
            WebPages.Home.EmptyCart();
            Assert.IsTrue(WebPages.Home.CartIsEmpty(), "The cart is not empty");
        }
    }
}

using OpenQA.Selenium.Support.PageObjects;
using TestsMyStore;

namespace Framework.WebPages
{
    public static partial class WebPages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

        public static MyAccountPage MyAccount
        {
            get { return GetPage<MyAccountPage>();}
        }

        public static HomePage Home
        {
            get { return GetPage<HomePage>(); }
        }

        public static CatalogPage Catalog
        {
            get { return GetPage<CatalogPage>(); }
        }

        public static ProductPage Product
        {
            get {return GetPage<ProductPage>();}
        }

        public static ItemCartPage ItemCart
        {
            get { return GetPage<ItemCartPage>(); }
        }
    }
}
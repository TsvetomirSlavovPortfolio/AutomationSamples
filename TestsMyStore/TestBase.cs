using Framework;
using NUnit.Framework;

namespace TestsMyStore
{
    public class TestBase
    {
        [SetUp]
        public void Initialize()
        {
            Browser.Initialize();
        }

        [TearDown]
        public void Cleanup()
        {
            Browser.Close();
            Browser.Quit();
        }
    }
}

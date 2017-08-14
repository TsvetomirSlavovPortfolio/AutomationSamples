using Framework;
using NUnit.Framework;

namespace TestsAppium
{
    [TestFixture]
    public class TestBase
    {
        [SetUp]
        public static void Initialize()
        {
            App.Initialize();
        }

        [TearDown]
        public static void Cleanup()
        {
            App.Quit();
        }
    }
}

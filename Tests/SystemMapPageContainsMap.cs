using Framework.AndroidPages;
using NUnit.Framework;

namespace TestsAppium
{
    [TestFixture]
    public class SystemMapPageContainsMap : TestBase
    {
        [Test]
        public void TestMethod1()
        {
            Pages.SystemMap.Goto();
            Assert.IsTrue(Pages.SystemMap.IsPresent(), "The System Map was not found.");
        }
    }
}

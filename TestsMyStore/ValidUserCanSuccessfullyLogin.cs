using Framework.WebPages;
using NUnit.Framework;

namespace TestsMyStore
{
    public class ValidUserCanSuccessfullyLogin : TestBase
    {
        
        [Test]
        public void ValidUserCanSuccessfullyLogin1()
        {
            WebPages.Login.Goto();
            WebPages.Login.Login("tester99@test.com", "xxx");
            Assert.IsTrue(WebPages.MyAccount.IsAt(), "A valid user was unable to successfully login.");
        }
    }
}

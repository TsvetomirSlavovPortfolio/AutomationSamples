using Framework.WebPages;
using NUnit.Framework;

namespace TestsMyStore
{
    public class InValidUserCannotSuccessfullyLogin : TestBase
    {
        
        [Test]
        public void InValidUserCannotSuccessfullyLogin1()
        {
            WebPages.Login.Goto();
            WebPages.Login.Login("tester@test.com", "xxxx");
            Assert.IsFalse(WebPages.MyAccount.IsAt(), "A Invalid user was able to successfully login.");
        }
    }
}

using Framework;
using OpenQA.Selenium;

namespace TestsMyStore
{
    public class LoginPage
    {
        public void Goto()
        {
            Browser.Goto("?controller=authentication&back=my-account");
        }

        public void Login(string userEmail, string password)
        {
            Browser.Driver.FindElement((By.Id("email"))).SendKeys(userEmail);
            Browser.Driver.FindElement(By.Id("passwd")).SendKeys(password);
            Browser.Driver.FindElement(By.Id("SubmitLogin")).Click();
        }
    }
}
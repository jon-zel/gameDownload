using NUnit.Framework;
using gameDownload.infrastructure;

namespace gameDownload
{
    public class LoginPageTests
    {
        private LoginPageMethods loginPage = new LoginPageMethods();

        [SetUp]
        public void Setup()
        {
            loginPage.GetPageDriver().Manage().Window.Maximize();
            loginPage.GetPageDriver().Navigate().GoToUrl("https://torrent-igruha.org/");
        }

        [Test]
        public void CorrectLoggin()
        {
            bool isTheProfileConnected;
            loginPage.loginAsAutomation();
            loginPage.isTheProfileConnected(out isTheProfileConnected);
            if (isTheProfileConnected)
            {
                loginPage.logout();
            }
            Assert.IsTrue(isTheProfileConnected);
        }

        [Test]
        public void LogginWithoutPassword()
        {
            bool isTheProfileConnected;
            loginPage.loginWithoutPassword();
            loginPage.isTheProfileConnected(out isTheProfileConnected);
            if (isTheProfileConnected)
            {
                loginPage.logout();
            }
            Assert.IsFalse(isTheProfileConnected);
        }

        [Test]
        public void LogginWithoutUserName()
        {
            bool isTheProfileConnected;
            loginPage.loginWithoutUserName();
            loginPage.isTheProfileConnected(out isTheProfileConnected);
            if (isTheProfileConnected)
            {
                loginPage.logout();
            }
            Assert.IsFalse(isTheProfileConnected);
        }

        [TearDown]
        public void Close()
        {
            loginPage.GetPageDriver().Quit();
        }
    }
}
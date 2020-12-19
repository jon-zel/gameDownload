using NUnit.Framework;
using gameDownload.infrastructure;

namespace gameDownload
{
    public class LoginPageTests
    {
        private LoginPageMethods loginPage = new LoginPageMethods();
        private bool isTheProfileConnected;

        [SetUp]
        public void Setup()
        {
            isTheProfileConnected = false;
            loginPage.GetPageDriver().Manage().Window.Maximize();
            loginPage.GetPageDriver().Navigate().GoToUrl("https://torrent-igruha.org/");
        }

        [Test]
        public void CorrectLoggin()
        {
            loginPage.loginAsAutomation();
            loginPage.checkIfTheProfileConnected(out isTheProfileConnected);
            loginPage.logout(isTheProfileConnected);

            Assert.IsTrue(isTheProfileConnected);
        }

        [Test]
        public void LogginWithoutPassword()
        {
            loginPage.loginWithoutPassword();
            loginPage.checkIfTheProfileConnected(out isTheProfileConnected);
            loginPage.logout(isTheProfileConnected);
            Assert.IsFalse(isTheProfileConnected);
        }

        [Test]
        public void LogginWithoutUserName()
        {
            loginPage.loginWithoutUserName();
            loginPage.checkIfTheProfileConnected(out isTheProfileConnected);
            loginPage.logout(isTheProfileConnected);
            Assert.IsFalse(isTheProfileConnected);
        }

        [TearDown]
        public void Close()
        {
            loginPage.GetPageDriver().Quit();
        }
    }
}
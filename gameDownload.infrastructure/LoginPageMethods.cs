using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace gameDownload.infrastructure
{
    [TestClass]
    public class LoginPageMethods : LoginPageElements
    {

        [TestMethod]
        public void loginAsAutomation()
        {
            openLoginProfileButton.Click();
            userNameBox.SendKeys(getUserName());
            passwordBox.SendKeys(getPassword());
            loginButton.Click();
        }

        [TestMethod]
        public void loginWithoutPassword()
        {
            openLoginProfileButton.Click();
            userNameBox.SendKeys(getUserName());
            loginButton.Click();
        }

        [TestMethod]
        public void loginWithoutUserName()
        {
            openLoginProfileButton.Click();
            passwordBox.SendKeys(getPassword());
            loginButton.Click();
        }

        [TestMethod]
        public void checkIfTheProfileConnected(out bool profileConnected)
        {
            profileConnected = true;

            openLoginProfileButton.Click();

            if (!openLoginProfileButton.Text.Contains(getUserName()))
            {
                profileConnected = false;
            }
        }

        [TestMethod]
        public void logout(bool profileConnected)
        {
            if (profileConnected)
            {
                openLoginProfileButton.Click();
                logoutButton.Click();
            }
        }
    }
}

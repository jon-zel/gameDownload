using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace gameDownload.infrastructure
{
    [TestClass]
    public class LoginTests : LoginPage
    {
        [TestMethod]
        public void loginAsAutomation()
        {
            openLoginProfileButton.Click();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            userNameBox.SendKeys(getUserName());
            passwordBox.SendKeys(getPassword());
            loginButton.Click();
        }

        [TestMethod]
        public void loginWithoutPassword()
        {
            openLoginProfileButton.Click();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            userNameBox.SendKeys(getUserName());
            loginButton.Click();
        }

        [TestMethod]
        public void loginWithoutUserName()
        {
            openLoginProfileButton.Click();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            passwordBox.SendKeys(getPassword());
            loginButton.Click();
        }

        [TestMethod]
        public void isTheProfileConnected(out bool profileConnected)
        {
            profileConnected = true;

            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            openLoginProfileButton.Click();

            if (!openLoginProfileButton.Text.Contains(getUserName()))
            {
                profileConnected = false;
            }
        }


        [TestMethod]
        public void logout()
        {
            openLoginProfileButton.Click();
            logoutButton.Click();
        }
    }
}

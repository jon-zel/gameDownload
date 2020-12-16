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
        public void isTheProfileConnected(out bool profileConnected)
        {
            profileConnected = true;

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

using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace gameDownload.infrastructure
{
    public class LoginPage : basePage
    {
        // variables
        private const String username = "autoto";
        private const String password = "oop1234";

        // Login buttons
        private IWebElement openLoginProfileButton = webDriver.FindElement
           (By.Id("open-mini-profile"));
        private IWebElement userNameBox = webDriver.FindElement
           (By.Id("login_name"));
        private IWebElement passwordBox = webDriver.FindElement
          (By.Id("login_password"));
        private IWebElement loginButton = webDriver.FindElement
           (By.ClassName("fbutton"));

        public void loginAsAutomation()
        {
            openLoginProfileButton.Click();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            userNameBox.SendKeys(getUsername());
            passwordBox.SendKeys(getPassword());
            loginButton.Click();
            //wait.until(ExpectedConditions.elementToBeClickable(openLoginProfileButton));
            //if (!openLoginProfileButton.getText().contains(username))
            //{
            //    ExtentTestManager.getTest().fail("login failed");
            //}
        }

        public void isTheProfileConnected(out bool profileConnected)
        {
            profileConnected = true;

            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            openLoginProfileButton.Click();

            if (!openLoginProfileButton.Text.Contains(getUsername()))
            {
                profileConnected = false;
            }
        }

        private String getUsername()
        {
            return username;
        }

        private String getPassword()
        {
            return password;
        }
    }
}

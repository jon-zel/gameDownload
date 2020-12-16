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
        public IWebElement openLoginProfileButton = webDriver.FindElement
           (By.Id("open-mini-profile"), 300);
        public IWebElement userNameBox = webDriver.FindElement
           (By.Id("login_name"), 300);
        public IWebElement passwordBox = webDriver.FindElement
          (By.Id("login_password"), 300);
        public IWebElement loginButton = webDriver.FindElement
           (By.ClassName("fbutton"), 300);
        public IWebElement logoutButton = webDriver.FindElement
           (By.XPath("/html/body/div[2]/div/div[2]/ul/li[3]/a"), 300);

        public String getUserName()
        {
            return username;
        }

        public String getPassword()
        {
            return password;
        }
    }
}

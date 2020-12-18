using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace gameDownload.infrastructure
{
    public class LoginPageElements : basePageElements
    {
        // variables
        private const String username = "autoto";
        private const String password = "oop1234";

        // Login buttons
        public IWebElement openLoginProfileButton = basePageDriver.FindElement
           (By.Id("nav-miniprofile-link"), 300);
        public IWebElement userNameBox = basePageDriver.FindElement
           (By.Id("login_name"), 300);
        public IWebElement passwordBox = basePageDriver.FindElement
          (By.Id("login_password"), 300);
        public IWebElement loginButton = basePageDriver.FindElement
           (By.ClassName("fbutton"), 300);
        public IWebElement logoutButton = basePageDriver.FindElement
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

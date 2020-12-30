using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace gameDownload.infrastructure
{
    public class LoginPageElements : basePageElements
    {
        // variables
        private const String username = "autoto";
        private const String password = "oop1234";

        // Login buttons
        [FindsBy(How = How.Id, Using = "nav-miniprofile-link")]
        protected IWebElement openLoginProfileButton { get; set; }

        [FindsBy(How = How.Id, Using = "login_name")]
        protected IWebElement userNameBox { get; set; }

        [FindsBy(How = How.Id, Using = "login_password")]
        protected IWebElement passwordBox { get; set; }

        [FindsBy(How = How.ClassName, Using = "fbutton")]
        protected IWebElement loginButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/ul/li[3]/a")]
        protected IWebElement logoutButton { get; set; }

        protected String getUserName()
        {
            return username;
        }

        protected String getPassword()
        {
            return password;
        }
    }
}

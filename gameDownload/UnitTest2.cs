using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using gameDownload.infrastructure;
using System;
using OpenQA.Selenium.Support.UI;

namespace gameDownload
{
    public class LoginPageTests
    {
        private IWebDriver webDriver;
        //    protected LoginPageMethods loginPage = new LoginPageMethods(webDriver);

        [SetUp]
        public void Setup()
        {
            //   webDriver = new ChromeDriver();


            //    basePageMethods.GetBasePageDriver().Manage().Window.Maximize();
            //   basePageMethods.GetBasePageDriver().Navigate().GoToUrl("https://torrent-igruha.org/");
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("https://torrent-igruha.org/");

        }

        [Test]
        public void CorrectLoggin()
        {
            Console.WriteLine(webDriver.GetType());
            webDriver.FindElement(By.Id("nav-miniprofile-link"), 300).Click();
            webDriver.FindElement(By.Id("login_name"), 300).SendKeys("autoto");
            webDriver.FindElement(By.Id("login_password"), 300).SendKeys("oop1234");
            webDriver.FindElement(By.ClassName("fbutton"), 300).Click();
            //LoginPageMethods login = new LoginPageMethods();
            //login.loginAsAutomation();
            Assert.Pass();
        }

        //[Test]
        //public void search()
        //{
        //    loginPage.loginAsAutomation();
        //    Assert.Pass();
        //}

        [TearDown]
        public void Close()
        {
            webDriver.Quit();
        }
    }
}
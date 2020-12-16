using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using gameDownload.infrastructure;
using System;

namespace gameDownload
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(180);
            webDriver.Navigate().GoToUrl("https://torrent-igruha.org/");


        }

        [Test]
        public void Test1()
        {

            Assert.Pass();
        }

        [Test]
        public void Test2()
        {

            Assert.Pass();
        }
    }
}
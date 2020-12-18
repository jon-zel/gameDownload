using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace gameDownload.infrastructure
{
    public class basePageMethods : basePageElements
    {
        private static IWebDriver _pageDriver;

        public basePageMethods(ref IWebDriver pageDriver)
        {
            _pageDriver = pageDriver;
        }

        [TestMethod]
        public void Search(String Search)
        {
            searchBox.Click();
            searchBox.SendKeys(Search);
            searchButton.Click();

            _pageDriver.FindElement(By.Id("dofullsearch"), 300);
        }

        //[TestMethod]
        //public void SearchAndPrintInfo(String Search)
        //{
        //    searchBox.Click();
        //    searchBox.SendKeys(Search);
        //    searchButton.Click();
        //    String SearchResult = wait.until(ExpectedConditions.visibilityOfElementLocated
        //            (By.xpath("//*[@id=\"dle-content\"]/div[3]"))).getText();
        //    ExtentTestManager.getTest().info
        //            ("Search" + Search + " result is: " + SearchResult);
        //}
    }
}

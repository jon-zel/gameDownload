﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace gameDownload.infrastructure
{
    class basePageTests : basePage
    {
        [TestMethod]
        public void Search(String Search)
        {
            searchBox.Click();
            searchBox.SendKeys(Search);
            searchButton.Click();

            //   webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            webDriver.FindElement(By.Id("dofullsearch"), 300);
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
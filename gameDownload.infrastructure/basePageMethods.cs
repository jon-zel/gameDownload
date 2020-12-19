using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
namespace gameDownload.infrastructure
{
    public class basePageMethods : basePageElements
    {

        [TestMethod]
        public void Search(String Search)
        {
            searchBox.Click();
            searchBox.SendKeys(Search);
            searchButton.Click();

            GetPageDriver().FindElement(By.Id("dofullsearch"), 300);
        }

        //[TestMethod]
        //public void PrintAmountOfSearchResults()
        //{
        //   חיפוש של התוצאות - הכנסה לליסט - והדפסה של הגודל של הליסט
        //   
        //}
    }
}

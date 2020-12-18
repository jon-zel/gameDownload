using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace gameDownload.infrastructure
{
    public class basePage
    {

        private static IWebDriver basePageDriver;
        //public basePage(IWebDriver pageDriver)
        //{
        //    basePageDriver = pageDriver;          
        //    //    super(basePageDriver);
        //}

        //  protected Random random = new Random();


        // Top column - black area
        public IWebElement newGames = basePageDriver.FindElement
            (By.XPath("/html/body/div[2]/div/ul[1]/li/a"), 300);
        public IWebElement newGames2020 = basePageDriver.FindElement
            (By.XPath("/html/body/div[2]/div/ul[2]/li/a"), 300);
        public IWebElement contacts = basePageDriver.FindElement
            (By.XPath("/html/body/div[2]/div/ul[3]/li/a"), 300);
        public IWebElement forCopyrightHolders = basePageDriver.FindElement
            (By.XPath("/html/body/div[2]/div/ul[4]/li/a"), 300);
        public IWebElement problemSolution = basePageDriver.FindElement
            (By.XPath("/html/body/div[2]/div/ul[5]/li/a"), 300);


        // Top column - white area
        public IWebElement logo_BasePage = basePageDriver.FindElement
            (By.ClassName("header-logo"), 300);
        public IWebElement top10Online = basePageDriver.FindElement
            (By.LinkText("Топ 10 Онлайн игр"), 300);
        public IWebElement top100 = basePageDriver.FindElement
            (By.LinkText("Топ 100 игр"), 300);
        public IWebElement rusNew = basePageDriver.FindElement
            (By.LinkText("С русcкой озвучкой"), 300);
        public IWebElement newVK = basePageDriver.FindElement
            (By.LinkText("Мы Вконтакте"), 300);


        // Search
        public IWebElement searchBox = basePageDriver.FindElement
            (By.Id("story"), 300);
        public IWebElement searchButton = basePageDriver.FindElement
            (By.XPath("/html/body/div[4]/div/div/form/input[3]"), 300);
        public IWebElement searchResultInfo = basePageDriver.FindElement
            (By.ClassName("error-block"), 300);

        // Right column
        //   @FindBy(xpath = "/html/body/div[5]/div[2]/center[1]/a/img")
        //   private WebElement Advertising;

        public IWebDriver GetBasePageDriver()
        {
            return basePageDriver;
        }
    }
}

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
        public static IWebDriver webDriver;
        //public basePage(IWebDriver webDriver)
        //{
        //    this.webDriver = webDriver;
        //    super(webDriver);
        //}

        //  protected Random random = new Random();


        // Top column - black area
        public IWebElement newGames = webDriver.FindElement
            (By.XPath("/html/body/div[2]/div/ul[1]/li/a"), 300);
        public IWebElement newGames2020 = webDriver.FindElement
            (By.XPath("/html/body/div[2]/div/ul[2]/li/a"), 300);
        public IWebElement contacts = webDriver.FindElement
            (By.XPath("/html/body/div[2]/div/ul[3]/li/a"), 300);
        public IWebElement forCopyrightHolders = webDriver.FindElement
            (By.XPath("/html/body/div[2]/div/ul[4]/li/a"), 300);
        public IWebElement problemSolution = webDriver.FindElement
            (By.XPath("/html/body/div[2]/div/ul[5]/li/a"), 300);


        // Top column - white area
        public IWebElement logo_BasePage = webDriver.FindElement
            (By.ClassName("header-logo"), 300);
        public IWebElement top10Online = webDriver.FindElement
            (By.LinkText("Топ 10 Онлайн игр"), 300);
        public IWebElement top100 = webDriver.FindElement
            (By.LinkText("Топ 100 игр"), 300);
        public IWebElement rusNew = webDriver.FindElement
            (By.LinkText("С русcкой озвучкой"), 300);
        public IWebElement newVK = webDriver.FindElement
            (By.LinkText("Мы Вконтакте"), 300);


        // Search
        public IWebElement searchBox = webDriver.FindElement
            (By.Id("story"), 300);
        public IWebElement searchButton = webDriver.FindElement
            (By.XPath("/html/body/div[4]/div/div/form/input[3]"), 300);
        public IWebElement searchResultInfo = webDriver.FindElement
            (By.ClassName("error-block"), 300);

        // Right column
        //   @FindBy(xpath = "/html/body/div[5]/div[2]/center[1]/a/img")
        //   private WebElement Advertising;

    }
}

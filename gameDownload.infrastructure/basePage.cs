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
        protected Random random = new Random();
        public static IWebDriver webDriver = new ChromeDriver();
        //  public static IWait wait;

        // Top column - black area
        private IWebElement newGames = webDriver.FindElement
            (By.LinkText("Новые игры"));
        private IWebElement newGames2020 = webDriver.FindElement
            (By.LinkText("Игры 2020 года"));
        private IWebElement contacts = webDriver.FindElement
            (By.LinkText("Контакты"));
        private IWebElement forCopyrightHolders = webDriver.FindElement
            (By.LinkText("Правообладателям"));
        private IWebElement problemSolution = webDriver.FindElement
            (By.LinkText("Решения проблем (FAQ)"));


        // Top column - white area
        private IWebElement logo_BasePage = webDriver.FindElement
            (By.ClassName("header-logo"));
        private IWebElement top10Online = webDriver.FindElement
            (By.LinkText("Топ 10 Онлайн игр"));
        private IWebElement top100 = webDriver.FindElement
            (By.LinkText("Топ 100 игр"));
        private IWebElement rusNew = webDriver.FindElement
            (By.LinkText("С русcкой озвучкой"));
        private IWebElement newVK = webDriver.FindElement
            (By.LinkText("Мы Вконтакте"));


        // Search
        public IWebElement searchBox = webDriver.FindElement
            (By.Id("story"));
        private IWebElement searchButton = webDriver.FindElement
            (By.XPath("/html/body/div[4]/div/div/form/input[3]"));
        private IWebElement searchResultInfo = webDriver.FindElement
            (By.ClassName("error-block"));

        // Right column
        //   @FindBy(xpath = "/html/body/div[5]/div[2]/center[1]/a/img")
        //   private WebElement Advertising;

        //public basePage(IWebDriver driver)
        //{
        //    super(driver);
        //}

        public void Search(String Search)
        {
            searchBox.Click();
            searchBox.SendKeys(Search);
            searchButton.Click();

            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            webDriver.FindElement(By.Id("dofullsearch"));
        }

        public void SearchAndPrintInfo(String Search)
        {
            searchBox.Click();
            searchBox.SendKeys(Search);
            searchButton.Click();
            String SearchResult = wait.until(ExpectedConditions.visibilityOfElementLocated
                    (By.xpath("//*[@id=\"dle-content\"]/div[3]"))).getText();
            ExtentTestManager.getTest().info
                    ("Search" + Search + " result is: " + SearchResult);
        }
    }
}

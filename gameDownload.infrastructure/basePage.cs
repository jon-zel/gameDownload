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
        //  protected Random random = new Random();
        public static IWebDriver webDriver = new ChromeDriver();
        //  public static IWait wait;

        // Top column - black area
        public IWebElement newGames = webDriver.FindElement
            (By.LinkText("Новые игры"));
        public IWebElement newGames2020 = webDriver.FindElement
            (By.LinkText("Игры 2020 года"));
        public IWebElement contacts = webDriver.FindElement
            (By.LinkText("Контакты"));
        public IWebElement forCopyrightHolders = webDriver.FindElement
            (By.LinkText("Правообладателям"));
        public IWebElement problemSolution = webDriver.FindElement
            (By.LinkText("Решения проблем (FAQ)"));


        // Top column - white area
        public IWebElement logo_BasePage = webDriver.FindElement
            (By.ClassName("header-logo"));
        public IWebElement top10Online = webDriver.FindElement
            (By.LinkText("Топ 10 Онлайн игр"));
        public IWebElement top100 = webDriver.FindElement
            (By.LinkText("Топ 100 игр"));
        public IWebElement rusNew = webDriver.FindElement
            (By.LinkText("С русcкой озвучкой"));
        public IWebElement newVK = webDriver.FindElement
            (By.LinkText("Мы Вконтакте"));


        // Search
        public IWebElement searchBox = webDriver.FindElement
            (By.Id("story"));
        public IWebElement searchButton = webDriver.FindElement
            (By.XPath("/html/body/div[4]/div/div/form/input[3]"));
        public IWebElement searchResultInfo = webDriver.FindElement
            (By.ClassName("error-block"));

        // Right column
        //   @FindBy(xpath = "/html/body/div[5]/div[2]/center[1]/a/img")
        //   private WebElement Advertising;

    }
}

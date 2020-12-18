using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace gameDownload.infrastructure
{
    public class basePageElements
    {
        protected static IWebDriver basePageDriver = new ChromeDriver();
        public IWebDriver GetPageDriver()
        {
            return basePageDriver;
        }

        // Top column - black area
        protected IWebElement newGames = basePageDriver.FindElement
            (By.XPath("/html/body/div[2]/div/ul[1]/li/a"), 300);
        protected IWebElement newGames2020 = basePageDriver.FindElement
            (By.XPath("/html/body/div[2]/div/ul[2]/li/a"), 300);
        protected IWebElement contacts = basePageDriver.FindElement
            (By.XPath("/html/body/div[2]/div/ul[3]/li/a"), 300);
        protected IWebElement forCopyrightHolders = basePageDriver.FindElement
            (By.XPath("/html/body/div[2]/div/ul[4]/li/a"), 300);
        protected IWebElement problemSolution = basePageDriver.FindElement
            (By.XPath("/html/body/div[2]/div/ul[5]/li/a"), 300);


        // Top column - white area
        protected IWebElement logo_BasePage = basePageDriver.FindElement
            (By.ClassName("header-logo"), 300);
        protected IWebElement top10Online = basePageDriver.FindElement
            (By.LinkText("Топ 10 Онлайн игр"), 300);
        protected IWebElement top100 = basePageDriver.FindElement
            (By.LinkText("Топ 100 игр"), 300);
        protected IWebElement rusNew = basePageDriver.FindElement
            (By.LinkText("С русcкой озвучкой"), 300);
        protected IWebElement newVK = basePageDriver.FindElement
            (By.LinkText("Мы Вконтакте"), 300);


        // Search
        protected IWebElement searchBox = basePageDriver.FindElement
            (By.Id("story"), 300);
        protected IWebElement searchButton = basePageDriver.FindElement
            (By.XPath("/html/body/div[4]/div/div/form/input[3]"), 300);
        protected IWebElement searchResultInfo = basePageDriver.FindElement
            (By.ClassName("error-block"), 300);
    }
}

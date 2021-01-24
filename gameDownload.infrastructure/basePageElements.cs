using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace gameDownload.infrastructure
{
    public class basePageElements
    {
        protected static IWebDriver basePageDriver => webDriver.GetWebDriver();
        // private webDriver webDriver = new webDriver();

        public IWebDriver GetPageDriver()
        {
            return basePageDriver;
        }



        // Top column - black area
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/ul[1]/li/a")]
        protected IWebElement newGames { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/ul[2]/li/a")]
        protected IWebElement newGames2020 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/ul[3]/li/a")]
        protected IWebElement contacts { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/ul[4]/li/a")]
        protected IWebElement forCopyrightHolders { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/ul[5]/li/a")]
        protected IWebElement problemSolution { get; set; }


        // Top column - white area
        [FindsBy(How = How.ClassName, Using = "header-logo")]
        protected IWebElement logo_BasePage { get; set; }

        [FindsBy(How = How.LinkText, Using = "Топ 10 Онлайн игр")]
        protected IWebElement top10Online { get; set; }

        [FindsBy(How = How.LinkText, Using = "Топ 100 игр")]
        protected IWebElement top100 { get; set; }

        [FindsBy(How = How.LinkText, Using = "С русcкой озвучкой")]
        protected IWebElement rusNew { get; set; }

        [FindsBy(How = How.LinkText, Using = "Мы Вконтакте")]
        protected IWebElement newVK { get; set; }


        // Search
        [FindsBy(How = How.Id, Using = "story")]
        protected IWebElement searchBox { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div/form/input[3]")]
        protected IWebElement searchButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "error-block")]
        protected IWebElement searchResultInfo { get; set; }
    }
}

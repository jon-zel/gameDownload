using NUnit.Framework;
using gameDownload.infrastructure;

namespace gameDownload
{
    public class BasePageTests
    {
        //  private webDriver webDriver = new webDriver();
        private basePageMethods basePage = new basePageMethods();


        [SetUp]
        public void Setup()
        {
            basePage.GetPageDriver().Manage().Window.Maximize();
            basePage.GetPageDriver().Navigate().GoToUrl("https://torrent-igruha.org/");
        }

        [Test]
        public void search()
        {
            basePage.Search("assassins");
            Assert.Pass();
        }

        [TearDown]
        public void Close()
        {
            basePage.GetPageDriver().Quit();
        }
    }
}
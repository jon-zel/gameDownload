using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace gameDownload.infrastructure
{
    public static class webDriver
    {
        public static IWebDriver WebDriver => new ChromeDriver();

        public static IWebDriver GetWebDriver()
        {
            return WebDriver;
        }
    }
}

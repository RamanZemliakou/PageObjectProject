using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObjectProject
{
    public class BasePage
    {
        private ChromeDriver driver;
        public string baseURL = "https://demoqa.com";

        protected ChromeDriver Driver { get => driver; set => driver = value; }

        public BasePage(string baseURL)
        {
            this.baseURL = baseURL;
        }

        public BasePage(IWebDriver driver)
        {
            this.driver = (ChromeDriver?)driver;
        }
    }
}
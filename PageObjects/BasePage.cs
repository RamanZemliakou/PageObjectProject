using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObjectProject
{
    public class BasePage
    {
        protected ChromeDriver driver;
        public static readonly string baseURL = "https://demoqa.com";

        public ChromeDriver Driver { get => driver; set => driver = value; }

        public BasePage(string baseURL)
        {
            this.baseURL = baseURL;
            driver.Url = baseURL;
        }

        public BasePage(ChromeDriver driver)
        {
            _ = this.driver; 
        }


    }
}
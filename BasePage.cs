using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObjectProject
{
    public class BasePage
    {
        public ChromeDriver driver;
        public string baseURL = "https://demoqa.com";

        public ChromeDriver Driver { get => driver; set => driver = value; }

        public BasePage(string baseURL)
        {
            this.baseURL = baseURL;
        }

        public BasePage(ChromeDriver driver)
        {
            _ = this.driver; 
        }
    }
}
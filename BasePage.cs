using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObjectProject
{
    public class BasePage
    {
       protected IWebDriver driver;
        public string baseURL = "https://demoqa.com";

        public BasePage(string baseURL)
        {
            this.baseURL = baseURL;
        }

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
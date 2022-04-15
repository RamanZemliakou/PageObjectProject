using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObjectProject
{
    public class BasePage
    {
       protected IWebDriver driver;
        public string URL = "https://demoqa.com";
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
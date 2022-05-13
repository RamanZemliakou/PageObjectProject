using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectProject
{
    public abstract class ElementsPageGroup : BasePage
    {
        private readonly string elementLocator = "//*[@id='item - 0']/span";

        protected IWebElement textBoxButton { get { return driver.FindElement(By.XPath(elementLocator)); } }

        public ElementsPageGroup(ChromeDriver driver) : base(driver) 
        { 
            //go to other page
        }

        public void ClickTextBoxButton() { textBoxButton.Click(); }

    }
}




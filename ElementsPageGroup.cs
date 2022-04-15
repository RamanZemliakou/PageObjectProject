using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectProject
{
    public abstract class ElementsPageGroup : BasePage
    {
        protected IWebElement textBoxButton { get { return driver.FindElement(By.XPath("//*[@id='item - 0']/span")); } }


        public ElementsPageGroup(IWebDriver driver) : base(driver) { }

        public void ClickTextBoxButton() { textBoxButton.Click(); }

    }
}




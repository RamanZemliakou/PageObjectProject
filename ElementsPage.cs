using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectProject
{
    public class ElementsPage : ElementsPageGroup
    {
        public string URL = "https://demoqa.com/elements";
        public ElementsPage(IWebDriver driver) : base(driver)
        {

        }
    }
}

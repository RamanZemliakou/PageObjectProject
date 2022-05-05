using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectProject
{
    public class ElementsPage : ElementsPageGroup
    {
        public string elementsURL = "https://demoqa.com/elements";
        public ElementsPage(ChromeDriver driver) : base(driver) { }
        
    }
}

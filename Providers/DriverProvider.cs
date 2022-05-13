using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace PageObjectProject
{
    internal class DriverProvider
    {
        

            private static readonly ThreadLocal<IWebDriver> _storedDriver = new ThreadLocal<IWebDriver>();

            public IWebDriver GetDriver()
            {
                if (_storedDriver.Value == null)
                {
                    ChromeOptions options = new ChromeOptions();
                    _storedDriver.Value = new ChromeDriver()
                    {
                        Url = BasePage.baseURL
                    };
                }
                return _storedDriver.Value;
            }

            public void Quit()
            {
                _storedDriver.Value.Quit();
            }
        }
    
}

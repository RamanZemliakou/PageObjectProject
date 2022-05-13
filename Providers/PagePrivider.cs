using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace PageObjectProject
{
    public class PageProvider
    {
        DriverProvider provider;


        public void Quit()
        {
            provider.Quit();
        }

        public IWebDriver setDriver()
        {
            if (provider == null)
            {
                provider = new DriverProvider();
            }
            return provider.GetDriver();
        }


        public T InitPage<T>()
        {
            object[] param = { setDriver() };
            return (T)Activator.CreateInstance(typeof(T), param);
        }
    }
}

using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageObjectProject
{
    public class TextBoxPage : ElementsPageGroup
    {
        private readonly string fullNameLocator = "//*[@id='userName']";
        private readonly string eMailLocator = "//*[@id='userEmail']";
        private readonly string currentAdressLocator = "//*[@id='currentAddress']";
        private readonly string permanentAddressLocator = "//*[@id='permanentAddress']";
        private readonly string submitButtonLocator = "//*[@id='submit']";
        private readonly string outputFieldLocator = "//*[@id='output']";
        private readonly string outputNameLocator = "//*[@id='name']";

        public const string URL = "https://demoqa.com/text-box";
        private IWebElement fullNameField
        {
            get { return driver.FindElement(By.XPath(fullNameLocator)); }
        }
        private IWebElement eMailField
        {
            get { return driver.FindElement(By.XPath(eMailLocator)); }
        }
        private IWebElement currentAdressField
        {
            get { return driver.FindElement(By.XPath(currentAdressLocator)); }
        }
        private IWebElement permanentAddressField
        {
            get { return driver.FindElement(By.XPath(permanentAddressLocator)); }
        }
        private IWebElement submitButton
        {
            get { return driver.FindElement(By.XPath(submitButtonLocator)); }
        }
        private IWebElement outputField
        {
            get { return driver.FindElement(By.XPath(outputFieldLocator)); }
        }
        private IWebElement nameOutput
        {
            get { return driver.FindElement(By.XPath(outputNameLocator)); }
        }


        public TextBoxPage(ChromeDriver driver) : base(driver) 
        {
            
            driver.Url = URL;

        }

        
        public void GoToUrl(string URL)
        {
            driver.Navigate().GoToUrl(URL);
        }
        public void EnterName(string userName)
        {
            fullNameField.SendKeys(userName);
        }

        public void EnterEmail(string userEmail)
        {
            eMailField.SendKeys(userEmail);
        }

        public void EnterCurrentAddress(string currentAddress)
        {
            currentAdressField.SendKeys(currentAddress);
        }

        public void EnterPermanentAddress(string permanentAddress)
        {
            permanentAddressField.SendKeys(permanentAddress);
        }

        public void ClickSubmit()
        {
            submitButton.Click();
        }

        public string GetNameOutput()
        {
            return outputField.Text;
        }

        public void CloseDriver()
        {
            driver.Close();
        } 
    }

}

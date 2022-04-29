using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Linq;
using System.Text;

namespace PageObjectProject
{
    internal class TextBoxTest1
    {
        WebDriver? _driver;
        private readonly string userName;
        private readonly object nameOutput;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            // json with data
        }

        [Test]
        public void OutputFieldTest()
        {
            var inputName = nameOutput;
            Assert.AreEqual("Name:" + userName, inputName);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}

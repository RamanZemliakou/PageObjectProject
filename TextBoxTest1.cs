using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
        }

        [Test]
        public void OutputFieldTest()
        {
            var inputName = nameOutput.Text;
            Assert.AreEqual("Name:" + userName, inputName);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}

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
        //WebDriver? _driver; is not used in Test Class
        TextBoxPage textBoxPage;


        [SetUp]
        public void Setup()
        {
            //_driver = new ChromeDriver(); is not used in Test Class
            textBoxPage = new TextBoxPage(); // rewrite pages not to use driver from test, new Class Provider
            // json with data

        }

        [Test]
        public void OutputFieldTest()
        {
            //object nameOutput;
            string userName = "New User";
            string userEmail = "mail@mail.com";
            string currentAddress = "Belarus, Minsk";
            string permanetAddress = "some other address";

            textBoxPage.EnterName(userName); // enter all info -> Submit -> check result AreEqual
            textBoxPage.EnterEmail(userEmail);
            textBoxPage.EnterCurrentAddress(currentAddress);
            textBoxPage.EnterPermanentAddress(permanetAddress);
            textBoxPage.ClickSubmit();

            var inputName = textBoxPage.GetNameOutput();
            Assert.AreEqual("Name:" + userName, inputName);
        }

        [TearDown]
        public void TearDown()
        {
            textBoxPage.CloseDriver();
        }
    }
}

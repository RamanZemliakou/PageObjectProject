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
            TextBoxPage textBoxPage = new();

        }

        [Test]
        public void OutputFieldTest()
        {
            string userName = "New User";
            string userEmail = "mail@mail.com";
            string currentAddress = "Belarus, Minsk";
            string permanetAddress = "some other address";

            textBoxPage.EnterName(userName); 
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

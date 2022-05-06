using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Linq;
using System.Text;

namespace PageObjectProject
{
    public class TextBoxTest1
    {
        public const string URL = "https://demoqa.com/text-box";
        private readonly TextBoxPage? textBoxPage;


        [SetUp]
        public void Setup()
        {
            textBoxPage.GoToUrl(URL);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutotestExample.RegressionTests.RequestAQuote
{
    [TestFixture]
    class RequestAQuote
    {
        private IWebDriver driver;
        private string baseURL;

        [SetUp]
        public void SettingUp()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.dkhardware.com/";
        }

        [TearDown]
        public void Quiting()
        {
            driver.Quit();
        }

        [Test]
        public void OpenRequestAQuotePageFromHeader()
        {
            //Go to Main Page
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Maximize();
            Assert.AreEqual("Hardware Supply Online | Buy Branded Door Hardware and Parts", driver.Title);

            //Click on Request Qoute link in the header
            driver.FindElement(By.CssSelector(Selectors.HEADER_SUBMIT_QOUTE_LINK_CSS_SELECTOR)).Click();
            Assert.AreEqual("Request A Quote",driver.Title);
        }
    }
}

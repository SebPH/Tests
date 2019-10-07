using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSample
{
    class Demo
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test()
        {
            driver.Url = "http://localhost:8012/SeleniumProject/";
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace CucumberSampleTest.Steps
{
    [Binding]
    public class SampleSteps
    {
        public IWebDriver driver = new InternetExplorerDriver();
        [Given(@"user opens up browsers and goes to sample page")]
        public void GivenUserOpensUpBrowsersAndGoesToSamplePage()
        {
            driver.Navigate().GoToUrl("http://localhost:8012/SeleniumProject/");
            driver.Manage().Window.Maximize();
        }
        
        [When(@"user writes in data for all fields")]
        public void WhenUserWritesInDataForAllFields()
        {
            // Adding Firstname
            IWebElement firstnameTextBox = driver.FindElement(By.XPath(".//*[@id='firstname']"));
            firstnameTextBox.SendKeys("John");

            // Adding Lastname
            IWebElement lastnameTextBox = driver.FindElement(By.XPath(".//*[@id='lastname']"));
            lastnameTextBox.SendKeys("Snow");

            // Adding Adddress
            IWebElement addressTextBox = driver.FindElement(By.XPath(".//*[@id='address']"));
            addressTextBox.SendKeys("4100 Fairfax Drive, Arlington VA");

            // Adding Age
            IWebElement ageTextBox = driver.FindElement(By.XPath(".//*[@id='age']"));
            ageTextBox.SendKeys("25");

            // Adding Phone Number
            IWebElement phoneTextBox = driver.FindElement(By.XPath(".//*[@id='phone']"));
            phoneTextBox.SendKeys("1-347-426-9071");

            // Gender Selection
            IWebElement genderSelect = driver.FindElement(By.XPath(".//*[@id='gender1']"));
            genderSelect.Click();

            // Transportation Selection
            IWebElement transportSelect = driver.FindElement(By.XPath(".//*[@id='vehicle4']"));
            transportSelect.Click();

            // Snack Selection
            IWebElement snackDropDown = driver.FindElement(By.XPath(".//*[@id='snack-selection']"));
            var selection = new SelectElement(snackDropDown);
            selection.SelectByValue("Wine");

            // Signup
            IWebElement signupemailTextBox = driver.FindElement(By.XPath(".//*[@id='signup-email']"));
            signupemailTextBox.SendKeys("JohnSnow@gmail.com");
            IWebElement signuppasswordTextBox = driver.FindElement(By.XPath(".//*[@id='signup-password']"));
            signuppasswordTextBox.SendKeys("Stark_Tygerian");
        }
        
        [When(@"user submits")]
        public void WhenUserSubmits()
        {
            // Submit
            IWebElement signUpButton = driver.FindElement(By.XPath(".//*[@id='signup-submit']"));
            signUpButton.Click();

            driver.Navigate().Back();

            // Login
            IWebElement loginemailTextBox = driver.FindElement(By.XPath(".//*[@id='signin-email']"));
            loginemailTextBox.SendKeys("JohnSnow@gmail.com");
            IWebElement loginpasswordTextBox = driver.FindElement(By.XPath(".//*[@id='signin-password']"));
            loginpasswordTextBox.SendKeys("Stark_Tygerian");
            IWebElement signInButton = driver.FindElement(By.XPath(".//*[@id='signin-submit']"));
            signInButton.Click();

            driver.Navigate().Back();
            driver.Navigate().Refresh();
        }
        
        [Then(@"user exits")]
        public void ThenUserExits()
        {
            driver.Close();
        }
    }
}

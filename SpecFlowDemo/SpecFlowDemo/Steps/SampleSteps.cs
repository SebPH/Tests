using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowDemo.Steps
{
    [Binding]
    public class SampleSteps
    {
        public IWebDriver driver = new ChromeDriver();
        [Given(@"Visit sample page")]
        public void GivenVisitSamplePage()
        {
            driver.Navigate().GoToUrl("http://localhost:8012/SeleniumProject/");
            driver.Manage().Window.Maximize();
        }
        
        [When(@"User inputs data in all the fields on the signup section")]
        public void WhenUserInputsDataInAllTheFieldsOnTheSignupSection()
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

            IWebElement signUpButton = driver.FindElement(By.XPath(".//*[@id='signup-submit']"));
            signUpButton.Click();

            driver.Navigate().Back();
        }
        
        [When(@"user inputs data in all the fields on the login section")]
        public void WhenUserInputsDataInAllTheFieldsOnTheLoginSection()
        {
            IWebElement loginemailTextBox = driver.FindElement(By.XPath(".//*[@id='signin-email']"));
            loginemailTextBox.SendKeys("JohnSnow@gmail.com");
            IWebElement loginpasswordTextBox = driver.FindElement(By.XPath(".//*[@id='signin-password']"));
            loginpasswordTextBox.SendKeys("Stark_Tygerian");
            IWebElement signInButton = driver.FindElement(By.XPath(".//*[@id='signin-submit']"));
            signInButton.Click();

            driver.Navigate().Back();
            driver.Navigate().Refresh();
        }
        
        [Then(@"automation test is complete and browser closes")]
        public void ThenAutomationTestIsCompleteAndBrowserCloses()
        {
            driver.Close();
        }
    }
}

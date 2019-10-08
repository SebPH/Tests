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
    public class LoginSteps
    {
        [Given(@"User is at the Home Page")]
        public void GivenUserIsAtTheHomePage()
        {
            // IP ADDRESS: 172.25.32.37
            //driver.Navigate().GoToUrl("http://localhost:8012/SeleniumProject/");    // Test Website 1
            //driver.Navigate().GoToUrl("http://localhost:8080/");    // Test Website 2

            // IWebDriver driver = new ChromeDriver();        
            // IWebDriver driver = new FirefoxDriver();
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:8012/SeleniumProject/");
            driver.Manage().Window.Maximize();
        }
        
        [Given(@"Navigate to LogIn Page")]
        public void GivenNavigateToLogInPage()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"User enter UserName and Password")]
        public void WhenUserEnterUserNameAndPassword()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"Click on the Login button")]
        public void WhenClickOnTheLoginButton()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"Successful Login message should display")]
        public void ThenSuccessfulLoginMessageShouldDisplay()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}

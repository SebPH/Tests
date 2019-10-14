using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // IP ADDRESS: 172.25.32.37
            //driver.Navigate().GoToUrl("http://localhost:8012/SeleniumProject/");    // Test Website 1
            //driver.Navigate().GoToUrl("http://localhost:8080/");    // Test Website 2

            // IWebDriver driver = new ChromeDriver();          // Requires >= Chrome 76 (currently install is Chrome 72)
            // IWebDriver driver = new FirefoxDriver();
            IWebDriver driver = new InternetExplorerDriver();
            driver.Navigate().GoToUrl("http://localhost:8012/SeleniumProject/");
            driver.Manage().Window.Maximize();
            
            // testing other navigation commands
            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Navigate().Refresh();

            // Adding Firstname
            IWebElement firstnameTextBox = driver.FindElement(By.XPath(".//*[@id='firstname']"));
            firstnameTextBox.SendKeys("John");
            System.Threading.Thread.Sleep(10000);

            // Adding Lastname
            IWebElement lastnameTextBox = driver.FindElement(By.XPath(".//*[@id='lastname']"));
            lastnameTextBox.SendKeys("Snow");
            System.Threading.Thread.Sleep(10000);

            // Adding Adddress
            IWebElement addressTextBox = driver.FindElement(By.XPath(".//*[@id='address']"));
            addressTextBox.SendKeys("4100 Fairfax Drive, Arlington VA");
            System.Threading.Thread.Sleep(10000);

            // Adding Age
            IWebElement ageTextBox = driver.FindElement(By.XPath(".//*[@id='age']"));
            ageTextBox.SendKeys("25");
            System.Threading.Thread.Sleep(10000);

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

            driver.Close();


        }
    }
}

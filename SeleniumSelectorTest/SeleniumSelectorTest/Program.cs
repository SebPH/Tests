using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;

namespace SeleniumSelectorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = Stopwatch.StartNew();
            string URL = "http://localhost:8012/BusinessHierarchy/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(URL);
            driver.Manage().Window.Maximize();

            // Types of Selectors:
            // By.ClassName,
            // ById,
            // ByName,
            // ByTagName,
            // ByXPath,
            // ByCssSelector
            // ByLinkText

            // Administrative Level (using CssSelector)
            // Board of Directors

            // Name 
            //IWebElement BoardFirstnameTextBox = driver.FindElement(By.Id("firstname"));
            //IWebElement BoardFirstnameTextBox = driver.FindElement(By.ClassName("firstname"));
            //IWebElement BoardFirstnameTextBox = driver.FindElement(By.Name("firstname"));
            //IWebElement BoardFirstnameTextBox = driver.FindElement(By.LinkText("<input type='text' class='firstname'>"));

            IWebElement BoardFirstnameTextBox = driver.FindElement(By.CssSelector(".mat-admin-level .mat-board-directors .mat-name .firstname"));
            BoardFirstnameTextBox.SendKeys("Brad");
            Console.WriteLine("Added for fistname");
            IWebElement BoardLastnameTextBox = driver.FindElement(By.CssSelector(".mat-admin-level .mat-board-directors .mat-name .lastname"));
            BoardLastnameTextBox.SendKeys("Moon");
            Console.WriteLine("Added for lastname");
            Thread.Sleep(1500);

            // Country
            IWebElement BoardCountrySelection = driver.FindElement(By.CssSelector(".mat-admin-level .mat-board-directors .mat-country .location1"));
            BoardCountrySelection.Click();
            Console.WriteLine("Country Selected");
            Thread.Sleep(1500);

            // Office
            IWebElement BoardOfficeSelection = driver.FindElement(By.CssSelector(".mat-admin-level .mat-board-directors .mat-office .office1"));
            BoardOfficeSelection.Click();
            Console.WriteLine("Office Selected");
            Thread.Sleep(1500);

            // Vertical
            IWebElement BoardVerticalSelection = driver.FindElement(By.CssSelector(".mat-admin-level .mat-board-directors .mat-vertical .vertical .vertical1"));
            BoardVerticalSelection.Click();
            Console.WriteLine("Vertical Selected");
            Thread.Sleep(1500);

            // Horizontal
            IWebElement BoardHorizontalSelection = driver.FindElement(By.CssSelector(".mat-admin-level .mat-board-directors .mat-horizontal .click1"));
            BoardHorizontalSelection.Click();
            Console.WriteLine("Horizontal Selected");
            Thread.Sleep(1500);

            

            // Chairman
            // Name
            IWebElement ChairfirstnameTextBox = driver.FindElement(By.CssSelector(".mat-admin-level .mat-chairman .mat-name .firstname"));
            ChairfirstnameTextBox.SendKeys("Fox");
            Console.WriteLine("Added for fistname");
            IWebElement ChairlastnameTextBox = driver.FindElement(By.CssSelector(".mat-admin-level .mat-chairman .mat-name .lastname"));
            ChairlastnameTextBox.SendKeys("Morgan");
            Console.WriteLine("Added for lastname");
            Thread.Sleep(1500);

            // Country
            IWebElement ChairCountrySelection = driver.FindElement(By.CssSelector(".mat-admin-level .mat-chairman .mat-country .location1"));
            ChairCountrySelection.Click();
            Console.WriteLine("Country Selected");
            Thread.Sleep(1500);

            // Office
            IWebElement ChairOfficeSelection = driver.FindElement(By.CssSelector(".mat-admin-level .mat-chairman .mat-office .office2"));
            ChairOfficeSelection.Click();
            Console.WriteLine("Office Selected");
            Thread.Sleep(1500);

            // Vertical
            IWebElement ChairVerticalSelection = driver.FindElement(By.CssSelector(".mat-admin-level .mat-chairman .mat-vertical .vertical .vertical2"));
            ChairVerticalSelection.Click();
            Console.WriteLine("Vertical Selected");
            Thread.Sleep(1500);

            // Horizontal
            IWebElement ChairHorizontalSelection = driver.FindElement(By.CssSelector(".mat-admin-level .mat-chairman .mat-horizontal .click2"));
            ChairHorizontalSelection.Click();
            Console.WriteLine("Horizontal Selected");
            Thread.Sleep(1500);

            // Managing Director
            // Name
            IWebElement DirfirstnameTextBox = driver.FindElement(By.CssSelector(".mat-admin-level .mat-managing-director .mat-name .firstname"));
            DirfirstnameTextBox.SendKeys("Sighn");
            Console.WriteLine("Added for fistname");
            IWebElement DirlastnameTextBox = driver.FindElement(By.CssSelector(".mat-admin-level .mat-managing-director .mat-name .lastname"));
            DirlastnameTextBox.SendKeys("Amey");
            Console.WriteLine("Added for lastname");
            Thread.Sleep(1500);

            // Country
            IWebElement DirCountrySelection = driver.FindElement(By.CssSelector(".mat-admin-level .mat-managing-director .mat-country .location2"));
            DirCountrySelection.Click();
            Console.WriteLine("Country Selected");
            Thread.Sleep(1500);

            // Office
            IWebElement DirOfficeSelection = driver.FindElement(By.CssSelector(".mat-admin-level .mat-managing-director .mat-office .office3"));
            DirOfficeSelection.Click();
            Console.WriteLine("Office Selected");
            Thread.Sleep(1500);

            // Vertical
            IWebElement DirVerticalSelection = driver.FindElement(By.CssSelector(".mat-admin-level .mat-managing-director .mat-vertical .vertical .vertical3"));
            DirVerticalSelection.Click();
            Console.WriteLine("Vertical Selected");
            Thread.Sleep(1500);

            // Horizontal
            IWebElement DirHorizontalSelection = driver.FindElement(By.CssSelector(".mat-admin-level .mat-managing-director .mat-horizontal .click3"));
            DirHorizontalSelection.Click();
            Console.WriteLine("Horizontal Selected");
            Thread.Sleep(1500);

            // CEO
            // Name
            IWebElement CeofirstnameTextBox = driver.FindElement(By.CssSelector(".mat-admin-level .mat-ceo .mat-name .firstname"));
            CeofirstnameTextBox.SendKeys("Bennedict");
            Console.WriteLine("Added for fistname");
            IWebElement CeolastnameTextBox = driver.FindElement(By.CssSelector(".mat-admin-level .mat-ceo .mat-name .lastname"));
            CeolastnameTextBox.SendKeys("Crossings");
            Console.WriteLine("Added for lastname");
            Thread.Sleep(1500);

            // Country
            IWebElement CeoCountrySelection = driver.FindElement(By.CssSelector(".mat-admin-level .mat-ceo .mat-country .location2"));
            CeoCountrySelection.Click();
            Console.WriteLine("Country Selected");
            Thread.Sleep(1500);

            // Office
            IWebElement CeoOfficeSelection = driver.FindElement(By.CssSelector(".mat-admin-level .mat-ceo .mat-office .office4"));
            CeoOfficeSelection.Click();
            Console.WriteLine("Office Selected");
            Thread.Sleep(1500);

            // Vertical
            IWebElement CeoVerticalSelection = driver.FindElement(By.CssSelector(".mat-admin-level .mat-ceo .mat-vertical .vertical .vertical4"));
            CeoVerticalSelection.Click();
            Console.WriteLine("Vertical Selected");
            Thread.Sleep(1500);

            // Horizontal
            IWebElement CeoHorizontalSelection = driver.FindElement(By.CssSelector(".mat-admin-level .mat-ceo .mat-horizontal .click4"));
            CeoHorizontalSelection.Click();
            Console.WriteLine("Horizontal Selected");
            Thread.Sleep(1500);

            // Executive Level (using XPATH)
            // President
            // Name
            IWebElement PresidentfirstnameTextBox = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[1]/input[1]"));
            PresidentfirstnameTextBox.SendKeys("Charles");
            Console.WriteLine("Added for fistname");
            IWebElement PresidentlastnameTextBox = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[1]/input[2]"));
            PresidentlastnameTextBox.SendKeys("Xavier");
            Console.WriteLine("Added for lastname");
            Thread.Sleep(1500);

            // Country
            IWebElement PresidentCountrySelection = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[2]/input[1]"));
            PresidentCountrySelection.Click();
            Console.WriteLine("Country Selected");
            Thread.Sleep(1500);

            // Office
            IWebElement PresidentOfficeSelection = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[3]/input[3]"));
            PresidentOfficeSelection.Click();
            Console.WriteLine("Office Selected");
            Thread.Sleep(1500);

            // Vertical
            IWebElement PresidentVerticalSelection = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[4]//select/option[2]"));
            PresidentVerticalSelection.Click();
            Console.WriteLine("Vertical Selected");
            Thread.Sleep(1500);

            // Horizontal
            IWebElement PresidentHorizontalSelection = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[5]/button[1]"));
            PresidentHorizontalSelection.Click();
            Console.WriteLine("Horizontal Selected");
            Thread.Sleep(1500);

            // Vice President
            // Name
            IWebElement VicePresidentfirstnameTextBox = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[6]//div[1]/input[1]"));
            VicePresidentfirstnameTextBox.SendKeys("Dominique");
            Console.WriteLine("Added for fistname");
            IWebElement VicePresidentlastnameTextBox = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[6]//div[1]/input[2]"));
            VicePresidentlastnameTextBox.SendKeys("Decoco");
            Console.WriteLine("Added for lastname");
            Thread.Sleep(1500);

            // Country
            IWebElement VicePresidentCountrySelection = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[6]//div[2]/input[2]"));
            VicePresidentCountrySelection.Click();
            Console.WriteLine("Country Selected");
            Thread.Sleep(1500);

            // Office
            IWebElement VicePresidentOfficeSelection = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[6]//div[3]/input[4]"));
            VicePresidentOfficeSelection.Click();
            Console.WriteLine("Office Selected");
            Thread.Sleep(1500);

            // Vertical
            IWebElement VicePresidentVerticalSelection = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[6]//div[4]//select/option[3]"));
            VicePresidentVerticalSelection.Click();
            Console.WriteLine("Vertical Selected");
            Thread.Sleep(1500);

            // Horizontal
            IWebElement VicePresidentHorizontalSelection = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[6]//div[5]/button[2]"));
            VicePresidentHorizontalSelection.Click();
            Console.WriteLine("Horizontal Selected");
            Thread.Sleep(1500);

            // General Manager
            IWebElement GeneralManagerfirstnameTextBox = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[6]//div[6]//div[1]/input[1]"));
            GeneralManagerfirstnameTextBox.SendKeys("Markus");
            Console.WriteLine("Added for fistname");
            IWebElement GeneralManagerlastnameTextBox = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[6]//div[6]//div[1]/input[2]"));
            GeneralManagerlastnameTextBox.SendKeys("Eurial");
            Console.WriteLine("Added for lastname");
            Thread.Sleep(1500);

            // Country
            IWebElement GeneralManagerCountrySelection = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[6]//div[6]//div[2]/input[2]"));
            GeneralManagerCountrySelection.Click();
            Console.WriteLine("Country Selected");
            Thread.Sleep(1500);

            // Office
            IWebElement GeneralManagerOfficeSelection = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[6]//div[6]//div[3]/input[5]"));
            GeneralManagerOfficeSelection.Click();
            Console.WriteLine("Office Selected");
            Thread.Sleep(1500);

            // Vertical
            IWebElement GeneralManagerVerticalSelection = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[6]//div[6]//div[4]//select/option[4]"));
            GeneralManagerVerticalSelection.Click();
            Console.WriteLine("Vertical Selected");
            Thread.Sleep(1500);

            // Horizontal
            IWebElement GeneralManagerHorizontalSelection = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[6]//div[6]//div[5]/button[3]"));
            GeneralManagerHorizontalSelection.Click();
            Console.WriteLine("Horizontal Selected");
            Thread.Sleep(1500);

            // Head of Department
            IWebElement HeadDepartmentfirstnameTextBox = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[6]//div[6]//div[6]//div[1]/input[1]"));
            HeadDepartmentfirstnameTextBox.SendKeys("Shravan");
            Console.WriteLine("Added for fistname");
            IWebElement HeadDepartmentlastnameTextBox = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[6]//div[6]//div[6]//div[1]/input[2]"));
            HeadDepartmentlastnameTextBox.SendKeys("Monte");
            Console.WriteLine("Added for lastname");
            Thread.Sleep(1500);

            // Country
            IWebElement HeadDepartmentCountrySelection = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[6]//div[6]//div[6]//div[2]/input[2]"));
            HeadDepartmentCountrySelection.Click();
            Console.WriteLine("Country Selected");
            Thread.Sleep(1500);

            // Office
            IWebElement HeadDepartmentOfficeSelection = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[6]//div[6]//div[6]//div[3]/input[6]"));
            HeadDepartmentOfficeSelection.Click();
            Console.WriteLine("Office Selected");
            Thread.Sleep(1500);

            // Vertical
            IWebElement HeadDepartmentVerticalSelection = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[6]//div[6]//div[6]//div[4]//select/option[2]"));
            HeadDepartmentVerticalSelection.Click();
            Console.WriteLine("Vertical Selected");
            Thread.Sleep(1500);

            // Horizontal
            IWebElement HeadDepartmentHorizontalSelection = driver.FindElement(By.XPath(".//*[@class='mat-executive-level']//div[6]//div[6]//div[6]//div[5]/button[4]"));
            HeadDepartmentHorizontalSelection.Click();
            Console.WriteLine("Horizontal Selected");
            Thread.Sleep(1500);

            timer.Stop();
            var elapsedTime = timer.ElapsedMilliseconds;
            Console.WriteLine("Total Execution Time: {0} sec", elapsedTime / 1000);
        }
    }
}

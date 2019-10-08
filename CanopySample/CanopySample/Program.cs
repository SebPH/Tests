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
using canopy;
using canopy.runner;
using canopy.parallell;
using _ = canopy.csharp.canopy;

namespace SeleniumSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // IP ADDRESS: 172.25.32.37
            //driver.Navigate().GoToUrl("http://localhost:8012/SeleniumProject/");    // Test Website 1
            //driver.Navigate().GoToUrl("http://localhost:8080/");    // Test Website 2

            string URL = "http://localhost:8012/SeleniumProject/";

            // Initial Set up
            configuration.autoPinBrowserRightOnLaunch = false;
            configuration.ieDir = TestContext.CurrentContext.TestDirectory;
            configuration.elementTimeout = 20;
            configuration.pageTimeout = 20;
            configuration.compareTimeout = 20;

            // Opening Browser
            _.start(types.BrowserStartMode.IE);
            _.pin(types.direction.FullScreen);

            // Go to specific URL
            _.url(URL);

            // Fill in First Name
            _.write("#firstname","John");

            // Fill in Last Last Name
            _.write("#lastname", "Snow");

            // Fill in Address
            _.write("#address", "4100 Fairfax Drive, Arlington NY");

            // Fill in Age
            _.write("#age","25");

            // Fill in Phone Number
            _.write("#phone", "019-178-1847");

            // Gender Selection
            _.click("#gender1");

            // Transportation Selection
            _.click("#vehicle4");

            // Snack Selection
            _.click("#wine");

            // SIGN UP
            // Fill in Email
            _.write("#signup-email", "johnsnow@gmail.com"); ;

            // Fill in Password
            _.write("#signup-password", "Stark_Tygerian");

            _.sleep(2);
            _.click("#signup-submit");
            _.sleep(2);

            _.navigate(functions.Navigate.Back);

            // LOGIN
            // Fill in Email
            _.write("#signin-email", "johnsnow@gmail.com"); ;

            // Fill in Password
            _.write("#signin-password", "Start_Tygerian");

            _.sleep(2);
            _.click("#signin-submit");
            _.sleep(2);

            _.navigate(functions.Navigate.Back);
            _.sleep(2);

            // Quit Browser
            _.quit();

        }
    }
}

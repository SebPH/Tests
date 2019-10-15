using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using canopy;
using canopy.runner;
using canopy.parallell;
using _ = canopy.csharp.canopy;

namespace CanopySelectorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Canopy Search order
            // findByCss
            // findByValue
            // findByPath
            // findByLabel
            // findByText
            // findByJQuery

            var timer = Stopwatch.StartNew();
            string URL = "http://localhost:8012/BusinessHierarchy/Canopy/";

            // Initial Set up
            configuration.autoPinBrowserRightOnLaunch = false;
            configuration.chromeDir = TestContext.CurrentContext.TestDirectory;
            configuration.elementTimeout = 10;
            configuration.pageTimeout = 10;
            configuration.compareTimeout = 10;
            configuration.optimizeBySkippingIFrameCheck = true;

            // Opening Browser
            _.start(types.BrowserStartMode.Chrome);
            _.pin(types.direction.FullScreen);

            // Go to specific URL
            _.url(URL);

            // Administrative Level - Using CssSelector
            // Board of Directors
            // Name
            _.write(".mat-admin-level .mat-board-directors .mat-name .firstname", "Jacob");
            _.highlight(".mat-admin-level .mat-board-directors .mat-name .firstname");
            Console.WriteLine("firstname has been added");
            _.write(".mat-admin-level .mat-board-directors .mat-name .lastname", "Thompson");
            _.highlight(".mat-admin-level .mat-board-directors .mat-name .lastname");
            Console.WriteLine("lastname has been added");
            _.sleep(1.5);

            // Country
            _.click(".mat-admin-level .mat-board-directors .mat-country .location1");
            _.highlight(".mat-admin-level .mat-board-directors .mat-country .location1");
            Console.WriteLine("Country has been selected");
            _.sleep(1.5);

            // Office
            _.click(".mat-admin-level .mat-board-directors .mat-office .office1");
            _.highlight(".mat-admin-level .mat-board-directors .mat-office .office1");
            Console.WriteLine("Office has been added");
            _.sleep(1.5);

            // Vertical
            _.click(".mat-admin-level .mat-board-directors .mat-vertical .vertical1");
            _.highlight(".mat-admin-level .mat-board-directors .mat-vertical .vertical1");
            Console.WriteLine("Vertical has been added");
            _.sleep(1.5);

            // Horizontal
            _.click(".mat-admin-level .mat-board-directors .mat-horizontal .click1");
            _.highlight(".mat-admin-level .mat-board-directors .mat-horizontal .click1");
            Console.WriteLine("Horizontal has been added");
            _.sleep(1.5);

            // Chairman
            _.write(".mat-admin-level .mat-chairman .mat-name .firstname", "Sherly");
            _.highlight(".mat-admin-level .mat-chairman .mat-name .firstname");
            _.write(".mat-admin-level .mat-chairman .mat-name .lastname", "Matthews");
            _.highlight(".mat-admin-level .mat-chairman .mat-name .lastname");
            Console.WriteLine("name has been added");
            _.sleep(1.5);

            // Country
            _.click(".mat-admin-level .mat-chairman .mat-country .location1");
            _.highlight(".mat-admin-level .mat-chairman .mat-country .location1");
            Console.WriteLine("Country has been selected");
            _.sleep(1.5);

            // Office
            _.click(".mat-admin-level .mat-chairman .mat-office .office1");
            _.highlight(".mat-admin-level .mat-chairman .mat-office .office1");
            Console.WriteLine("Office has been selected");
            _.sleep(1.5);

            // Vertical
            _.click(".mat-admin-level .mat-chairman .mat-vertical .vertical2");
            _.highlight(".mat-admin-level .mat-chairman .mat-vertical .vertical2");
            Console.WriteLine("Vertical has been selected");
            _.sleep(1.5);

            // Horizontal
            _.click(".mat-admin-level .mat-chairman .mat-horizontal .click2");
            _.highlight(".mat-admin-level .mat-chairman .mat-horizontal .click2");
            Console.WriteLine("Horizontal has been selected");
            _.sleep(2);

            // Managing Director
            _.write(".mat-admin-level .mat-managing-director .mat-name .firstname", "Arun");
            _.highlight(".mat-admin-level .mat-managing-director .mat-name .firstname");
            _.write(".mat-admin-level .mat-managing-director .mat-name .lastname", "Shrivan");
            _.highlight(".mat-admin-level .mat-managing-director .mat-name .lastname");
            Console.WriteLine("name has been added");
            _.sleep(1.5);

            // Country
            _.click(".mat-admin-level .mat-managing-director .mat-country .location2");
            _.highlight(".mat-admin-level .mat-managing-director .mat-country .location2");
            Console.WriteLine("Country has been selected");
            _.sleep(1.5);

            // Office
            _.click(".mat-admin-level .mat-managing-director .mat-office .office3");
            _.highlight(".mat-admin-level .mat-managing-director .mat-office .office3");
            Console.WriteLine("Office has been selected");
            _.sleep(1.5);

            // Vertical
            _.click(".mat-admin-level .mat-managing-director .mat-vertical .vertical3");
            _.highlight(".mat-admin-level .mat-managing-director .mat-vertical .vertical3");
            Console.WriteLine("Vertical has been selected");
            _.sleep(1.5);

            // Horizontal
            _.click(".mat-admin-level .mat-managing-director .mat-horizontal .click3");
            _.highlight(".mat-admin-level .mat-managing-director .mat-horizontal .click3");
            Console.WriteLine("Horizontal has been added");
            _.sleep(1.5);

            // CEO
            _.write(".mat-admin-level .mat-ceo .mat-name .firstname", "Anju");
            _.highlight(".mat-admin-level .mat-ceo .mat-name .firstname");
            _.write(".mat-admin-level .mat-ceo .mat-name .lastname", "Ricmund");
            _.highlight(".mat-admin-level .mat-ceo .mat-name .lastname");
            Console.WriteLine("name has been added");
            _.sleep(1.5);

            // Country
            _.click(".mat-admin-level .mat-ceo .mat-country .location2");
            _.highlight(".mat-admin-level .mat-ceo .mat-country .location2");
            Console.WriteLine("Country has been selected");
            _.sleep(1.5);

            // Office
            _.click(".mat-admin-level .mat-ceo .mat-office .office4");
            _.highlight(".mat-admin-level .mat-ceo .mat-office .office4");
            Console.WriteLine("Office has been selected");
            _.sleep(1.5);

            // Vertical
            _.click(".mat-admin-level .mat-ceo .mat-vertical .vertical1");
            _.highlight(".mat-admin-level .mat-ceo .mat-vertical .vertical1");
            Console.WriteLine("Vertical has been selected");
            _.sleep(1.5);

            // Horizontal
            _.click(".mat-admin-level .mat-ceo .mat-horizontal .click4");
            _.highlight(".mat-admin-level .mat-ceo .mat-horizontal .click4");
            Console.WriteLine("Horizontal has been added");
            _.sleep(1.5);

            // Executive Level - Using XPATH
            // President
            // Name
            _.write(".//*[@class='mat-executive-level']/div[1]/div[1]/input[1]", "Arkson");
            _.highlight(".//*[@class='mat-executive-level']/div[1]/div[1]/input[1]");
            _.write(".//*[@class='mat-executive-level']/div[1]/div[1]/input[2]", "Jenine");
            _.highlight(".//*[@class='mat-executive-level']/div[1]/div[1]/input[2]");
            Console.WriteLine("name has been added");
            _.sleep(1.5);

            // Country
            _.click(".//*[@class='mat-executive-level']/div[1]/div[2]/input[1]");
            _.highlight(".//*[@class='mat-executive-level']/div[1]/div[2]/input[1]");
            Console.WriteLine("Country has been selected");
            _.sleep(1.5);

            // Office
            _.click(".//*[@class='mat-executive-level']/div[1]/div[3]/input[1]");
            _.highlight(".//*[@class='mat-executive-level']/div[1]/div[3]/input[1]");
            Console.WriteLine("Office has been selected");
            _.sleep(1.5);

            // Vertical
            _.click(".//*[@class='mat-executive-level']/div[1]/div[4]/select/option[2]");
            _.highlight(".//*[@class='mat-executive-level']/div[1]/div[4]/select/option[2]");
            Console.WriteLine("Vertical has been selected");
            _.sleep(1.5);

            // Horizontal
            _.click(".//*[@class='mat-executive-level']/div[1]/div[5]/button[1]");
            _.highlight(".//*[@class='mat-executive-level']/div[1]/div[5]/button[1]");
            Console.WriteLine("Horizontal has been added");
            _.sleep(1.5);

            // Vice President
            // Name
            _.write(".//*[@class='mat-executive-level']/div[2]/div[1]/input[1]", "Pietro");
            _.highlight(".//*[@class='mat-executive-level']/div[2]/div[1]/input[1]");
            _.write(".//*[@class='mat-executive-level']/div[2]/div[1]/input[2]", "Axel");
            _.highlight(".//*[@class='mat-executive-level']/div[2]/div[1]/input[2]");
            Console.WriteLine("name has been added");
            _.sleep(1.5);

            // Country
            _.click(".//*[@class='mat-executive-level']/div[2]/div[2]/input[1]");
            _.highlight(".//*[@class='mat-executive-level']/div[2]/div[2]/input[1]");
            Console.WriteLine("Country has been selected");
            _.sleep(1.5);

            // Office
            _.click(".//*[@class='mat-executive-level']/div[2]/div[3]/input[2]");
            _.highlight(".//*[@class='mat-executive-level']/div[2]/div[3]/input[2]");
            Console.WriteLine("Office has been selected");
            _.sleep(1.5);

            // Vertical
            _.click(".//*[@class='mat-executive-level']/div[2]/div[4]/select/option[3]");
            _.highlight(".//*[@class='mat-executive-level']/div[2]/div[4]/select/option[3]");
            Console.WriteLine("Vertical has been selected");
            _.sleep(1.5);

            // Horizontal
            _.click(".//*[@class='mat-executive-level']/div[2]/div[5]/button[2]");
            _.highlight(".//*[@class='mat-executive-level']/div[2]/div[5]/button[2]");
            Console.WriteLine("Horizontal has been added");
            _.sleep(1.5);

            // General Manager
            // Name
            _.write(".//*[@class='mat-executive-level']/div[3]/div[1]/input[1]", "Magestro");
            _.highlight(".//*[@class='mat-executive-level']/div[3]/div[1]/input[1]");
            _.write(".//*[@class='mat-executive-level']/div[3]/div[1]/input[2]", "Folkson");
            _.highlight(".//*[@class='mat-executive-level']/div[3]/div[1]/input[2]");
            Console.WriteLine("name has been added");
            _.sleep(1.5);

            // Country
            _.click(".//*[@class='mat-executive-level']/div[3]/div[2]/input[2]");
            _.highlight(".//*[@class='mat-executive-level']/div[3]/div[2]/input[2]");
            Console.WriteLine("Country has been selected");
            _.sleep(1.5);

            // Office
            _.click(".//*[@class='mat-executive-level']/div[3]/div[3]/input[5]");
            _.highlight(".//*[@class='mat-executive-level']/div[3]/div[3]/input[5]");
            Console.WriteLine("Office has been selected");
            _.sleep(1.5);

            // Vertical
            _.click(".//*[@class='mat-executive-level']/div[3]/div[4]/select/option[4]");
            _.highlight(".//*[@class='mat-executive-level']/div[3]/div[4]/select/option[4]");
            Console.WriteLine("Vertical has been selected");
            _.sleep(1.5);

            // Horizontal
            _.click(".//*[@class='mat-executive-level']/div[3]/div[5]/button[3]");
            _.highlight(".//*[@class='mat-executive-level']/div[3]/div[5]/button[3]");
            Console.WriteLine("Horizontal has been added");
            _.sleep(1.5);

            // Head of Department
            // Name
            _.write(".//*[@class='mat-executive-level']/div[4]/div[1]/input[1]", "Kutrik");
            _.highlight(".//*[@class='mat-executive-level']/div[4]/div[1]/input[1]");
            _.write(".//*[@class='mat-executive-level']/div[4]/div[1]/input[2]", "Khan");
            _.highlight("//*[@class='mat-executive-level']/div[4]/div[1]/input[2]");
            Console.WriteLine("name has been added");
            _.sleep(1.5);

            // Country
            _.click(".//*[@class='mat-executive-level']/div[4]/div[2]/input[2]");
            _.highlight(".//*[@class='mat-executive-level']/div[4]/div[2]/input[2]");
            Console.WriteLine("Country has been selected");
            _.sleep(1.5);

            // Office
            _.click(".//*[@class='mat-executive-level']/div[4]/div[3]/input[6]");
            _.highlight(".//*[@class='mat-executive-level']/div[4]/div[3]/input[6]");
            Console.WriteLine("Office has been selected");
            _.sleep(1.5);

            // Vertical
            _.click(".//*[@class='mat-executive-level']/div[4]/div[4]/select/option[3]");
            _.highlight(".//*[@class='mat-executive-level']/div[4]/div[4]/select/option[3]");
            Console.WriteLine("Vertical has been selected");
            _.sleep(1.5);

            // Horizontal
            _.click(".//*[@class='mat-executive-level']/div[4]/div[5]/button[4]");
            _.highlight(".//*[@class='mat-executive-level']/div[4]/div[5]/button[4]");
            Console.WriteLine("Horizontal has been added");
            _.sleep(1.5);

            _.quit();

            timer.Stop();
            var elapsedTime = timer.ElapsedMilliseconds;
            Console.WriteLine("Total Execution Time: {0} sec", elapsedTime / 1000);
            Console.ReadLine();
        }
    }
}

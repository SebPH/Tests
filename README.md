TESTING Microsoft Sql Server
Sample database implementation to store and access data

Test:
DatabaseTest

TESTING AUTOMATION
Host sample page on either XAMPP, Nodejs, or any other server that you're familiar with

XAMPP
> download - https://www.apachefriends.org/index.html
> place folder inside of htdocs folder e.g. c:/xampp/htdocs/SeleniumProject
> check that port 80 is not in use, if it is change it to 8012
> start apache server

Nodejs
> download - https://nodejs.org/en/
> place folder in any directory that's easy to access
> on the command prompt go to the folder dir e.g. c:/Users/<username>/Desktop/SeleniumProject/
> make sure that you have the following packages: express, fs, cors. Otherwise do, npm install <package-name>
> finally run, node server.js on cmd, you get a message stating that where you're currently hosting
> open up browser and go to url location

Once you have hosted the page, copy your localhost url e.g. "http://localhost:80/SeleniumProject/"

Sample Page - SeleniumProject

Test:
1) SeleniumSample
2) CanopySample (uses selenium)
3) CanopyStandAloneSample (F# implementation)
4) CucumberSample + SpecFlowDemo (Cucumber/SpecFlow) --> SpecFlow for C#

The tests are ran on the sample page which is meant to go over basic automation of:
1) Textbox
2) Button Click
3) Radio Button Selection
4) Check Box Selection
5) Dropdown

Benefits of using Canopy with Selenium is that it offers other features on top of Selenium, also
the length of the logic is reduced

Nuget Packages:
- WebDriver
- Selenium (get browser driver -> check your browser version and match it with the WebDriver version
- Canopy
- NUnit + NunitAdapter

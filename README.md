=======================TESTING Microsoft Sql Server ================================================
Sample database implementation to store and access data

Test:
DatabaseTest

=========================TESTING AUTOMATION==========================================================
Host sample page on either XAMPP, Nodejs, or any other server that you're familiar with

Once you have hosted the page, copy your localhost url e.g. "http://localhost:80/SeleniumProject/"

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

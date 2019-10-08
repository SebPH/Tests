Feature: sample
	Just testing out some of the features
	offered by Cucumber. Testing some basic
	commands on a sample website on localhost.

Background: User is on home page

@mytag
Scenario: Automate Sample Page
	Given  Visit sample page
	When User inputs data in all the fields on the signup section
	And user clicks on the signup button
	When user inputs data in all the fields on the login section
	And user clicks on the login button
	Then automation test is complete and browser closes




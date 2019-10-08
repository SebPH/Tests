Feature: sample
	Just testing out some of the features
	offered by Cucumber. Testing some basic
	commands on a sample website on localhost.

Background: User is on home page

@mytag
Scenario: Automate Sample Page
	Given user opens up browsers and goes to sample page
	When user writes in data for all fields
	And user submits
	Then user exits





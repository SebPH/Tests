Feature: BusinessHierarchyFeature
	Testing SpecFlow, Selenium, Canopy
	In order to try different ways to 
	Access HTML elements.

@mytag
Scenario: Successful input data for administrative and executive levels
	Given I have opened up the browser
	When I fill in all the data fields for all administrative levels
	And I fill in all the data fields for all executive levels
	Then I close the browser

Feature: Managment Team
As a user I want to click the management team menu items So that we can see that the correct page is displayed

Scenario: Check if correct page is displayed
	Given I am on the Home Page
	And Menu item opened
	And Who We Are submenu opened
	When I click on Managment team link
	Then Managment team page opened

Scenario: Verify that the URL of the first image is present
	When Managment team page opened
	Then The URL of the first image is present


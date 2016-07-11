Feature: Purchase Book Of Month
As a user I want go to the Euromoney store So that I can purchase the book of the month

//Background: 
//	Given Driver opened. URL set

Scenario: Check "Store" link
	Given I'am on Home Page
	When I open menu item
	Then The Euromoney Store link displayed correctly on the menu item

Scenario: Check if "Store" link navigate to store
	Given Menu item opened on the home page
	When I press on Store link 
	Then It navigates to the online store

Scenario: Chaeck if "More details" navigate to details page
	Given I am on Store page
	When I press more details link on the book of month
	Then it navigates to the details page

Scenario: Check if "Add to Cart"add book to the shopping cart and the price of the book is displayed in GBP
	Given I am on Book of month details page
	When I click Add to cart
	Then Book of the month is added to the shopping cart
	And The price of the book is displayed in GBP


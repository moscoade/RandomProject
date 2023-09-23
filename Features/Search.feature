Feature: Search

As a user of KL
	I want to search for items
	


Scenario: [Items Search]
	Given I navigate to the website "https://cms.demo.katalon.com/"
	When I add three random items to my cart
	And I view my cart
	Then I am able to verify three items in my cart


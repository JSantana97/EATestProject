Feature: Login
	Check if the login functionality is working
	as expected with different permutations and 
	combinations of data

Background: 
	#Given I Delete ... before I start running test

@smoke @positive
Scenario: Check Login with correct username and password
	Given I have navigated to the application
	And I see application opened
	When I enter UserName and Password
	|         email         |    pass   |
	| sh4dow18711@gmail.com | MGshadow7 |
	Then I click login button
	Then I should see the Messenger to the left of the screen
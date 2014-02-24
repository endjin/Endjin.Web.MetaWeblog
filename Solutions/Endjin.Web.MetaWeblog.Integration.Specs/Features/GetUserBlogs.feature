Feature: GetUserBlogs
	In order to validate that the current user has a valid account with the MetaWeblog service
	As Windows Live Writer
	I want to be provided with valid account details

Scenario: Request valid account details
	Given I have a user with an AppKey of "0123456789ABCDEF" 
	And the username "Alice" 
	And a password "Waddicor" 
	And I want to validate that the current user has a valid account with the MetaWeblog service
	When I send the details to the MetaWeblog endpoint
	Then I should recieve a valid response
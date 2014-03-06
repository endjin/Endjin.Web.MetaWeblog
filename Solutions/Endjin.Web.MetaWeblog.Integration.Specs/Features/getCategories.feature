Feature: getCategories
	In order to be able to provide users with a list of blog categories 
	As Windows LiveWriter
	I want to be provided with a list of all categories for the blog

@mytag
Scenario: Request categories for the blog
	Given I have a user with an AppKey of "0123456789ABCDEF" 
	And the username "Alice" 
	And a password "Waddicor" 
	#Should I provide a list of blog categories here, or will we actually retrieve the categories in the test? At the moment these details are being provided in the processor
	And I want to be able to provide users with a list of blog categories 
	When I send the details to the MetaWeblog endpoint
	Then I should receive a valid response
	#Should I say (& test) what will be in the response? 
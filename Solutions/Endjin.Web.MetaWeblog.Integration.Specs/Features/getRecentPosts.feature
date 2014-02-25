Feature: getRecentPosts
	In order to be able to provide users with details of recent blog posts
	As Windows LiveWriter
	I want to be provided with a list of recent posts, their content, and relevant metadata

@mytag
Scenario: Request recent posts for a blog
	Given I have a user with an AppKey of "0123456789ABCDEF" 
	And the username "Alice" 
	And a password "Waddicor" 
	#Should I provide a list of blog posts here? At the moment these details are being provided in the processor
	And I want to be able to provide users with details of the previous blog post
	When I send the details to the MetaWeblog endpoint
	Then I should recieve a valid response
	#Should I say (& test) what will be in the response? 
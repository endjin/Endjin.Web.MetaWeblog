Feature: BloggerDeletePost
	In order to be able to allow users to delete blog posts
	As Windows LiveWriter
	I want to be able to ask the site to delete a blog post

@mytag
Scenario: Request to delete a blog post
	Given I have a user with an AppKey of "0123456789ABCDEF" 
	And the username "Alice" 
	And a password "Waddicor" 
	And I want to be able to delete a blog post with the id "/blog/blog1"
	When I send the details to the MetaWeblog endpoint
	Then I should receive a valid response
	#Should I say (& test) what will be in the response? 
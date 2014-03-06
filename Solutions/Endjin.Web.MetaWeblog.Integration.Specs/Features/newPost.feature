Feature: newPost
	In order to be able to add a new blog post to the site
	As Windows LiveWriter
	I want be able to send the endpoint the content and metadata for a new blog post

Scenario: Add a new blog post to the site as a draft
#Does this request provide the app key? 
	Given I have a user with an AppKey of "0123456789ABCDEF"
	Given the username "Alice" 
	And a password "Waddicor" 
	And the blogId is 1
	And I want to be able to add a new blog post to the site, with the title "Blog 1", the description "Here's the content", and the categories "cloud, apprenticeships"
	And it should be added as a draft
	When I send the details to the MetaWeblog endpoint
	Then I should receive a valid response
	#And the post should be added to the site as a draft

Scenario: Add a new blog post to the site and publish it
#Does this request provide the app key? 
	Given I have a user with an AppKey of "0123456789ABCDEF"
	Given the username "Alice" 
	And a password "Waddicor" 
	And the blogId is 1
	And I want to be able to add a new blog post to the site, with the title "Blog 1", the description "Here's the content", and the categories "cloud, apprenticeships"
	And it should be published
	When I send the details to the MetaWeblog endpoint
	Then I should receive a valid response
	#And the post should be added to the site and published
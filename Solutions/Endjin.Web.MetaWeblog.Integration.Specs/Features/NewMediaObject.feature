Feature: newMediaObject
	In order to be able to add a new image to a blog post
	As Windows LiveWriter
	I want be able to send the endpoint metadata and content in base64 for a new image

Scenario: Add a new image to the blog
	Given the username "Alice" 
	And a password "Waddicor" 
	And the blogId is 1
	And I want to be able to add a new image to the blog, with the name "Ponies.png", the type "image/png", and the base64 content "iVBORw0KGgoAAAANSUhEUgAAABYAAAATCAYAAACUef2IAAAABGdBTUEAALGPC/xhBQAAAAlwSFlzAAAOwwAADsMBx2+oZAAAACtJREFUOE9j0LQM+08LPCQNDgUyqI9HDYbjUYPheNRgOB41GI5HDYbi0P8ABT/Ljb1LitEAAAAASUVORK5CYII="
	When I send the details to the MetaWeblog endpoint
	Then I should receive a valid response
	#And the image should be added to the blog's media area
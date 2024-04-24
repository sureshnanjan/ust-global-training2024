@herokuapp
Feature: Heroku App Features for Training

A short summary of the feature

@homepage
Scenario: scenario name
	Given context
	When action
	Then outcome

@addremovepage
Scenario: My Second Scenario
	Given context
	When action
	Then outcome

Scenario: My Third Scenario
	Given I have "10" Examples
	Given I have "100" Examples
	Given I have "200" Examples

@tablehandling
Scenario: Handling Tables data
	Given I have the following table of data
	| Heading1 | Heading2 |
	| row1col1 | row1col2 |
	| row2col1 | row2col2 |

@stringhandling
Scenario: Handling multiline string
	Given I have a long multiline string
	""" 
	This is a ling text with 
	line2 
	and line3 with all forms of 
	endline and stuff
	"""

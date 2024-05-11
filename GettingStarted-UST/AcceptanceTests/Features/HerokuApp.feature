@herokuapp
Feature: Heroku App Features for Training

A short summary of the feature
Background: Setting up a Special User
	Given I have a backbround step

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

Scenario: Pet store User scenario
	Given  I have these users lohgged in in the saystem
	| LanguagePreference | Favourite Category | Enable MyList | Enable MyBanner | username |
	| ja                 | fish               | enabled       | disabled        | suresh    |
	| en                 | fish               | enabled       | disabled        | suresh1    |

	Then I should validate them as per their preference

@tablehandling
Scenario: Handling Tables data
	Given I have the following table of data
	| Heading1 | Heading2 |
	| row1col1 |		  |
	| row2col1 | row2col2 |


Scenario: Calculate policy premium
	Given users with the following data
	| age | accedinedt | income | premium | expected res |

@stringhandling
Scenario: Handling multiline string
	Given I have a long multiline string
	""" 
	This is a ling text with 
	line2 
	and line3 with all forms of 
	endline and stuff
	"""

Scenario: Checking the ccucumber Expressions
	Given I have a number 10 and a string 'suresh' and then i also have a float 100.112

Scenario Outline: This is a example by specification
	Given I  have multiple <names> and <marks>
	Then <grade> should be cchecked
	
	Examples: 
	| names    | marks | grade |
	| suresh   | 10    | A     |
	| ramesh   | 20    | A+    |
	| someone  | 30    | A++   |
	| one more | 20    | A+    |
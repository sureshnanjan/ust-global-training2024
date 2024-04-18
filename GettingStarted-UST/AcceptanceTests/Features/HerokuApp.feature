Feature: Feature1

A short summary of the feature

@tag1
Scenario: homePageTitleisCorrect
	Given HerokuApp webpage is opened
	When User review the title of Home Page 
	Then It is displayed as "Welcome to the-internet"

@tag1 
Scenario: homePageSubTitleisCorrect
	Given HerokuApp webpage is opened
	When User review the Subtitle of Home Page 
	Then It is displayed as "Available Examples" 

@tag1
Scenario: homePageHas44Links
	Given HerokuApp Home page is displayed
	When User review the number of links displayed
	Then 44 links displayed 
	
	

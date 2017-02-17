Feature: OrangeHrSearch
	Search for Users on OrangeHr webpage

@mytag
Scenario: Sucessfull search for User
	Given Given the user is on SiteUrl: "https://enterprise-demo.orangehrmlive.com/auth/login"
	And he enters Admin
	And user enters admin
	And click Login button
	And Admin click on Admni button
    And Admin clik on Organiztion dropdown
	And Admin sellect Locations
	And He enters Location Name: "Australia"
	When he click search button
	Then he check if location is selected: "Australia" 

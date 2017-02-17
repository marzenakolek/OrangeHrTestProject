Feature: 1_OrangeHrAddToListFeature
	
	I want to add to list new location

@mytag
Scenario: Sucessfull adding new location to list
	Given Given the user is on SiteUrl: "https://enterprise-demo.orangehrmlive.com/auth/login"
	And he enters Admin
	And user enters admin
	And click Login button
	And Admin click on Admni button
    And Admin clik on Organiztion dropdown
	And Admin sellect Locations
	And click Add buttom
    And goes on page: "admin/location"
	And user enter: "Jan Kowalski" as Name
	And enter: "śląsk " as State
	And enter: "Katowice" as City
	And enter:"Katowice ul. Korfantego 99" as Adrres  
	And enter: "00-888" as Zip Code
	And enter: "676767767" as Phone 
	And enter: "998987689" as  Fax   
	And enter: "No notes" as Notes
	And sellect "Poland" in Country
	And sellect "Europe/Rome" in Time Zone
	When click Save button
    Then new location is added to list
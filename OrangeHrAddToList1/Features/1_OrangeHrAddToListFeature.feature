Feature: 1_OrangeHrAddToListFeature
	
	I want to add to list new location

@mytag
Scenario: Sucessfull adding new location to list
	Given user is on page:"admin/viewLocations"
	When click Add buttom
    Then goes on page: "admin/location"
	When user enters valid credentials:
	| Key             | Value                      |
	| Name            | Jan Kowalski               |
	| State           | śląsk                      |
	| City            | Katowice                   |
	| Adrres          | Katowice ul. Korfantego 99 |
	| Zip Code        | 00-888                     |
	| Phone           | 676767767                  |
	| Fax             | 998987689                  |
	| Notes           | No notes                   |
	And sellect "Poland" in Country
	And sellect "Europe/Rome" in Time Zone
	And click Save button
    Then new location is added to list
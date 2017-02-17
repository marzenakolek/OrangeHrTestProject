Feature: OrangeHr LogIn
	I want to Log In on Website
@mytag
Scenario Outline: Succesfull LogIn on page

	Given the user is on SiteUrl: "https://enterprise-demo.orangehrmlive.com/auth/login"
	And he enters <Username> <Password> <ShouldBeAdmin> <Webpage> <ErrorWebpage> 
	And user enters <Password>
	And click Login button
	When user is on page:"https://enterprise-demo.orangehrmlive.com/dashboard"
	Then User is <Login as>
	Examples: 
	| Username      | Password      | Login as    |
	| Admin         | admin         | Admin       |
	| anthony.nolan | anthony.nolan | Anthony     |

	Scenario: Unsccesfull LogIn on page

	Given the user is on page: "https://enterprise-demo.orangehrmlive.com/auth/login"
	When he enters "KowlaskiJan" as Username
	And he enters "test111" as Password
	And click Login button
	Then box "https://enterprise-demo.orangehrmlive.com/securityAuthentication/retryLogin" is dysplayed
	
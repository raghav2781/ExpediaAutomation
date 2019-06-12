Feature: Sign In tests on Automationpratice.com


Scenario: Sign in with no Credentials test

	Given Open automation HomePage
	When Click on Sign In button on HomePage
	When Leave Email and Password field empty and click on SignIn Button on SignInPage
	Then The correct message should be display
	Then Close the chrome


Scenario: Sign in with only emailId Credentials test

	Given Open automation HomePage
	When Click on Sign In button on HomePage
	When Enter Email and leave Password field empty and click on SignIn Button on SignInPage
	Then The correct message should be display without password
	Then Close the chrome

Scenario: Sign in with only Password Credentials test

	Given Open automation HomePage
	When Click on Sign In button on HomePage
	When leave Email empty and enter Password and click on SignIn Button on SignInPage
	Then The correct message should be display without email
	Then Close the chrome

	Scenario: Sign in with incorrect Credentials test

	Given Open automation HomePage
	When Click on Sign In button on HomePage
	When enter Incorrect EmailId and Password and click on SignIn Button on SignInPage
	Then The correct message should be display with incorrect credentials
	Then Close the chrome

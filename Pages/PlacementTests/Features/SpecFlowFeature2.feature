Feature: Start page
	In order to know my level in English
	As a student
	I want to do a placement test

Background:
   Given placement test settings as follows
		| NumberOfAnswers | TimeOfTest | AbandonCount |
		| 3               | 600      | 5            |
	And user with placement test request
	And I have logged into the portal

	
Scenario: Click on Placement Test button when there are no previous tests
	When Click on Placement Test button when there are no previous tests
	Then I will See the view with 'Allocate' button enabled
	And I will see empty test table 
	And  I will see close button from the right side of the 'Allocate' button
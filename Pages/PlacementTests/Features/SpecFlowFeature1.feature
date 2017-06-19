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

	
Scenario: See "Placement Test" button in customer page
	When I go to customer page from the dashboard
	Then I will See "Placement Test" button
	And The button will be next to Process Sale button






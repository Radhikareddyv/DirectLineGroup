Feature: Verify Vehicle Registration Number
As a customer
I want to able to check my vehicle registration number exists

Scenario: Verify Vehicle exists
	Given I am on insurance portal page
	When I enter vehicle registration number "OV12UYY"
	And  I click on Find Vehicle
	Then I should able to see vehicle registration number "OV12UYY"
	
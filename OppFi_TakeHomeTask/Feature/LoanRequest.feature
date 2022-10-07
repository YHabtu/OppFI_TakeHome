Feature: LoanRequest
	This test covers where users send Loan request and Gets accepted or declined.

@HappyPath
Scenario: Send Post request to offer endpoint where request got accpeted
	Given user creates request body using the following info
	| attribute            | value            |
	| socialSecurityNumber | 123456780        |
	| stateCode            | FL               |
	| grossMonthlyIncome   | 100000           |
	| requestedLoanAmount  | 4000             |
	| leadOfferId          | kgj25sdd2        |
	| email                | test@example.com |
	When user send POST request to offer endpoint with valid APIkey
	Then verify status code is 200
	Then verify the correct response body

@Negative
Scenario: Send Post request to offer endpoint where request got declined
	Given user creates request body using the following info
	| attribute            | value            |
	| socialSecurityNumber | 123450000        |
	| stateCode            | IL               |
	| grossMonthlyIncome   | 2800             |
	| requestedLoanAmount  | 4000             |
	| leadOfferId          | kgj25sdd2        |
	| email                | test@example.com |
	When user send POST request to offer endpoint with valid APIkey
	Then verify status code is 200
	Then verify the declined correct response body


@MissingField
Scenario Outline: Send request with missing required field
	Given user creates request body using the following info
	| attribute            | value            |
	| socialSecurityNumber | 123450000        |
	| stateCode            | IL               |
	| grossMonthlyIncome   | 2800             |
	| requestedLoanAmount  | 4000             |
	| leadOfferId          | kgj25sdd2        |
	| email                | test@example.com |
	When user send POST request to offer endpoint with invalid APIkey
	Then verify status code is 403
	And error message is "Valid API Key required"

@MissingField
Scenario Outline: Send request with missing required data
	Given user creates request body using the following info
	| attribute            | value            |
	| socialSecurityNumber | ""               |
	| stateCode            | ""               |
	| grossMonthlyIncome   | ""               |
	| requestedLoanAmount  | ""               |
	| leadOfferId          | ""               |
	| email                | test@example.com |
	When user send POST request to offer endpoint with valid APIkey
	Then verify status code is 200
	Then verify the declined correct response body
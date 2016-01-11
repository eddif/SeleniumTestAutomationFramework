Feature: PricingPlan
	
	As a porspective customer
	I want to change pricing plans
	So I can review which plan is the best option for my business

@pricingOptions
Scenario: Pricing plan is Monthly, Service Type is Employee Scheduling, Text Message Support is United States
	Given I am on the Pricing Page
	And I have selected the "Employee Scheduling" service type only
	And I toggle price plan to "Monthly"
	And Local Text Message support is "United States"
	When I update Pricing Slider to 10
	Then the price amount displayed is 29
	| US_single_service_monthly |
	| 9                         |
	| 9                         |
	| 19                        |
	| 19                        |
	| 29                        |
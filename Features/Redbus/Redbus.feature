Feature: Redbus Booking

A short summary of the feature

@redbus
Scenario: Search and Book Redbus seat
	Given Launch the website for Redbus
	When Click on From and select "<FromCity>" 
	And Click on To and select "<ToCity>"
	Then Select the Date
	And Click on Search
	
	Examples:
| TestNo | FromCity | ToCity |
| 1      | Mumbai   | Delhi  |
| 2      | Pune     | Nagpur |


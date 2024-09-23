@BookAppointment
Feature: 2_BookAppoitmentTests

A short summary of the feature
@BookAppointment
Scenario Outline:Login and Book Appoitments 

Given  Launch the website for scriptAssist
When Login with Valid credentials "<UserName>" and "<Password>"
Then Verify that the user is been successfully logged in
When Click on Book Appoitments
And Select The Doctor
And Choose the Apportment Type
Then Click on Video 
And Choose The Date
Then Select the TimeSlot



Examples: 
| UserName                                 | Password         |
| gautam.marathe@scriptassistinterview.com | q7*Q?xXE8mB9     |


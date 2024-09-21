@Login
Feature:Login Scenarios

@Login
Scenario Outline:Login to ScriptAssist Website using Valid credentials

Given  Launch the website for scriptAssist
When Login with Valid credentials "<UserName>" and "<Password>"
Then Verify that the user is been successfully logged in

Examples: 
| UserName                                 | Password         |
| gautam.marathe@scriptassistinterview.com | q7*Q?xXE8mB9     |
| ascbahscbajsbcjaosc@gmail.com            | ascasncnausbcjas |




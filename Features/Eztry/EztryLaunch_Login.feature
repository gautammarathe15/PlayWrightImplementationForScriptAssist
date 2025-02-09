Feature: EztryLaunch_Login

@Login
Scenario Outline:Login to Eztry Website using Valid credentials

Given Launch the website for Eztry
When Login with Valid credentials For Eztry "<UserName>" and "<Password>"
And Verify the "<UserName>" is displaying on home page
#Then Display the Username on home page
Then Upload User Photo
Then Upload Cloth Photo
And Fill The All Details
Then Click On Start
Then Verify That the image is Sussefully Tranformed
And Click on Logout 


Examples: 
| TestID | UserName                  | Password   |
| 1      | gauravmarathe98@gmail.com | TestJan123 |
| 2      | gautammarathe15@gmail.com | Gautam@15  |






@Login
Scenario Outline:Login to Eztry Website using In-Valid credentials

Given Launch the website for Eztry
When Login with Valid credentials For Eztry "<UserName>" and "<Password>"
Then Verify In-valid User Details Message

Examples: 
| UserName                  | Password   |
| gauravmarahe98@gmail.com | TestJan123 |






using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PlaywrightProjectToDemo.ScriptAssist.Demo.Tests.StepDefinitions
{
    [Binding]
    public class GenericSteps
    {
        private readonly ScenarioContext scenarioContext;
        private readonly IPage _page;
        LoginPage _loginPage;
        HomePage _homePage;
        public GenericSteps(ScenarioContext scenarioContext)
        {
           this.scenarioContext = scenarioContext;
            _page = (IPage)this.scenarioContext["_driver"];
             _loginPage=new LoginPage(_page);
            _homePage=new HomePage(_page);

        }
        [Given(@"Launch the website for scriptAssist")]
        public async Task GivenLaunchTheWebsiteForScriptAssist()
        {
            _page.SetDefaultTimeout(50000);
            await _page.GotoAsync("https://demo-mobile.scriptassist.co.uk");
            await _page.WaitForLoadStateAsync();      
            //await _page.PauseAsync();

        }

        [When(@"Login with Valid credentials ""([^""]*)"" and ""([^""]*)""")]
        public async Task LoginWithValidCredentials(string username, string password)
        {
           await _loginPage.LoginWithCredentials(username, password);
           //await _page.PauseAsync();
        }

        [Then(@"Verify that the user is been successfully logged in")]
        public async void VerifyThatTheUserIsBeenSuccessfullyLoggedIn()
        {
           await _homePage.VerifyTheSucessfulLogin();

        }
        [Given(@"Launch the website for Eztry")]
        public async Task GivenLaunchTheWebsiteForEztry()
        {
            _page.SetDefaultTimeout(50000);
            await _page.GotoAsync("https://dev.eztry.ai/");
            await _page.WaitForLoadStateAsync();
           // await _page.PauseAsync();
        }


        [When(@"Login with Valid credentials For Eztry ""([^""]*)"" and ""([^""]*)""")]
        public async Task WhenLoginWithValidCredentialsForEztryAnd(string Username, string Password)
        {

            await _loginPage.LoginforEztryWithCredrntials(Username, Password);
           // await _page.PauseAsync();

        }

        [Then(@"Verify In-valid User Details Message")]
        public async Task ThenVerifyIn_ValidUserDetailsMessage()
        {
            await _homePage.InvalidUser();
            //await _page.PauseAsync();
        }


        [Then(@"Upload User Photo")]
        public async Task ThenUploadUserPhoto()
        {
            await _homePage.UploadUserPhoto();
            //await _page.PauseAsync();
        }

        [Then(@"Upload Cloth Photo")]
        public async Task ThenUploadClothPhoto()
        {
         await _homePage.ThenUploadClothPhoto();
           // await _page.PauseAsync();
        }

        [Then(@"Fill The All Details")]
        public async Task ThenFillTheAllDetails()
        {
            await _homePage.SelectCloth();
            await _homePage.ClickandSelectAdavanceOption();
            //await _page.PauseAsync();
        }

        [Then(@"Click On Start")]
        public async Task ThenClickOnStart()
        {
       
            await _homePage.ClickStart();
            await _page.WaitForLoadStateAsync();
            //await _page.PauseAsync();

            //await _page.WaitForTimeoutAsync(60060);
        }

        [Then(@"Verify That the image is Sussefully Tranformed")]
        public async Task ThenVerifyThatTheImageIsSussefullyTranformed()
        {
           await _homePage.TranformedChecking();
           
        }
      
        [Then(@"Display the Username on home page")]
        public async Task ThenDisplayTheUsernameOnHomePage()
        {
            await _homePage.ShowUserID();
          
        }
        [Then(@"Click on Logout")]
        public async Task ThenClickOnLogout()
        {
           await _homePage.ClickLogout();
        }
        [When(@"Verify the ""([^""]*)"" is displaying on home page")]
        public async Task WhenVerifyTheIsDisplayingOnHomePage(string UserName)
        {
            //await _page.PauseAsync();
            await _homePage.ShowUserID(UserName);
        }











    }
}

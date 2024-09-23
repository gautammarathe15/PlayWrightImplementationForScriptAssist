using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}

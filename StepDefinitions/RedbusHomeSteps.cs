    using Microsoft.Playwright;
    using Microsoft.Playwright.NUnit;
    using PlayWrightImplementationForScriptAssist.StepDefinitions;
    using SpecFlow.Actions.Playwright;
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

    public class RedbusHomeSteps
    {
        private readonly ScenarioContext scenarioContext;
        private readonly IPage _page;
        LoginPage _loginPage;
        HomePage _homePage;
        public RedbusHomeSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            _page = (IPage)this.scenarioContext["_driver"];
            _loginPage = new LoginPage(_page);
            _homePage = new HomePage(_page);
        }
        [When(@"Click on From and select Mumbai City")]
        public async Task WhenClickOnFromAndSelectMumbaiCity()
        {
            await _homePage.SelectMumbaiCity();
            //await _page.PauseAsync();
        }
        [When(@"Click on From and select ""([^""]*)""")]
        public async Task WhenClickOnFromAndSelect(string fromCity)
        {
            await _homePage.SelectMumbaiCity(fromCity);
        }
        [When(@"Click on To and select ""([^""]*)""")]
        public async Task WhenClickOnToAndSelect(string tocity)
        {
            await _homePage.SelectToCity(tocity);
        }
        [Then(@"Select the Date")]
        public async Task ThenSelectTheDate()
        {
            await _homePage.BookDate();
        }
        [Then(@"Click on Search")]
        public async Task ThenClickOnSearch()
        {
            await _homePage.SearchClick();
        }
    }
}
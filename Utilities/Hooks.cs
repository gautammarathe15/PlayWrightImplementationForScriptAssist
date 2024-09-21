

namespace PlayWrightImplementationForScriptAssist.Utilities
{
    [Binding]
    public sealed class Hooks
    {
        private Driver driver;
        private readonly IPage _page;
        private readonly ScenarioContext scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [BeforeScenario("Login")]
        public void BeforeScenario()
        {
            driver=new Driver();
            scenarioContext["_driver"] = driver.Page;
           
        }

        [AfterScenario("Login")]
        public void AfterScenario()
        {
            driver.Dispose();
        }

    }
 
}

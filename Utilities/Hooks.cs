

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

        [BeforeScenario("Login", "BookAppointment")]
        public void BeforeScenario()
        {
            driver=new Driver();
            scenarioContext["_driver"] = driver.Page;
           
        }

        [AfterScenario("Login", "BookAppointment")]
        public void AfterScenario()
        {
            driver.Dispose();
        }

    }
 
}

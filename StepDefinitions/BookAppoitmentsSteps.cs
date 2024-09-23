

using PlayWrightImplementationForScriptAssist.Pages;

namespace PlayWrightImplementationForScriptAssist.StepDefinitions
{
    [Binding]
    public class BookAppoitmentsSteps
    {
        private readonly ScenarioContext scenarioContext;
        private readonly IPage _page;
        HomePage homepage;

        public BookAppoitmentsSteps(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            _page = (IPage)this.scenarioContext["_driver"];
            homepage = new HomePage(_page);
            
        }
        [When(@"Click on Book Appoitments")]
        public async Task WhenClickOnBookAppoitments()
        {
            
            await homepage.ClickBookAppointment();
            
        }
        [When(@"Select The Doctor")]
        public async Task WhenSelectTheDoctor()
        {
            await _page.PauseAsync();
            await homepage.ChooseDoctor();
        }
        [When(@"Choose the Apportment Type")]
        public async Task WhenChooseTheApportmentType()
        {
            await homepage.ChooseApportmentType();
        }
        [Then(@"Click on Video")]
        public async Task ThenClickOnVideo()
        {
            await homepage.ClickVideo();    
        }
        [Then(@"Choose The Date")]
        public async Task ThenChooseTheDate()
        {
            await homepage.ClickSelectedDate();
        }
        [Then(@"Select the TimeSlot")]
        public async Task ThenSelectTheTimeSlot()
        {
            await homepage.ClickSlot();
        }




        //[When(@"Select the Doctor")]
        //public async Task WhenSelectTheDoctor()
        //{
        //  throw new PendingStepException();
        // }


    }
}

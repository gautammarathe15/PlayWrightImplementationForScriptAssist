using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PlayWrightImplementationForScriptAssist.Pages
{
    public class HomePage : BasePage
    {
        private IPage _page;

        private ILocator loginAccount => _page.GetByRole(AriaRole.Button, new() { Name = "Gautam Marathe" });

        private ILocator BookAppointementLink => _page.Locator("div").Filter(new() { HasTextRegex = new Regex("^BookBook appointment$") }).Nth(1);
        private ILocator SelectDoctor => _page.Locator("xpath=//*[text()='Doctor/Nurse']/following-sibling::div//input[contains(@id,'mantine')]");
        private ILocator Dectordrop => _page.GetByText("Elizabeth Gatlin");
        private ILocator TypeApportment => _page.Locator("//*[text()='Appointment type']/following-sibling::div//input[contains(@id,'mantine')]");
        private ILocator SelectApportment => _page.GetByText("Initial Consultation (60 mins");
        private ILocator SelectVideo => _page.GetByText("Video");
        private ILocator SelectDate => _page.GetByLabel("2 October 2024", new() { Exact = true });
        public ILocator SelectTimeSlot => _page.GetByText("18:20");
        public HomePage(IPage page) : base(page)
        {
            _page = page;
        }

        public async Task VerifyTheSucessfulLogin()
        {
            //await _page.PauseAsync();
            await Assertions.Expect(loginAccount).ToBeVisibleAsync(new() { Timeout = 15000 });
            //await _page.PauseAsync();
        }
        public async Task ClickBookAppointment()
        {
            //await _page.PauseAsync();
            await BookAppointementLink.ClickAsync();

        }
        public async Task ChooseDoctor()
        {
            await SelectDoctor.ClickAsync();
            await Dectordrop.ClickAsync();
        }
        public async Task ChooseApportmentType()
        {
            await TypeApportment.ClickAsync();
            await SelectApportment.ClickAsync();
        }
        public async Task ClickVideo()
        {
            //await _page.PauseAsync();
            await SelectVideo.ClickAsync();
        }
        public async Task ClickSelectedDate()
        {
            await SelectDate.ClickAsync();
        }
        public async Task ClickSlot()
        {
            //await _page.PauseAsync();
            await SelectTimeSlot.ClickAsync();
        }
       

    }
}

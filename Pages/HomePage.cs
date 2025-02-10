using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
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

        private ILocator UploadPhoto => _page.GetByRole(AriaRole.Link, new() { Name = " Upload User Photo" });
        private ILocator UploadCloth => _page.GetByRole(AriaRole.Link, new() { Name = " Upload Cloth Photo" });
        public ILocator SelectClothCat => _page.GetByRole(AriaRole.Combobox);
        public ILocator AdvanceOption => _page.GetByRole(AriaRole.Link, new() { Name = "⚙️ Advanced Options ▼" });
        public ILocator QualityOption => _page.Locator("form").Filter(new() { HasText = "213141" }).GetByRole(AriaRole.Combobox);
        public ILocator TryButton => _page.GetByRole(AriaRole.Button, new() { Name = "Start Try-On" });
        public ILocator DoneMessage => _page.GetByText("Done!");
        public ILocator FinalImage => _page.Locator("img").Nth(4);
        public ILocator InValid => _page.GetByText("Incorrect email address or");
        public ILocator UserID => _page.GetByRole(AriaRole.Button, new() { Name = " Logout " });
        public ILocator LogoutCheck => _page.GetByRole(AriaRole.Heading, new() { Name = "Log In" });
        public void ThenFillTheAllDetails()
        {
            throw new PendingStepException();
        }

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
        public async Task UploadUserPhoto()
        {
            var fileChooser = await _page.RunAndWaitForFileChooserAsync(async () =>
            {
                await UploadPhoto.ClickAsync();
            });
            await fileChooser.SetFilesAsync("C:\\Users\\gauta\\OneDrive\\Pictures\\Ez_Project\\Women_Test\\Lower_Body\\Test 1\\User_photo_1.jpg");

            //await UploadPhoto.SetInputFilesAsync("C:\\Users\\gauta\\OneDrive\\Pictures\\133653369378782087.jpg");
        }
        public async Task ThenUploadClothPhoto()
        {
            var fileChooser = await _page.RunAndWaitForFileChooserAsync(async () =>
            {
                await UploadCloth.ClickAsync();
            });
            await fileChooser.SetFilesAsync("C:\\Users\\gauta\\OneDrive\\Pictures\\Ez_Project\\2007-wt20.avif");
            //await _page.PauseAsync();
        }
        public async Task SelectCloth()
        {
            await SelectClothCat.SelectOptionAsync("upper_body");
            //await _page.PauseAsync();
        }
        public async Task ClickandSelectAdavanceOption()
            { 
                await AdvanceOption.ClickAsync();
                await QualityOption.SelectOptionAsync("31");

                //await AdvanceOption.electOptionAsync("")
            }
    
        public async Task ClickStart()
        {
            await TryButton.ClickAsync();
          

        }
        /// <summary>
        /// This Method Verifys Done Message & also the image which is transformed.
        /// </summary>
        /// <returns></returns>
        public async Task TranformedChecking()
        {
            await Assertions.Expect(DoneMessage).ToBeVisibleAsync(new() { Timeout=100000});
            await Assertions.Expect(_page.Locator("img").Nth(4)).ToBeVisibleAsync();
        }

        public async Task InvalidUser()
        {
            await Assertions.Expect(InValid).ToBeVisibleAsync();
        }
        public async Task ShowUserID()
        {
            await Assertions.Expect(UserID).ToBeVisibleAsync();
        }

        public async Task ShowUserID(string Username)
        { 
          
            string LoginText = "Logout (" + Username + ")";
            await Assertions.Expect(UserID).ToHaveTextAsync(LoginText);
            
        }
        public async Task ClickLogout()
        {
            await UserID.ClickAsync();
           // await _page.PauseAsync();
            await Assertions.Expect(LogoutCheck).ToContainTextAsync("Log In"); 
        }
        
    }

}
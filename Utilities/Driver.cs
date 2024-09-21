
namespace PlayWrightImplementationForScriptAssist.Utilities
{
    public class Driver 
    {
        private readonly Task<IPage> _page;
        private IBrowser? _browser;

        public Driver()
        {
            _page=Task.Run(InitializePlaywright);
        }
        public IPage Page=>_page.Result;

        public void Dispose()
        {
            _browser?.CloseAsync();
        }
        private async Task<IPage> InitializePlaywright()
        {
            var playwright=await Playwright.CreateAsync();
            _browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                Channel = "chrome",
                Args= new[] { "--start--fullscreen"},
            });
            return await _browser.NewPageAsync();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWrightImplementationForScriptAssist.Pages
{
    public  class HomePage : BasePage
    {
        private IPage _page;
        private ILocator loginAccount => _page.GetByRole(AriaRole.Button, new() { Name = "Gautam Marathe" });


        public HomePage(IPage page):base(page)
        {
            _page = page;
        }

        public async Task VerifyTheSucessfulLogin()
        {
            await _page.PauseAsync();
            await Assertions.Expect(loginAccount).ToBeVisibleAsync(new() { Timeout=15000});
            await _page.PauseAsync();
        }

    }
}

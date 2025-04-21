using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWrightImplementationForScriptAssist.Pages
{
    public  class LoginPage:BasePage
    {
        private IPage _page;
        private ILocator UserNameField => _page.GetByPlaceholder("Email").First;
        private ILocator PasswordField => _page.GetByPlaceholder("Password").First;

        private ILocator SignInButton => _page.GetByRole(AriaRole.Button, new() { Name = "Sign in" });

        private ILocator UsernameEztry => _page.Locator("//input[@placeholder='email@address.com']");
        private ILocator PasswordEztry => _page.Locator("//input[@placeholder='password']");
        private ILocator LoginEztry => _page.Locator("//span[text()='Log In']");

       


        public LoginPage(IPage page):base(page)
        {
            _page = page;
        }

        public async Task LoginWithCredentials(string username, string password)
        {
            await UserNameField.FillAsync(username);
            await PasswordField.FillAsync(password);
            await SignInButton.ClickAsync();   

        }
        public async Task LoginforEztryWithCredrntials(string username, string password)
        {
            await UsernameEztry.FillAsync(username);
            await PasswordEztry.FillAsync(password);
            await LoginEztry.ClickAsync();
        }

    }
}

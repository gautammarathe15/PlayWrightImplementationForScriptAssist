using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWrightImplementationForScriptAssist.Pages
{
    [Binding]
    public class BasePage
    {
        private IPage _page;

        public BasePage(IPage page)
        {
            _page = page;
            //_page.SetDefaultTimeout(50000);
           // _page.SetDefaultNavigationTimeout(30000);
        }
    }
}

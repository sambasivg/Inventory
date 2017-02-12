using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Pages
{
    class BasePage
    {
        public static void Startwebpage()
        {
            string url= ConfigurationManager.AppSettings["UnleasedUrl"];
            string Browsertype= ConfigurationManager.AppSettings["BrowserType"];
            Operatons.BaseOperation.startUncleasedWebpage(url, Browsertype);
        }
    }
}

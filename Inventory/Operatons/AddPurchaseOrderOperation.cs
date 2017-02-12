using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Operatons
{
  public  class AddPurchaseOrderOperation : BaseOperation 
    {
        public  void CreatepurchageOrder(string userid,string password)
        {
            Pages.BasePage.Startwebpage();
            Pages.AddPurchasePage.LoginWebpage(userid, password);
        }
        
    }
}

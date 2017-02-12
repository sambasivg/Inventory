using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Model;
namespace Inventory.Operatons
{
  public  class AddProductOperation : BaseOperation 
    {
        public  void CreateProduct(Product prod )
        {
            Pages.BasePage.Startwebpage();
            Pages.AddPurchasePage.LoginWebpage(prod.Userid, prod.password);
            Pages.AddPurchasePage.CreateProduct(prod);
        }
        public void CreateSalesOrder(Product prod)
        {
            Pages.BasePage.Startwebpage();
            Pages.AddPurchasePage.LoginWebpage(prod.Userid, prod.password);
            Pages.AddPurchasePage.CreateSalesOrder(prod);
        }
    }
}

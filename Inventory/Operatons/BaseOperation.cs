using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Model;
using Inventory.Operatons;
namespace Inventory.Operatons
{
   public class BaseOperation
    {
        public static void startUncleasedWebpage(string Browsertype,string webpageurl)
        {
            Common.CommonFunctions.WebPageStart(Browsertype, webpageurl);
        }
        public  static  AddProductOperation CreateAddPurchaseOrderOperation(Product prd)
        {
          return  new Operatons.AddProductOperation();
        }
        public static AddProductOperation CreateAddProductOperation(Product prod)
        {
            return new Operatons.AddProductOperation();
        }
        //internal static object CreateAddPurchaseOrderOperation(Product proddetails)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

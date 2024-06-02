using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Inventory.Tests;
using System.Reflection.Emit;
using System.Collections;

namespace Inventory.Model
{
   public  class Product
    {
        public string Userid;
        public string password;
        public  string ProductCode;
        public  string ProductDescription;
        public  string Barcode;
        public  string UnitOfMeasure;
        public  string ProductGroup;
        public string DiscountId;
        public string CustomerCodeId;
        public string SalespersonId;
        public string SalesOrderGroupId;
        public string ProductAddLineId;
        public string QtyAddLineId;
        public string PriceAddLineid;
        public string DiscountRateAddLineId;
        public object Tabel { get; private set; }

        public  Product  readProductData(Hashtable Proddetails)
        {
              Product  Prod = new Product() ;
             
            try
            {
                Prod.Userid = Convert.ToString(Proddetails["UserID"]); 
                Prod.password = Convert.ToString(Proddetails["Password"]); 
                Prod.ProductCode = Convert.ToString(Proddetails["ProductCode"]);
                Prod.ProductDescription = Convert.ToString(Proddetails["ProductDescription"]); 
                Prod.Barcode = Convert.ToString(Proddetails["Barcode"]);
                Prod.UnitOfMeasure = Convert.ToString(Proddetails["UnitOfMeasure"]);
                Prod.ProductGroup = Convert.ToString(Proddetails["ProductGroup"]);
                }
            catch (Exception e)
            {

            }
            return Prod;
        }
        public Product readSalesOrderData(Hashtable Proddetails)
        {
            Product Prod = new Product();

            try
            {
                Prod.Userid = Convert.ToString(Proddetails["UserID"]);
                Prod.password = Convert.ToString(Proddetails["Password"]); 
                Prod.CustomerCodeId = Convert.ToString(Proddetails["CustomerCodeId"]); 
                Prod.DiscountId = Convert.ToString(Proddetails["DiscountId"]);
                Prod.SalespersonId = Convert.ToString(Proddetails["SalespersonId"]); 
                Prod.SalesOrderGroupId = Convert.ToString(Proddetails["SalesOrderGroupId"]);
                Prod.ProductAddLineId = Convert.ToString(Proddetails["ProductAddLineId"]); 

                Prod.QtyAddLineId = Convert.ToString(Proddetails["QtyAddLineId"]); 
                Prod.DiscountRateAddLineId = Convert.ToString(Proddetails["DiscountRateAddLineId"]);
                Prod.PriceAddLineid = Convert.ToString(Proddetails["PriceAddLineid"]); 
            }
            catch (Exception e)
            {

            }
            return Prod;
        }
    }
}

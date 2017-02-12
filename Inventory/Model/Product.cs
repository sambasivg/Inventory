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
                Prod.Userid = Convert.ToString(Proddetails["UserID"]); // Convert.ToString(dataRow.GetValue(0));
                Prod.password = Convert.ToString(Proddetails["Password"]); // Convert.ToString(dataRow[2]);
                Prod.ProductCode = Convert.ToString(Proddetails["ProductCode"]); // Convert.ToString(dataRow.GetValue(0));
                Prod.ProductDescription = Convert.ToString(Proddetails["ProductDescription"]); // Convert.ToString(dataRow[2]);
                Prod.Barcode = Convert.ToString(Proddetails["Barcode"]); // Convert.ToString(dataRow[3]);
                Prod.UnitOfMeasure = Convert.ToString(Proddetails["UnitOfMeasure"]); // Convert.ToString(dataRow[4]);
                Prod.ProductGroup = Convert.ToString(Proddetails["ProductGroup"]); // Convert.ToString(dataRow[5]);
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
                Prod.Userid = Convert.ToString(Proddetails["UserID"]); // Convert.ToString(dataRow.GetValue(0));
                Prod.password = Convert.ToString(Proddetails["Password"]); // Convert.ToString(dataRow[2]);
                Prod.CustomerCodeId = Convert.ToString(Proddetails["CustomerCodeId"]); // Convert.ToString(dataRow.GetValue(0));
                Prod.DiscountId = Convert.ToString(Proddetails["DiscountId"]); // Convert.ToString(dataRow[2]);
                Prod.SalespersonId = Convert.ToString(Proddetails["SalespersonId"]); // Convert.ToString(dataRow[3]);
                Prod.SalesOrderGroupId = Convert.ToString(Proddetails["SalesOrderGroupId"]); // Convert.ToString(dataRow[4]);
                Prod.ProductAddLineId = Convert.ToString(Proddetails["ProductAddLineId"]); // Convert.ToString(dataRow[5]);

                Prod.QtyAddLineId = Convert.ToString(Proddetails["QtyAddLineId"]); // Convert.ToString(dataRow[3]);
                Prod.DiscountRateAddLineId = Convert.ToString(Proddetails["DiscountRateAddLineId"]); // Convert.ToString(dataRow[4]);
                Prod.PriceAddLineid = Convert.ToString(Proddetails["PriceAddLineid"]); // Convert.ToString(dataRow[5]);
            }
            catch (Exception e)
            {

            }
            return Prod;
        }
    }
}

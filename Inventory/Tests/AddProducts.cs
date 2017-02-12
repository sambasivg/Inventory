using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using Inventory.Operatons;
using Inventory.Model;
using OpenQA.Selenium.Firefox;
using System.Data;
using System.Collections;

namespace Inventory.Tests
{
    [TestClass()]
    public class AddProducts
    {
        private AddProductOperation ObjaddPurchaseOrder;

      //  public object TestContext { get; internal set; }
        public TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }


        // internal AddPurchaseOrderOperation ObjaddPurchaseOrder { get; private set; }

        [TestMethod()]
        [DeploymentItem(@"c:\users\admin\documents\visual studio 2015\Projects\Inventory\Inventory\Data\AddProduct.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\AddProduct.xml", "Row", DataAccessMethod.Sequential)]
        public void inventory()
        {
            //factorypicker.choosentoolfactory.getregistrystartpage()
            
            Hashtable ht = new Hashtable();
            
             string userid = TestContext.DataRow["UserID"].ToString();
            ht.Add("UserID", userid);
            string password = TestContext.DataRow["Password"].ToString();
            ht.Add("Password", password);
            string ProductCode = TestContext.DataRow["ProductCode"].ToString();
            ht.Add("ProductCode", ProductCode);
            string ProductDescription = TestContext.DataRow["ProductDescription"].ToString();
            ht.Add("ProductDescription", ProductDescription);
            string Barcode = TestContext.DataRow["Barcode"].ToString();
            ht.Add("Barcode", Barcode);
            string UnitOfMeasure = TestContext.DataRow["UnitOfMeasure"].ToString();
            ht.Add("UnitOfMeasure", UnitOfMeasure);
            string ProductGroup = TestContext.DataRow["ProductGroup"].ToString();
            ht.Add("ProductGroup", ProductGroup);
            Console.WriteLine(userid);  
            Console.WriteLine(password);
            Product adpro = new Product();
            var proddetails= adpro.readProductData(ht);
            var ObjaddPurchaseOrder = Inventory.Operatons.BaseOperation.CreateAddPurchaseOrderOperation(proddetails);
            var Objprod = Inventory.Operatons.BaseOperation.CreateAddProductOperation(proddetails);
            Objprod.CreateProduct(proddetails);
        }

        [TestMethod()]
        [DeploymentItem(@"c:\users\admin\documents\visual studio 2015\Projects\Inventory\Inventory\Data\SalesOrder.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\SalesOrder.xml", "Row", DataAccessMethod.Sequential)]
        public void CreateSalesOrder()
        {
            //factorypicker.choosentoolfactory.getregistrystartpage()

            Hashtable ht = new Hashtable();

            string userid = TestContext.DataRow["UserID"].ToString();
            ht.Add("UserID", userid);
            string password = TestContext.DataRow["Password"].ToString();
            ht.Add("Password", password);
            string CustomerCodeId = TestContext.DataRow["CustomerCodeId"].ToString();
            ht.Add("CustomerCodeId", CustomerCodeId);
            string DiscountId = TestContext.DataRow["DiscountId"].ToString();
            ht.Add("DiscountId", DiscountId);
            string SalespersonId = TestContext.DataRow["SalespersonId"].ToString();
            ht.Add("SalespersonId", SalespersonId);
            string SalesOrderGroupId = TestContext.DataRow["SalesOrderGroupId"].ToString();
            ht.Add("SalesOrderGroupId", SalesOrderGroupId);
            string ProductAddLineId = TestContext.DataRow["ProductAddLineId"].ToString();
            ht.Add("ProductAddLineId", ProductAddLineId);

            string QtyAddLineId = TestContext.DataRow["QtyAddLineId"].ToString();
            ht.Add("QtyAddLineId", QtyAddLineId);
            string DiscountRateAddLineId = TestContext.DataRow["DiscountRateAddLineId"].ToString();
            ht.Add("DiscountRateAddLineId", DiscountRateAddLineId);
            string PriceAddLineid = TestContext.DataRow["PriceAddLineid"].ToString();
            ht.Add("PriceAddLineid", PriceAddLineid);
            Product adpro = new Product();
            var proddetails = adpro.readSalesOrderData(ht);
            //var ObjaddPurchaseOrder = Inventory.Operatons.BaseOperation.CreateAddPurchaseOrderOperation(proddetails);
            var Objprod = Inventory.Operatons.BaseOperation.CreateAddProductOperation(proddetails);
            Objprod.CreateSalesOrder(proddetails);
        }
    }
}

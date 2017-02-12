using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Model
{
    class PurchaseOrder
    {
        public static string usernameId;
        public static string passwordId ;
        public static string btnLogOnId;
        public static string ngbindingCls;
        public static string SupplierCodeId;
        public static string SupplierRefId;
        public static string SupplierInvoiceDateId;
        public static string TaxCodeId;
        public static string WarehouseListId;
        public static string ExchangeRateId;
        public static string OrderDateid;
        public static string RequiredDateId;
        public static string DeliveryNameId;
        public static string DeliveryStreetAddressId;
        public static string DeliverySuburbId;
        public static string DeliveryCityId;
        public static string DeliveryRegionId;
        public static string DeliveryCountryId;
        private TestContext testContextInstance;

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
        public void readPurchaseOrder()
        {
            PurchaseOrder.usernameId= TestContext.DataRow["UserID"].ToString(); 
            PurchaseOrder.passwordId= TestContext.DataRow["Password"].ToString(); 
            PurchaseOrder. btnLogOnId=TestContext.DataRow["UserID"].ToString();
            PurchaseOrder. ngbindingCls=TestContext.DataRow["UserID"].ToString();
        PurchaseOrder.SupplierCodeId=TestContext.DataRow["UserID"].ToString();
        PurchaseOrder. SupplierRefId=TestContext.DataRow["UserID"].ToString();
        PurchaseOrder. SupplierInvoiceDateId=TestContext.DataRow["UserID"].ToString();
        PurchaseOrder. TaxCodeId=TestContext.DataRow["UserID"].ToString();
        PurchaseOrder. WarehouseListId=TestContext.DataRow["UserID"].ToString();
        PurchaseOrder. ExchangeRateId=TestContext.DataRow["UserID"].ToString();
        PurchaseOrder. OrderDateid=TestContext.DataRow["UserID"].ToString();
        PurchaseOrder. RequiredDateId=TestContext.DataRow["UserID"].ToString();
        PurchaseOrder. DeliveryNameId=TestContext.DataRow["UserID"].ToString();
        PurchaseOrder. DeliveryStreetAddressId=TestContext.DataRow["UserID"].ToString();
        PurchaseOrder. DeliverySuburbId=TestContext.DataRow["UserID"].ToString();
        PurchaseOrder. DeliveryCityId=TestContext.DataRow["UserID"].ToString();
        PurchaseOrder. DeliveryRegionId=TestContext.DataRow["UserID"].ToString();
        PurchaseOrder. DeliveryCountryId=TestContext.DataRow["UserID"].ToString();
    }

    }
}

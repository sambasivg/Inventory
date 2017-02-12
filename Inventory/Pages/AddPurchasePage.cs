using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inventory.Model;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace Inventory.Pages
{
    class AddPurchasePage:BasePage
    {
        public static string usernameId = "username";
        public static string passwordId = "password";
        public static string btnLogOnId = "btnLogOn"; 
        public static string ngbindingCls = "ng-binding";
        public static string SupplierCodeId = "SupplierCode";
        public static string SupplierRefId = "SupplierRef";
        public static string SupplierInvoiceDateId = "SupplierInvoiceDate";
        public static string TaxCodeId = "TaxCode";
        public static string WarehouseListId = "WarehouseList";
        public static string ExchangeRateId = "ExchangeRate";
        public static string OrderDateid = "OrderDate";
        public static string RequiredDateId = "RequiredDate";
        public static string DeliveryNameId = "DeliveryName";
        public static string DeliveryStreetAddressId = "DeliveryStreetAddress";
        public static string DeliverySuburbId = "DeliverySuburb";
        public static string DeliveryCityId = "DeliveryCity";
        public static string DeliveryRegionId = "DeliveryRegion";
        public static string DeliveryCountryId = "DeliveryCountry";
        public static string ProductCodeId = "Product_ProductCode";
        public static string ProductDescriptionId = "Product_ProductDescription";
        public static string BarcodeId = "Product_Barcode";
        public static string UnitOfMeasureId = "Product_UnitOfMeasureId";
        public static string ProductGroupId = "Product_ProductGroupId";
        public static string btnSaveId = "btnSave";
        public static string messageBoxTitlexpath = "//span[@id='messageBoxContent']";
        public static string AddproductsXpath="//div[@id='shortcuts']/div[2]/div[3]/a/div[2]";
        public static string Menushotcutxpath = "//div[@id='shortcuts']/div/i";

        public static string CustomerCodeId = "SelectedCustomerCode";
        public static string DiscountId = "DiscountRateDisplay";
        public static string SalespersonId = "SalesPersonList";
        public static string SalesOrderGroupId = "SalesGroupList";
        public static string ProductAddLineId = "ProductAddLine";
        public static string QtyAddLineId = "QtyAddLine";
        public static string PriceAddLineid = "PriceAddLine";
        public static string DiscountRateAddLineId = "DiscountRateAddLine";
        public static string AddQuotexpath = "//a[contains(@href, '/v2/SalesQuote/Update')]";
        public static string CustomerSearchCodeId = "CustomerSearchCode";
        public static string CustomerCodeSearchXpath = "//a[contains(text(),'ABC008')]";
        public static string CustomerSearchButtonId = "CustomerSearchButton";
        public static string btnAddOrderLineId = "btnAddOrderLine";
        public static string btnAcceptQuoteId = "btnAcceptQuote";
        public static string btnCreateOrderId = "btnCreateOrder";
        public static string btnCompleteId = "btnComplete";
        public static string AvailableAddLineId = "AvailableAddLine";

        public static void LoginWebpage(string Userid, string password)
        {

            CommonFunctions.EnterValueInTextBox(CommonFunctions.LocatorName.Id, usernameId, Userid);
            CommonFunctions.EnterValueInTextBox(CommonFunctions.LocatorName.Id, passwordId, password);
            CommonFunctions.ClickButton(CommonFunctions.LocatorName.Id, btnLogOnId);

        }
        public static void CreateProduct(Product prd)
        {
            Thread.Sleep(10000);
            //AddproductsXpath
            CommonFunctions.ClickButton(CommonFunctions.LocatorName.Xpath, Menushotcutxpath);
            Thread.Sleep(5000);
            CommonFunctions.ClickButton(CommonFunctions.LocatorName.Xpath, AddproductsXpath);
            Thread.Sleep(5000);
            
            CommonFunctions.EnterValueInTextBox(CommonFunctions.LocatorName.Id, ProductCodeId, prd.ProductCode);
            Thread.Sleep(3000);
            CommonFunctions.EnterValueInTextBox(CommonFunctions.LocatorName.Id, ProductDescriptionId, prd.ProductDescription);
            Thread.Sleep(3000);
            CommonFunctions.selectAnOptionFromlistbox(CommonFunctions.LocatorName.Id, UnitOfMeasureId, prd.UnitOfMeasure);
            Thread.Sleep(3000);
            CommonFunctions.selectAnOptionFromlistbox(CommonFunctions.LocatorName.Id, ProductGroupId, prd.ProductGroup);
            Thread.Sleep(3000);
            CommonFunctions.EnterValueInTextBox(CommonFunctions.LocatorName.Id, BarcodeId, prd.Barcode);
            Thread.Sleep(3000);
            CommonFunctions.ClickButton(CommonFunctions.LocatorName.Id, btnSaveId);
            string expectedmsg = CommonFunctions.GetWebElementText(CommonFunctions.LocatorName.Xpath, messageBoxTitlexpath);
            Assert.IsTrue(string.Equals(expectedmsg, "You have updated the product successfully."),"Expected and ActulaResults are not matched");
          }
        public static void CreateSalesOrder(Product prd)
        {
            Thread.Sleep(10000);
            //AddproductsXpath
            CommonFunctions.ClickButton(CommonFunctions.LocatorName.Xpath, Menushotcutxpath);
            Thread.Sleep(5000);
            CommonFunctions.ClickButton(CommonFunctions.LocatorName.Xpath, AddQuotexpath);
           Thread.Sleep(2000);
            CommonFunctions.ClickButton(CommonFunctions.LocatorName.Id, CustomerSearchButtonId);
            CommonFunctions.EnterValueInTextBox(CommonFunctions.LocatorName.Id, CustomerSearchCodeId, prd.CustomerCodeId);
            CommonFunctions.SendKey(CommonFunctions.LocatorName.Id, CustomerSearchCodeId, "tab");
            Thread.Sleep(2000);
            CommonFunctions.SendKey(CommonFunctions.LocatorName.Id, CustomerSearchCodeId, ":Enter");
            CommonFunctions.ClickButton(CommonFunctions.LocatorName.Xpath, CustomerCodeSearchXpath);
            Thread.Sleep(5000);
            CommonFunctions.EnterValueInTextBox(CommonFunctions.LocatorName.Id, DiscountId, prd.DiscountId);
            Thread.Sleep(3000);
            CommonFunctions.selectAnOptionFromlistbox(CommonFunctions.LocatorName.Id, SalespersonId, prd.SalespersonId);
            Thread.Sleep(3000);
            CommonFunctions.selectAnOptionFromlistbox(CommonFunctions.LocatorName.Id, SalesOrderGroupId, prd.SalesOrderGroupId);
            Thread.Sleep(3000);
            CommonFunctions.EnterValueInTextBox(CommonFunctions.LocatorName.Id, ProductAddLineId, prd.ProductAddLineId);
            Thread.Sleep(3000);
            CommonFunctions.EnterValueInTextBox(CommonFunctions.LocatorName.Id, QtyAddLineId, prd.QtyAddLineId);
            Thread.Sleep(3000);
            CommonFunctions.EnterValueInTextBox(CommonFunctions.LocatorName.Id, PriceAddLineid, prd.PriceAddLineid);
            Thread.Sleep(3000);
            CommonFunctions.EnterValueInTextBox(CommonFunctions.LocatorName.Id, DiscountRateAddLineId, prd.DiscountRateAddLineId);
            Thread.Sleep(3000);
            CommonFunctions.ClickButton(CommonFunctions.LocatorName.Id, btnAddOrderLineId);
            Thread.Sleep(3000);
            int availablestock = Convert.ToInt32(CommonFunctions.GetWebElementValue(CommonFunctions.LocatorName.Xpath, AvailableAddLineId));
            int salesqty = Convert.ToInt32(CommonFunctions.GetWebElementValue(CommonFunctions.LocatorName.Xpath, QtyAddLineId));
            if (availablestock >0 && availablestock >= salesqty )
            { 
            CommonFunctions.ClickButton(CommonFunctions.LocatorName.Id, btnAcceptQuoteId);
            Thread.Sleep(3000);
            CommonFunctions.ClickButton(CommonFunctions.LocatorName.Id, btnCreateOrderId);
            Thread.Sleep(3000);
            CommonFunctions.ClickButton(CommonFunctions.LocatorName.Id, btnCompleteId);
            }
            Thread.Sleep(4000);
            string expectedmsg = CommonFunctions.GetWebElementValue(CommonFunctions.LocatorName.Xpath, messageBoxTitlexpath);
            Assert.IsTrue(string.Equals(expectedmsg, "You have successfully Completed Sales Order."), "Expected and ActulaResults are not matched");
        }


    }
}

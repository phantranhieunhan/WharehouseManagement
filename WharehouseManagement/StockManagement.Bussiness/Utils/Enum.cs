#region Assembly Retail.Business, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// D:\WebAPI\DLLS\Retail.Business.dll
#endregion

namespace StockManagement.Business.Utils.Enum
{
    public static class Constant
    {
        public const string DATEFORMAT_ddMMyyyy = "dd/MM/yyyy";
        public const string DATEFORMAT_ddMMyyyy_HHmm = "dd/MM/yyyy HH:mm ";
        public const string HOUR_ID = "1619e7e0-2a47-4624-815c-f2167ca306d4";

        public struct SignalRMessage
        {
            public const string State_ReloadNotify = "reloadnotify";
            public const string State_RefreshCost = "refreshcost";
            public const string State_RefreshInvoice = "refrestinvoice";
            public const string State_ClosePrice = "closeprice";
            public const string State_CancelClosePrice = "cancelcloseprice";
            public const string State_CloseFiscalTemp = "closefiscaltemp";
            public const string State_CancelCloseFiscalTemp = "cancelclosefiscaltemp";
            public const string State_CloseFiscal = "closefiscal";
            public const string State_RefreshCost_Finish = "refreshcost_finish";
            public const string State_RefreshInvoice_Finish = "refrestinvoice_finish";
            public const string State_ClosePrice_Finish = "closeprice_finish";
            public const string State_CancelClosePrice_Finish = "cancelcloseprice_finish";
            public const string State_CloseFiscalTemp_Finish = "closefiscaltemp_finish";
            public const string State_CancelCloseFiscalTemp_Finish = "cancelclosefiscaltemp_finish";
            public const string State_CloseFiscal_Finish = "closefiscal_finish";
            public const string State_FiscalError = "fiscalerror";
        }
        public struct SignalRTopic
        {
            public const string Notify = "events.notify";
            public const string Fiscal = "events.fiscal";
        }
        public struct ReportHeader
        {
            public const string SITE = "SiteName";
            public const string STORE = "StoreName";
            public const string REPORT_NAME = "ReportName";
            public const string REPORT_DATE = "ReportDate";
        }
        public struct SystemValue
        {
            public const int SITE_ID = 0;
            public const string STORE_ID = "STORE_LIB";
            public const string CUSTOMER_DEFAULT_NAME = "Khách lẻ";
        }
        public struct SyncTableName
        {
            public const string Currency = "Currency";
            public const string Table = "vw_Table_Sync";
            public const string Layout = "Layout";
            public const string LayoutTable = "vw_LayoutTable_Sync";
            public const string RestaurantComment = "RestaurantComment";
            public const string Food = "vw_Food_Sync";
            public const string FoodComment = "vw_FoodComment_Sync";
            public const string FoodIngredient = "vw_FoodIngredient_Sync";
            public const string FoodCombo = "vw_FoodCombo_Sync";
            public const string RestaurantMenu = "Menu";
            public const string RestaurantMenuDetail = "vw_MenuDetail_Sync";
            public const string RestaurantMenuSource = "vw_MenuSourceType_Sync";
            public const string RestaurantMenuSchedule = "MenuScheduler";
            public const string RestaurantMenuFoodIngredient = "vw_MenuFoodIngredient_Sync";
            public const string FoodCategory = "FoodCategory";
            public const string FoodCategoryDetail = "vw_FoodCategoryDetail_Sync";
            public const string PriceList = "PriceList";
            public const string PriceListDetail = "vw_PriceListDetail_Sync";
            public const string Kitchen = "Kitchen";
            public const string KitchenFood = "vw_KitchenFood_Sync";
            public const string AreaFoodPrice = "AreaFoodPrice";
            public const string Service = "vw_Service_Sync";
            public const string Meal = "Meal";
            public const string ProductPriceByTime = "ProductPriceByTime";
            public const string ItemRestaurant = "vw_Item_Restaurant_Sync";
            public const string RestaurantServiceGift = "RestaurantServiceGift";
            public const string RestaurantServiceGiftDetail = "vw_RestaurantServiceGift_Sync";
            public const string UserPermission = "UserPermission";
            public const string TableType = "TableType";
            public const string Area = "Area";
            public const string PaymentTerm = "PaymentTerm";
            public const string ShowRoom = "ShowRoom";
            public const string Customer = "Customer";
            public const string Fiscal = "Fiscal";
            public const string ItemType = "ItemType";
            public const string Ledger = "Ledger";
            public const string LedgerExp = "LedgerExp";
            public const string LedgerPhysical = "LedgerPhysical";
            public const string MembershipType = "MembershipType";
            public const string Option = "Option";
            public const string Product = "vw_Product_Sync";
            public const string ProductCategory = "ProductCategory";
            public const string Promotion = "Promotion";
            public const string PromotionBenefit = "vw_Sync_PromotionBenefit";
            public const string PromotionDetail = "vw_Sync_PromotionDetail";
            public const string SpacePriceList = "SpacePriceList";
            public const string Shift = "Shift";
            public const string StockIn = "StockIn";
            public const string StockInDetail = "StockInDetail";
            public const string StockOut = "StockOut";
            public const string StockOutDetail = "StockOutDetail";
            public const string Store = "Store";
            public const string TaxVAT = "TaxVAT";
            public const string Unit = "Unit";
            public const string User = "vw_sync_User";
            public const string UserProfile = "vw_sync_UserProfile";
            public const string ExchangeRate = "ExchangeRate";
            public const string RefNo = "RefNo";
            public const string CustomerType = "CustomerType";
            public const string PosVersion = "PosVersion";
            public const string Stock = "Stock";
            public const string SpacePriceListDetail = "vw_SpacePriceListDetail_Sync";
        }
        public struct Message
        {
            public const string MSGCODE_0000000001 = "0000000001";
            public const string MSGCODE_SALE_00001 = "SALE-00001";
            public const string MSGCODE_POST_00012 = "POST-00012";
            public const string MSGCODE_POST_00011 = "POST-00011";
            public const string MSGCODE_POST_00010 = "POST-00010";
            public const string MSGCODE_POST_00009 = "POST-00009";
            public const string MSGCODE_POST_00008 = "POST-00008";
            public const string MSGCODE_POST_00007 = "POST-00007";
            public const string MSGCODE_POST_00006 = "POST-00006";
            public const string MSGCODE_POST_00005 = "POST-00005";
            public const string MSGCODE_POST_00004 = "POST-00004";
            public const string MSGCODE_POST_00003 = "POST-00003";
            public const string MSGCODE_POST_00002 = "POST-00002";
            public const string MSGCODE_POST_00001 = "POST-00001";
            public const string MSGCODE_PACKAGE_001 = "PACKAGE-001";
            public const string MSGCODE_INV_UNPOST_50011 = "INV-UNPOST-50011";
            public const string MSGCODE_INV_UNPOST_50009 = "INV-UNPOST-50009";
            public const string MSGCODE_INV_UNPOST_50007 = "INV-UNPOST-50007";
            public const string MSGCODE_INV_UNPOST_50006 = "INV-UNPOST-50006";
            public const string MSGCODE_INV_UNPOST_50005 = "INV-UNPOST-50005";
            public const string MSGCODE_SALE_00002 = "SALE-00002";
            public const string MSGCODE_USER_001 = "USER-001";
            public const string MSGCODE_USER_002 = "USER-002";
            public const string MSGCODE_USER_003 = "USER-003";
            public const string MSGCODE_CLOSING_017 = "CLOSING-017";
            public const string MSGCODE_CLOSING_016 = "CLOSING-016";
            public const string MSGCODE_CLOSING_015 = "CLOSING-015";
            public const string MSGCODE_CLOSING_014 = "CLOSING-014";
            public const string MSGCODE_CLOSING_013 = "CLOSING-013";
            public const string MSGCODE_CLOSING_012 = "CLOSING-012";
            public const string MSGCODE_CLOSING_011 = "CLOSING-011";
            public const string MSGCODE_CLOSING_010 = "CLOSING-010";
            public const string MSGCODE_CLOSING_009 = "CLOSING-009";
            public const string MSGCODE_INV_UNPOST_50004 = "INV-UNPOST-50004";
            public const string MSGCODE_CLOSING_008 = "CLOSING-008";
            public const string MSGCODE_CLOSING_006 = "CLOSING-006";
            public const string MSGCODE_CLOSING_005 = "CLOSING-005";
            public const string MSGCODE_CLOSING_004 = "CLOSING-004";
            public const string MSGCODE_CLOSING_003 = "CLOSING-003";
            public const string MSGCODE_CLOSING_002 = "CLOSING-002";
            public const string MSGCODE_CLOSING_001 = "CLOSING-001";
            public const string MSGCODE_VENDOR_001 = "VENDOR-001";
            public const string MSGCODE_USERPROFILE_001 = "USERPROFILE-001";
            public const string MSGCODE_USER_004 = "USER-004";
            public const string MSGCODE_CLOSING_007 = "CLOSING-007";
            public const string MSGCODE_CLOSING_018 = "CLOSING-018";
            public const string MSGCODE_INV_UNPOST_50003 = "INV-UNPOST-50003";
            public const string MSGCODE_INV_POST_50014 = "INV-POST-50014";
            public const string MSGCODE_INV_STK_00010 = "INV-STK-00010";
            public const string MSGCODE_INV_STK_00009 = "INV-STK-00009";
            public const string MSGCODE_INV_STK_00008 = "INV-STK-00008";
            public const string MSGCODE_INV_STK_00007 = "INV-STK-00007";
            public const string MSGCODE_INV_STK_00006 = "INV-STK-00006";
            public const string MSGCODE_INV_STK_00005 = "INV-STK-00005";
            public const string MSGCODE_INV_STK_00004 = "INV-STK-00004";
            public const string MSGCODE_INV_STK_00003 = "INV-STK-00003";
            public const string MSGCODE_INV_STK_00002 = "INV-STK-00002";
            public const string MSGCODE_INV_STK_00001 = "INV-STK-00001";
            public const string MSGCODE_DEL_000003 = "DEL-000003";
            public const string MSGCODE_DEL_000002 = "DEL-000002";
            public const string MSGCODE_DEL_000001 = "DEL-000001";
            public const string MSGCODE_0000000012 = "0000000011";
            public const string MSGCODE_0000000011 = "0000000011";
            public const string MSGCODE_0000000005 = "0000000005";
            public const string MSGCODE_0000000004 = "0000000004";
            public const string MSGCODE_0000000003 = "0000000003";
            public const string MSGCODE_0000000002 = "0000000002";
            public const string MSGCODE_INV_STK_00011 = "INV-STK-00011";
            public const string MSGCODE_INV_STK_00012 = "INV-STK-00012";
            public const string MSGCODE_INV_STK_00013 = "INV-STK-00013";
            public const string MSGCODE_INV_STK_00014 = "INV-STK-00014";
            public const string MSGCODE_INV_POST_50013 = "INV-POST-50013";
            public const string MSGCODE_INV_POST_50012 = "INV-POST-50012";
            public const string MSGCODE_INV_POST_50011 = "INV-POST-50011";
            public const string MSGCODE_INV_POST_50010 = "INV-POST-50010";
            public const string MSGCODE_INV_POST_50009 = "INV-POST-50009";
            public const string MSGCODE_INV_POST_50008 = "INV-POST-50008";
            public const string MSGCODE_INV_POST_50007 = "INV-POST-50007";
            public const string MSGCODE_INV_POST_50006 = "INV-POST-50006";
            public const string MSGCODE_INV_POST_50005 = "INV-POST-50005";
            public const string MSGCODE_INV_UNPOST_50002 = "INV-UNPOST-50002";
            public const string MSGCODE_INV_POST_50004 = "INV-POST-50004";
            public const string MSGCODE_INV_POST_50002 = "INV-POST-50002";
            public const string MSGCODE_INV_POST_50001 = "INV-POST-50001";
            public const string MSGCODE_INV_STK_00021 = "INV-STK-00021";
            public const string MSGCODE_INV_STK_00020 = "INV-STK-00020";
            public const string MSGCODE_INV_STK_00019 = "INV-STK-00019";
            public const string MSGCODE_INV_STK_00018 = "INV-STK-00018";
            public const string MSGCODE_INV_STK_00017 = "INV-STK-00017";
            public const string MSGCODE_INV_STK_00016 = "INV-STK-00016";
            public const string MSGCODE_INV_STK_00015 = "INV-STK-00015";
            public const string MSGCODE_INV_POST_50003 = "INV-POST-50003";
            public const string MSGCODE_CLOSING_019 = "CLOSING-019";
        }
        public struct OrderStatus
        {
            public const short New = 1;
            public const short CreatedSaleInvoice = 2;
            public const short Cancel = 3;
        }
        public struct FiscalStatus
        {
            public const short Running = 0;
            public const short Pending = 1;
            public const short Closed = 2;
        }
        public struct SalePurchaseStatus
        {
            public const int UnPaid = 1;
            public const int PaidPart = 2;
            public const int Paid = 3;
        }
        public struct OptionID
        {
            public const string FORMAT_DATE = "SYS_FORMATDATE";
            public const string FORMAT_NUMBER = "SYS_FORMATNUMBER";
        }
        public struct RefNo
        {
            public const string REFNO_SALEORDER = "SALE_ORDER";
            public const string REFNO_INV_STOCKIN_PURCHASE = "INV_STOCKIN_PURCHASE";
            public const string REFNO_INV_STOCKIN_SALERETURN = "INV_STOCKIN_SALERETURN";
            public const string REFNO_INV_STOCKIN_TRANSFER = "INV_STOCKIN_TRANSFER";
            public const string REFNO_INV_STOCKIN_SAMPLE = "INV_STOCKIN_SAMPLE";
            public const string REFNO_INV_STOCKIN_OPENINGCOST = "INV_STOCKIN_OPENINGCOST";
            public const string REFNO_INV_STOCKIN_OPENINGBALANCE = "INV_STOCKIN_OPENINGBALANCE";
            public const string REFNO_INV_STOCKOUT = "INV_STOCKOUT";
            public const string REFNO_INV_STOCKOUT_SALEINVOICE = "INV_STOCKOUT_SALEINVOICE";
            public const string REFNO_INV_STOCKOUT_PURCHASERETURN = "INV_STOCKOUT_PURCHASERETURN";
            public const string REFNO_INV_STOCKIN = "INV_STOCKIN";
            public const string REFNO_INV_STOCKOUT_TRANSFER = "INV_STOCKOUT_TRANSFER";
            public const string REFNO_INV_STOCKOUT_PROMOTIONSALEINVOICE = "INV_STOCKOUT_PROMOTIONSALEINVOICE";
            public const string REFNO_INV_STOCKOUT_DONATE = "INV_STOCKOUT_DONATE";
            public const string REFNO_INV_STOCKOUT_SAMPLE = "INV_STOCKOUT_SAMPLE";
            public const string REFNO_INV_STOCKOUT_USE = "INV_STOCKOUT_USE";
            public const string REFNO_INV_COMBINE = "INV_COMBINE";
            public const string REFNO_INV_SPLIT = "INV_SPLIT";
            public const string REFNO_INV_STOCKTAKE = "INV_STOCKTAKE";
            public const string REFNO_INV_PRODUCTEXCHANGE = "INV_PRODUCTEXCHANGE";
            public const string REFNO_INV_STOCKTRANSFERREQUEST = "INV_STOCKTRANSFERREQUEST";
            public const string REFNO_INV_STOCKOUT_CANCEL = "INV_STOCKOUT_CANCEL";
            public const string REFNO_ORDER_ORDER = "ORDER_ORDER";
            public const string REFNO_OPENINGBALANCE_VENDOR = "OPENINGBALANCE_VENDOR";
            public const string REFNO_VENDORPAYMENT_REFUND = "VENDOR_PAYMENT_REFUND";
            public const string REFNO_SALEINVOICE = "SALE_INVOICE";
            public const string REFNO_SALERETURN = "SALE_RETURN";
            public const string REFNO_PURCHASEORDER = "PURCHASE_ORDER";
            public const string REFNO_PURCHASENVOICE = "PURCHASE_INVOICE";
            public const string REFNO_PURCHASERETURN = "PURCHASE_RETURN";
            public const string REFNO_CASHIN = "CASH_IN";
            public const string REFNO_CASHOUT = "CASH_OUT";
            public const string REFNO_SUPPORT = "CASH_SUPPORT";
            public const string REFNO_COST = "CASH_COST";
            public const string REFNO_OPENINGBALANCE_CUSTOMER = "OPENINGBALANCE_CUSTOMER";
            public const string REFNO_CASHOUT_DISTRIBUTE = "CASHOUT_DISTRIBUTE";
            public const string REFNO_CASHOUT_FIXEDASSET = "CASHOUT_FIXEDASSET";
            public const string REFNO_CASHOUT_INSTRUMENT = "CASHOUT_INSTRUMENT";
            public const string REFNO_CASHOUT_OTHER = "CASHOUT_OTHER";
            public const string REFNO_CASHTRANSFER_OUT = "CASH_TRANSFER_OUT";
            public const string REFNO_CASHTRANSFER_IN = "CASH_TRANSFER_IN";
            public const string REFNO_CASHOUT_PURCHASECHARGE = "REFNO_CASHOUT_PURCHASECHARGE";
            public const string REFNO_CUSTOMERPAYMENT = "CUSTOMER_PAYMENT";
            public const string REFNO_CUSTOMERPAYMENT_REFUND = "CUSTOMER_PAYMENT_REFUND";
            public const string REFNO_VENDORPAYMENT = "VENDOR_PAYMENT";
            public const string REFNO_CASHOUT_EXPENSE = "CASHOUT_EXPENSE";
            public const string EPURCHASE_INVOICE = "EPURCHASE_INVOICE";
        }
        public struct Inventory
        {
            public const int INV_STATUS_CREATING = 0;
            public const int INV_STOCKOUTTYPE_USENONCOST = 20;
            public const int INV_STOCKOUTTYPE_SAMPLE = 19;
            public const int INV_STOCKOUTTYPE_USE = 18;
            public const int INV_STOCKOUTTYPE_DONATE = 17;
            public const int INV_STOCKOUTTYPE_PROMOTIONSALEINVOICE = 16;
            public const int INV_STOCKOUTTYPE_CANCEL = 15;
            public const int INV_STOCKOUTTYPE_TRANSFER = 14;
            public const int INV_STOCKOUTTYPE_PURCHASERETURN = 13;
            public const int INV_STOCKOUTTYPE_SALEINVOICE = 12;
            public const int INV_STOCKOUTTYPE_PURCHASERETURNCOST = 3;
            public const int INV_STOCKOUTTYPE_SALEINVOICECOST = 2;
            public const int INV_STOCKINTYPE_SAMPLE = 19;
            public const int INV_STOCKINTYPE_TRANSFER = 14;
            public const int INV_STOCKINTYPE_SALERETURN = 13;
            public const int INV_STOCKINTYPE_PURCHASE = 12;
            public const int INV_STOCKINTYPE_OPENINGBALANCE = 11;
            public const int INV_STOCKINTYPE_SALERETURNCOST = 3;
            public const int INV_STOCKINTYPE_PURCHASECOST = 2;
            public const int INV_STATUS_FINISH = 10;
            public const int INV_STATUS_CANCELREQUESTED = 8;
            public const int INV_STATUS_REQUESTED = 7;
            public const int INV_STATUS_RECEIVEPART = 6;
            public const int INV_STATUS_SHIPPING = 5;
            public const int INV_STATUS_DELETED = 4;
            public const int INV_STATUS_EDITED = 3;
            public const int INV_STATUS_CREATED = 2;
            public const int INV_STATUS_CANCEL = 1;
            public const int PRODUCTPRICING_OPENINGCOST = 1;
            public const int PRODUCTPRICING_SERVICECOST = 2;
        }
        public struct MobileDeviceType
        {
            public const string StockApp = "StockApp";
        }
        public struct ProductAccountDefault
        {
            public const string StockAccount = "1561";
            public const string RevenueAccount = "5111";
            public const string StandardCostAccount = "632";
            public const string PurchaseAccount = "331";
            public const string ReturnAccount = "5212";
            public const string DiscountAccount = "5211";
            public const string TaxAccount = "33311";
        }
        
    }
}
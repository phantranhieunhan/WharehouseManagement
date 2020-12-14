/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     06/12/2020 6:17:10 CH                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Customer') and o.name = 'FK_CUSTOMER_RELATIONS_GROUPCUS')
alter table Customer
   drop constraint FK_CUSTOMER_RELATIONS_GROUPCUS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Product') and o.name = 'FK_PRODUCT_RELATIONS_PRODUCTT')
alter table Product
   drop constraint FK_PRODUCT_RELATIONS_PRODUCTT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Product') and o.name = 'FK_PRODUCT_RELATIONS_PRODUCTC')
alter table Product
   drop constraint FK_PRODUCT_RELATIONS_PRODUCTC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Product') and o.name = 'FK_PRODUCT_RELATIONS_PRODUCTU')
alter table Product
   drop constraint FK_PRODUCT_RELATIONS_PRODUCTU
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ProductOnStock') and o.name = 'FK_PRODUCTO_RELATIONS_STOCK')
alter table ProductOnStock
   drop constraint FK_PRODUCTO_RELATIONS_STOCK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ProductOnStock') and o.name = 'FK_PRODUCTO_RELATIONS_PRODUCT')
alter table ProductOnStock
   drop constraint FK_PRODUCTO_RELATIONS_PRODUCT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ProductType') and o.name = 'FK_PRODUCTT_NHOM_PRODUCTT')
alter table ProductType
   drop constraint FK_PRODUCTT_NHOM_PRODUCTT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PurchaseOrder') and o.name = 'FK_PURCHASE_RELATIONS_USER')
alter table PurchaseOrder
   drop constraint FK_PURCHASE_RELATIONS_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PurchaseOrderDetail') and o.name = 'FK_PURCHASE_RELATIONS_PRODUCT')
alter table PurchaseOrderDetail
   drop constraint FK_PURCHASE_RELATIONS_PRODUCT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PurchaseOrderDetail') and o.name = 'FK_PURCHASE_RELATIONS_PURCHASE')
alter table PurchaseOrderDetail
   drop constraint FK_PURCHASE_RELATIONS_PURCHASE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SaleOrder') and o.name = 'FK_SALEORDE_CREATEDBY_USER')
alter table SaleOrder
   drop constraint FK_SALEORDE_CREATEDBY_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SaleOrder') and o.name = 'FK_SALEORDE_RELATIONS_CUSTOMER')
alter table SaleOrder
   drop constraint FK_SALEORDE_RELATIONS_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SaleOrderDetail') and o.name = 'FK_SALEORDE_RELATIONS_SALEORDE')
alter table SaleOrderDetail
   drop constraint FK_SALEORDE_RELATIONS_SALEORDE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SaleOrderDetail') and o.name = 'FK_SALEORDE_RELATIONS_PRODUCT')
alter table SaleOrderDetail
   drop constraint FK_SALEORDE_RELATIONS_PRODUCT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockIn') and o.name = 'FK_STOCKIN_RELATIONS_USER')
alter table StockIn
   drop constraint FK_STOCKIN_RELATIONS_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockIn') and o.name = 'FK_STOCKIN_RELATIONS_STOCK')
alter table StockIn
   drop constraint FK_STOCKIN_RELATIONS_STOCK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockIn') and o.name = 'FK_STOCKIN_RELATIONS_STOCKINT')
alter table StockIn
   drop constraint FK_STOCKIN_RELATIONS_STOCKINT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockInDetail') and o.name = 'FK_STOCKIND_RELATIONS_STOCKIN')
alter table StockInDetail
   drop constraint FK_STOCKIND_RELATIONS_STOCKIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockInPurchaseAndDonate') and o.name = 'FK_STOCKINP_INHERITAN_STOCKIN')
alter table StockInPurchaseAndDonate
   drop constraint FK_STOCKINP_INHERITAN_STOCKIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockInPurchaseAndDonate') and o.name = 'FK_STOCKINP_RELATIONS_PURCHASE')
alter table StockInPurchaseAndDonate
   drop constraint FK_STOCKINP_RELATIONS_PURCHASE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockInReturn') and o.name = 'FK_STOCKINR_INHERITAN_STOCKIN')
alter table StockInReturn
   drop constraint FK_STOCKINR_INHERITAN_STOCKIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockInTransfer') and o.name = 'FK_STOCKINT_INHERITAN_STOCKIN')
alter table StockInTransfer
   drop constraint FK_STOCKINT_INHERITAN_STOCKIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockInTransfer') and o.name = 'FK_STOCKINT_RELATIONS_STOCK')
alter table StockInTransfer
   drop constraint FK_STOCKINT_RELATIONS_STOCK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockInType') and o.name = 'FK_STOCKINT_RELATIONS_STOCKINT')
alter table StockInType
   drop constraint FK_STOCKINT_RELATIONS_STOCKINT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockOut') and o.name = 'FK_STOCKOUT_RELATIONS_USER')
alter table StockOut
   drop constraint FK_STOCKOUT_RELATIONS_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockOut') and o.name = 'FK_STOCKOUT_RELATIONS_STOCKOUTTYPE')
alter table StockOut
   drop constraint FK_STOCKOUT_RELATIONS_STOCKOUTTYPE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockOut') and o.name = 'FK_STOCKOUT_WAREHOUSE_STOCK')
alter table StockOut
   drop constraint FK_STOCKOUT_WAREHOUSE_STOCK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockOutDestroy') and o.name = 'FK_STOCKOUTDESTROY_INHERITAN_STOCKOUT')
alter table StockOutDestroy
   drop constraint FK_STOCKOUTDESTROY_INHERITAN_STOCKOUT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockOutDetail') and o.name = 'FK_STOCKOUTDETAIL_RELATIONS_STOCKOUT')
alter table StockOutDetail
   drop constraint FK_STOCKOUTDETAIL_RELATIONS_STOCKOUT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockOutReturn') and o.name = 'FK_STOCKOUTRETURN_INHERITAN_STOCKOUT')
alter table StockOutReturn
   drop constraint FK_STOCKOUTRETURN_INHERITAN_STOCKOUT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockOutReturn') and o.name = 'FK_STOCKOUT_RELATIONS_SUPPLIER')
alter table StockOutReturn
   drop constraint FK_STOCKOUT_RELATIONS_SUPPLIER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockOutSaleAndDonate') and o.name = 'FK_STOCKOUTSALEANDDOANTE_INHERITAN_STOCKOUT')
alter table StockOutSaleAndDonate
   drop constraint FK_STOCKOUTSALEANDDOANTE_INHERITAN_STOCKOUT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockOutSaleAndDonate') and o.name = 'FK_STOCKOUT_RELATIONS_SALEORDE')
alter table StockOutSaleAndDonate
   drop constraint FK_STOCKOUT_RELATIONS_SALEORDE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockOutTransfer') and o.name = 'FK_STOCKOUTTRANSFER_INHERITAN_STOCKOUT')
alter table StockOutTransfer
   drop constraint FK_STOCKOUTTRANSFER_INHERITAN_STOCKOUT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockOutTransfer') and o.name = 'FK_STOCKOUT_RELATIONS_STOCK')
alter table StockOutTransfer
   drop constraint FK_STOCKOUT_RELATIONS_STOCK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Supplier') and o.name = 'FK_SUPPLIER_RELATIONS_PURCHASE')
alter table Supplier
   drop constraint FK_SUPPLIER_RELATIONS_PURCHASE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SupplierProduct') and o.name = 'FK_SUPPLIER_RELATIONS_PRODUCT')
alter table SupplierProduct
   drop constraint FK_SUPPLIER_RELATIONS_PRODUCT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SupplierProduct') and o.name = 'FK_SUPPLIER_RELATIONS_SUPPLIER')
alter table SupplierProduct
   drop constraint FK_SUPPLIER_RELATIONS_SUPPLIER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"User"') and o.name = 'FK_USER_RELATIONS_STOCK')
alter table "User"
   drop constraint FK_USER_RELATIONS_STOCK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"User"') and o.name = 'FK_USER_RELATIONS_USERPROF')
alter table "User"
   drop constraint FK_USER_RELATIONS_USERPROF
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"User"') and o.name = 'FK_USER_RELATIONS_USERTYPE')
alter table "User"
   drop constraint FK_USER_RELATIONS_USERTYPE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('UserPermission') and o.name = 'FK_USERPERM_RELATIONS_PERMISSI')
alter table UserPermission
   drop constraint FK_USERPERM_RELATIONS_PERMISSI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('UserPermission') and o.name = 'FK_USERPERM_RELATIONS_USER')
alter table UserPermission
   drop constraint FK_USERPERM_RELATIONS_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('UserProfile') and o.name = 'FK_USERPROF_RELATIONS_USER')
alter table UserProfile
   drop constraint FK_USERPROF_RELATIONS_USER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Customer')
            and   name  = 'RELATIONSHIP30_FK'
            and   indid > 0
            and   indid < 255)
   drop index Customer.RELATIONSHIP30_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Customer')
            and   type = 'U')
   drop table Customer
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GroupCustomer')
            and   type = 'U')
   drop table GroupCustomer
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Permission')
            and   type = 'U')
   drop table Permission
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Product')
            and   name  = 'RELATIONSHIP28_FK'
            and   indid > 0
            and   indid < 255)
   drop index Product.RELATIONSHIP28_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Product')
            and   name  = 'RELATIONSHIP27_FK'
            and   indid > 0
            and   indid < 255)
   drop index Product.RELATIONSHIP27_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Product')
            and   name  = 'RELATIONSHIP19_FK'
            and   indid > 0
            and   indid < 255)
   drop index Product.RELATIONSHIP19_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Product')
            and   type = 'U')
   drop table Product
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ProductCategory')
            and   type = 'U')
   drop table ProductCategory
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ProductOnStock')
            and   name  = 'RELATIONSHIP7_FK'
            and   indid > 0
            and   indid < 255)
   drop index ProductOnStock.RELATIONSHIP7_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ProductOnStock')
            and   name  = 'RELATIONSHIP6_FK'
            and   indid > 0
            and   indid < 255)
   drop index ProductOnStock.RELATIONSHIP6_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ProductOnStock')
            and   type = 'U')
   drop table ProductOnStock
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ProductType')
            and   name  = 'NHOM_FK'
            and   indid > 0
            and   indid < 255)
   drop index ProductType.NHOM_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ProductType')
            and   type = 'U')
   drop table ProductType
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ProductUnit')
            and   type = 'U')
   drop table ProductUnit
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PurchaseOrder')
            and   name  = 'RELATIONSHIP24_FK'
            and   indid > 0
            and   indid < 255)
   drop index PurchaseOrder.RELATIONSHIP24_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PurchaseOrder')
            and   type = 'U')
   drop table PurchaseOrder
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PurchaseOrderDetail')
            and   name  = 'RELATIONSHIP20_FK'
            and   indid > 0
            and   indid < 255)
   drop index PurchaseOrderDetail.RELATIONSHIP20_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PurchaseOrderDetail')
            and   name  = 'RELATIONSHIP10_FK'
            and   indid > 0
            and   indid < 255)
   drop index PurchaseOrderDetail.RELATIONSHIP10_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PurchaseOrderDetail')
            and   type = 'U')
   drop table PurchaseOrderDetail
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SaleOrder')
            and   name  = 'CREATEDBY_FK'
            and   indid > 0
            and   indid < 255)
   drop index SaleOrder.CREATEDBY_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SaleOrder')
            and   name  = 'RELATIONSHIP1_FK'
            and   indid > 0
            and   indid < 255)
   drop index SaleOrder.RELATIONSHIP1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SaleOrder')
            and   type = 'U')
   drop table SaleOrder
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SaleOrderDetail')
            and   name  = 'RELATIONSHIP5_FK'
            and   indid > 0
            and   indid < 255)
   drop index SaleOrderDetail.RELATIONSHIP5_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SaleOrderDetail')
            and   name  = 'RELATIONSHIP2_FK'
            and   indid > 0
            and   indid < 255)
   drop index SaleOrderDetail.RELATIONSHIP2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SaleOrderDetail')
            and   type = 'U')
   drop table SaleOrderDetail
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Stock')
            and   type = 'U')
   drop table Stock
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StockIn')
            and   name  = 'RELATIONSHIP35_FK'
            and   indid > 0
            and   indid < 255)
   drop index StockIn.RELATIONSHIP35_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StockIn')
            and   name  = 'RELATIONSHIP34_FK'
            and   indid > 0
            and   indid < 255)
   drop index StockIn.RELATIONSHIP34_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StockIn')
            and   name  = 'RELATIONSHIP25_FK'
            and   indid > 0
            and   indid < 255)
   drop index StockIn.RELATIONSHIP25_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('StockIn')
            and   type = 'U')
   drop table StockIn
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StockInDetail')
            and   name  = 'RELATIONSHIP17_FK'
            and   indid > 0
            and   indid < 255)
   drop index StockInDetail.RELATIONSHIP17_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('StockInDetail')
            and   type = 'U')
   drop table StockInDetail
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StockInPurchaseAndDonate')
            and   name  = 'RELATIONSHIP15_FK'
            and   indid > 0
            and   indid < 255)
   drop index StockInPurchaseAndDonate.RELATIONSHIP15_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('StockInPurchaseAndDonate')
            and   type = 'U')
   drop table StockInPurchaseAndDonate
go

if exists (select 1
            from  sysobjects
           where  id = object_id('StockInReturn')
            and   type = 'U')
   drop table StockInReturn
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StockInTransfer')
            and   name  = 'RELATIONSHIP37_FK'
            and   indid > 0
            and   indid < 255)
   drop index StockInTransfer.RELATIONSHIP37_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('StockInTransfer')
            and   type = 'U')
   drop table StockInTransfer
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StockInType')
            and   name  = 'RELATIONSHIP36_FK'
            and   indid > 0
            and   indid < 255)
   drop index StockInType.RELATIONSHIP36_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('StockInType')
            and   type = 'U')
   drop table StockInType
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StockOut')
            and   name  = 'RELATIONSHIP384_FK'
            and   indid > 0
            and   indid < 255)
   drop index StockOut.RELATIONSHIP384_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StockOut')
            and   name  = 'WAREHOUSEARRIVED_FK'
            and   indid > 0
            and   indid < 255)
   drop index StockOut.WAREHOUSEARRIVED_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StockOut')
            and   name  = 'RELATIONSHIP22_FK'
            and   indid > 0
            and   indid < 255)
   drop index StockOut.RELATIONSHIP22_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('StockOut')
            and   type = 'U')
   drop table StockOut
go

if exists (select 1
            from  sysobjects
           where  id = object_id('StockOutDestroy')
            and   type = 'U')
   drop table StockOutDestroy
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StockOutDetail')
            and   name  = 'RELATIONSHIP372_FK'
            and   indid > 0
            and   indid < 255)
   drop index StockOutDetail.RELATIONSHIP372_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('StockOutDetail')
            and   type = 'U')
   drop table StockOutDetail
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StockOutReturn')
            and   name  = 'RELATIONSHIP38_FK'
            and   indid > 0
            and   indid < 255)
   drop index StockOutReturn.RELATIONSHIP38_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('StockOutReturn')
            and   type = 'U')
   drop table StockOutReturn
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StockOutSaleAndDonate')
            and   name  = 'RELATIONSHIP40_FK'
            and   indid > 0
            and   indid < 255)
   drop index StockOutSaleAndDonate.RELATIONSHIP40_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('StockOutSaleAndDonate')
            and   type = 'U')
   drop table StockOutSaleAndDonate
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StockOutTransfer')
            and   name  = 'RELATIONSHIP39_FK'
            and   indid > 0
            and   indid < 255)
   drop index StockOutTransfer.RELATIONSHIP39_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('StockOutTransfer')
            and   type = 'U')
   drop table StockOutTransfer
go

if exists (select 1
            from  sysobjects
           where  id = object_id('StockOutType')
            and   type = 'U')
   drop table StockOutType
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Supplier')
            and   name  = 'RELATIONSHIP21_FK'
            and   indid > 0
            and   indid < 255)
   drop index Supplier.RELATIONSHIP21_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Supplier')
            and   type = 'U')
   drop table Supplier
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SupplierProduct')
            and   name  = 'RELATIONSHIP13_FK'
            and   indid > 0
            and   indid < 255)
   drop index SupplierProduct.RELATIONSHIP13_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SupplierProduct')
            and   name  = 'RELATIONSHIP12_FK'
            and   indid > 0
            and   indid < 255)
   drop index SupplierProduct.RELATIONSHIP12_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SupplierProduct')
            and   type = 'U')
   drop table SupplierProduct
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"User"')
            and   name  = 'RELATIONSHIP33_FK'
            and   indid > 0
            and   indid < 255)
   drop index "User".RELATIONSHIP33_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"User"')
            and   name  = 'RELATIONSHIP32_FK'
            and   indid > 0
            and   indid < 255)
   drop index "User".RELATIONSHIP32_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"User"')
            and   name  = 'RELATIONSHIP26_FK'
            and   indid > 0
            and   indid < 255)
   drop index "User".RELATIONSHIP26_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"User"')
            and   type = 'U')
   drop table "User"
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('UserPermission')
            and   name  = 'RELATIONSHIP9_FK'
            and   indid > 0
            and   indid < 255)
   drop index UserPermission.RELATIONSHIP9_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('UserPermission')
            and   name  = 'RELATIONSHIP8_FK'
            and   indid > 0
            and   indid < 255)
   drop index UserPermission.RELATIONSHIP8_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('UserPermission')
            and   type = 'U')
   drop table UserPermission
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('UserProfile')
            and   name  = 'RELATIONSHIP31_FK'
            and   indid > 0
            and   indid < 255)
   drop index UserProfile.RELATIONSHIP31_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('UserProfile')
            and   type = 'U')
   drop table UserProfile
go

if exists (select 1
            from  sysobjects
           where  id = object_id('UserType')
            and   type = 'U')
   drop table UserType
go

/*==============================================================*/
/* Table: Customer                                              */
/*==============================================================*/
create table Customer (
   CustomerId           uniqueidentifier     not null,
   GroupCustomerId      uniqueidentifier     null,
   FullName             varchar(100)         null,
   Birthday             datetime             null,
   NumberPhone          numeric              null,
   Email                varchar(100)         null,
   Address              varchar(100)         null,
   Note                 text                 null,
   constraint PK_CUSTOMER primary key nonclustered (CustomerId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP30_FK                                     */
/*==============================================================*/
create index RELATIONSHIP30_FK on Customer (
GroupCustomerId ASC
)
go

/*==============================================================*/
/* Table: GroupCustomer                                         */
/*==============================================================*/
create table GroupCustomer (
   GroupCustomerId      uniqueidentifier     not null,
   GroupCustomerCode    char(50)             null,
   GroupCustomerName    varchar(100)         null,
   CreatedDate          datetime             null,
   Note                 text                 null,
   constraint PK_GROUPCUSTOMER primary key nonclustered (GroupCustomerId)
)
go

/*==============================================================*/
/* Table: Permission                                            */
/*==============================================================*/
create table Permission (
   PermissionId         uniqueidentifier     not null,
   NamePermission       varchar(255)         null,
   ViewPermission       bit                  null,
   AddPermission        bit                  null,
   EditPermission       bit                  null,
   DeletePermission     bit                  null,
   constraint PK_PERMISSION primary key nonclustered (PermissionId)
)
go

/*==============================================================*/
/* Table: Product                                               */
/*==============================================================*/
create table Product (
   ProductId            uniqueidentifier     not null,
   ProductCategoryId    uniqueidentifier     null,
   ProductTypeId        uniqueidentifier     null,
   ProductUnitId        uniqueidentifier     null,
   ProductCode          char(50)             null,
   ProductName          varchar(100)         null,
   Price                money                null,
   StandardCost         money                null,
   Weight               varchar(20)          null,
   Size                 varchar(20)          null,
   constraint PK_PRODUCT primary key nonclustered (ProductId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP19_FK                                     */
/*==============================================================*/
create index RELATIONSHIP19_FK on Product (
ProductTypeId ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP27_FK                                     */
/*==============================================================*/
create index RELATIONSHIP27_FK on Product (
ProductCategoryId ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP28_FK                                     */
/*==============================================================*/
create index RELATIONSHIP28_FK on Product (
ProductUnitId ASC
)
go

/*==============================================================*/
/* Table: ProductCategory                                       */
/*==============================================================*/
create table ProductCategory (
   ProductCategoryId    uniqueidentifier     not null,
   ProductCategoryCode  char(50)             null,
   ProductCategoryName  varchar(100)         null,
   Note                 text                 null,
   constraint PK_PRODUCTCATEGORY primary key nonclustered (ProductCategoryId)
)
go

/*==============================================================*/
/* Table: ProductOnStock                                        */
/*==============================================================*/
create table ProductOnStock (
   ProductOnStockId     uniqueidentifier     not null,
   ProductId            uniqueidentifier     null,
   StockId              uniqueidentifier     null,
   MinQuanlity          numeric              null,
   MaxQuanlity          numeric              null,
   CreatedDate          datetime             null,
   constraint PK_PRODUCTONSTOCK primary key nonclustered (ProductOnStockId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP6_FK                                      */
/*==============================================================*/
create index RELATIONSHIP6_FK on ProductOnStock (
StockId ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP7_FK                                      */
/*==============================================================*/
create index RELATIONSHIP7_FK on ProductOnStock (
ProductId ASC
)
go

/*==============================================================*/
/* Table: ProductType                                           */
/*==============================================================*/
create table ProductType (
   ProductTypeId        uniqueidentifier     not null,
   ProProducttypeid     uniqueidentifier     null,
   ProductTypeCode      char(50)             null,
   ProductTypeName      varchar(100)         null,
   Note                 text                 null,
   constraint PK_PRODUCTTYPE primary key nonclustered (ProductTypeId)
)
go

/*==============================================================*/
/* Index: NHOM_FK                                               */
/*==============================================================*/
create index NHOM_FK on ProductType (
ProProducttypeid ASC
)
go

/*==============================================================*/
/* Table: ProductUnit                                           */
/*==============================================================*/
create table ProductUnit (
   ProductUnitId        uniqueidentifier     not null,
   ProductUnitCode      char(50)             null,
   ProductUnitName      varchar(100)         null,
   Note                 text                 null,
   constraint PK_PRODUCTUNIT primary key nonclustered (ProductUnitId)
)
go

/*==============================================================*/
/* Table: PurchaseOrder                                         */
/*==============================================================*/
create table PurchaseOrder (
   PurchaseOrderId      uniqueidentifier     not null,
   UserId               uniqueidentifier     null,
   PurchaseOrderCode    char(50)             null,
   CreatedDate          datetime             null,
   Status               numeric              null,
   IsPay                bit                  null,
   constraint PK_PURCHASEORDER primary key nonclustered (PurchaseOrderId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP24_FK                                     */
/*==============================================================*/
create index RELATIONSHIP24_FK on PurchaseOrder (
UserId ASC
)
go

/*==============================================================*/
/* Table: PurchaseOrderDetail                                   */
/*==============================================================*/
create table PurchaseOrderDetail (
   PurchaseOrderDetailId uniqueidentifier     not null,
   PurchaseOrderId      uniqueidentifier     null,
   ProductId            uniqueidentifier     null,
   Status               numeric              null,
   Note                 text                 null,
   QualityPurchase      numeric              null,
   QualityAvalible      numeric              null,
   constraint PK_PURCHASEORDERDETAIL primary key nonclustered (PurchaseOrderDetailId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP10_FK                                     */
/*==============================================================*/
create index RELATIONSHIP10_FK on PurchaseOrderDetail (
ProductId ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP20_FK                                     */
/*==============================================================*/
create index RELATIONSHIP20_FK on PurchaseOrderDetail (
PurchaseOrderId ASC
)
go

/*==============================================================*/
/* Table: SaleOrder                                             */
/*==============================================================*/
create table SaleOrder (
   SaleOrderId          uniqueidentifier     not null,
   UserId               uniqueidentifier     null,
   CustomerId           uniqueidentifier     null,
   SaleOrderCode        char(50)             null,
   ShipAddress          varchar(100)         null,
   Status               numeric              null,
   CancelReason         varchar(100)         null,
   NoteGeneral          text                 null,
   TotalAmount          money                null,
   DiscountPercent      char(50)             null,
   IsPay                bit                  null,
   CreatedDate          datetime             null,
   constraint PK_SALEORDER primary key nonclustered (SaleOrderId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP1_FK                                      */
/*==============================================================*/
create index RELATIONSHIP1_FK on SaleOrder (
CustomerId ASC
)
go

/*==============================================================*/
/* Index: CREATEDBY_FK                                          */
/*==============================================================*/
create index CREATEDBY_FK on SaleOrder (
UserId ASC
)
go

/*==============================================================*/
/* Table: SaleOrderDetail                                       */
/*==============================================================*/
create table SaleOrderDetail (
   SaleOrderDetailId    uniqueidentifier     not null,
   ProductId            uniqueidentifier     null,
   SaleOrderId          uniqueidentifier     null,
   QuanlityOfCustomer   numeric              null,
   QuanlityAvailable    numeric              null,
   Status               numeric              null,
   Note                 text                 null,
   constraint PK_SALEORDERDETAIL primary key nonclustered (SaleOrderDetailId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP2_FK                                      */
/*==============================================================*/
create index RELATIONSHIP2_FK on SaleOrderDetail (
SaleOrderId ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP5_FK                                      */
/*==============================================================*/
create index RELATIONSHIP5_FK on SaleOrderDetail (
ProductId ASC
)
go

/*==============================================================*/
/* Table: Stock                                                 */
/*==============================================================*/
create table Stock (
   StockId              uniqueidentifier     not null,
   StockCode            char(50)             null,
   StockName            varchar(100)         null,
   Address              varchar(100)         null,
   constraint PK_STOCK primary key nonclustered (StockId)
)
go

/*==============================================================*/
/* Table: StockIn                                               */
/*==============================================================*/
create table StockIn (
   StockInId            uniqueidentifier     not null,
   StockId              uniqueidentifier     null,
   UserId               uniqueidentifier     null,
   StockInTypeId        uniqueidentifier     null,
   StockInCode          char(50)             null,
   CreatedDate          datetime             null,
   Status               numeric              null,
   Note                 text                 null,
   AccountingDate       datetime             null,
   PercentComplete      char(50)             null,
   constraint PK_STOCKIN primary key nonclustered (StockInId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP25_FK                                     */
/*==============================================================*/
create index RELATIONSHIP25_FK on StockIn (
UserId ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP34_FK                                     */
/*==============================================================*/
create index RELATIONSHIP34_FK on StockIn (
StockId ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP35_FK                                     */
/*==============================================================*/
create index RELATIONSHIP35_FK on StockIn (
StockInTypeId ASC
)
go

/*==============================================================*/
/* Table: StockInDetail                                         */
/*==============================================================*/
create table StockInDetail (
   StockInDetailID      uniqueidentifier     not null,
   StockInId            uniqueidentifier     null,
   Status               numeric              null,
   Quanlity             numeric              null,
   Note                 text                 null,
   constraint PK_STOCKINDETAIL primary key nonclustered (StockInDetailID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP17_FK                                     */
/*==============================================================*/
create index RELATIONSHIP17_FK on StockInDetail (
StockInId ASC
)
go

/*==============================================================*/
/* Table: StockInPurchaseAndDonate                              */
/*==============================================================*/
create table StockInPurchaseAndDonate (
   StockInId            uniqueidentifier     not null,
   PurchaseOrderId      uniqueidentifier     null,
   StockId              uniqueidentifier     null,
   UserId               uniqueidentifier     null,
   StockInTypeId        uniqueidentifier     null,
   StockInCode          char(50)             null,
   CreatedDate          datetime             null,
   Status               numeric              null,
   Note                 text                 null,
   AccountingDate       datetime             null,
   PercentComplete      char(50)             null,
   constraint PK_STOCKINPURCHASEANDDONATE primary key (StockInId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP15_FK                                     */
/*==============================================================*/
create index RELATIONSHIP15_FK on StockInPurchaseAndDonate (
PurchaseOrderId ASC
)
go

/*==============================================================*/
/* Table: StockInReturn                                         */
/*==============================================================*/
create table StockInReturn (
   StockInId            uniqueidentifier     not null,
   StockId              uniqueidentifier     null,
   UserId               uniqueidentifier     null,
   StockInTypeId        uniqueidentifier     null,
   StockInCode          char(50)             null,
   CreatedDate          datetime             null,
   Status               numeric              null,
   Note                 text                 null,
   AccountingDate       datetime             null,
   PercentComplete      char(50)             null,
   ReasonReturn         text                 null,
   constraint PK_STOCKINRETURN primary key (StockInId)
)
go

/*==============================================================*/
/* Table: StockInTransfer                                       */
/*==============================================================*/
create table StockInTransfer (
   StockInId            uniqueidentifier     not null,
   StockId              uniqueidentifier     null,
   Sto_StockId          uniqueidentifier     null,
   UserId               uniqueidentifier     null,
   StockInTypeId        uniqueidentifier     null,
   StockInCode          char(50)             null,
   CreatedDate          datetime             null,
   Status               numeric              null,
   Note                 text                 null,
   AccountingDate       datetime             null,
   PercentComplete      char(50)             null,
   constraint PK_STOCKINTRANSFER primary key (StockInId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP37_FK                                     */
/*==============================================================*/
create index RELATIONSHIP37_FK on StockInTransfer (
StockId ASC
)
go

/*==============================================================*/
/* Table: StockInType                                           */
/*==============================================================*/
create table StockInType (
   StockInTypeId        uniqueidentifier     not null,
   StoStockintypeid     uniqueidentifier     null,
   StockInTypeName      varchar(24)          null,
   constraint PK_STOCKINTYPE primary key nonclustered (StockInTypeId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP36_FK                                     */
/*==============================================================*/
create index RELATIONSHIP36_FK on StockInType (
StoStockintypeid ASC
)
go

/*==============================================================*/
/* Table: StockOut                                              */
/*==============================================================*/
create table StockOut (
   StockOutId           uniqueidentifier     not null,
   StockId              uniqueidentifier     null,
   StockOutType         uniqueidentifier     null,
   UserId               uniqueidentifier     null,
   StockOutCode         char(50)             null,
   Status               numeric              null,
   Note                 text                 null,
   CreatedDate          datetime             null,
   PercentComplete      char(50)             null,
   constraint PK_STOCKOUT primary key nonclustered (StockOutId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP22_FK                                     */
/*==============================================================*/
create index RELATIONSHIP22_FK on StockOut (
UserId ASC
)
go

/*==============================================================*/
/* Index: WAREHOUSEARRIVED_FK                                   */
/*==============================================================*/
create index WAREHOUSEARRIVED_FK on StockOut (
StockId ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP384_FK                                    */
/*==============================================================*/
create index RELATIONSHIP384_FK on StockOut (
StockOutType ASC
)
go

/*==============================================================*/
/* Table: StockOutDestroy                                       */
/*==============================================================*/
create table StockOutDestroy (
   StockOutId           uniqueidentifier     not null,
   StockId              uniqueidentifier     null,
   StockOutType         uniqueidentifier     null,
   UserId               uniqueidentifier     null,
   StockOutCode         char(50)             null,
   Status               numeric              null,
   Note                 text                 null,
   CreatedDate          datetime             null,
   PercentComplete      char(50)             null,
   DestroyReason        text                 null,
   constraint PK_STOCKOUTDESTROY primary key (StockOutId)
)
go

/*==============================================================*/
/* Table: StockOutDetail                                        */
/*==============================================================*/
create table StockOutDetail (
   StockOutDetailId     uniqueidentifier     not null,
   StockOutId           uniqueidentifier     null,
   Quanlity             numeric              null,
   constraint PK_STOCKOUTDETAIL primary key nonclustered (StockOutDetailId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP372_FK                                    */
/*==============================================================*/
create index RELATIONSHIP372_FK on StockOutDetail (
StockOutId ASC
)
go

/*==============================================================*/
/* Table: StockOutReturn                                        */
/*==============================================================*/
create table StockOutReturn (
   StockOutId           uniqueidentifier     not null,
   SupplierId           uniqueidentifier     null,
   StockId              uniqueidentifier     null,
   StockOutType         uniqueidentifier     null,
   UserId               uniqueidentifier     null,
   StockOutCode         char(50)             null,
   Status               numeric              null,
   Note                 text                 null,
   CreatedDate          datetime             null,
   PercentComplete      char(50)             null,
   ReasonReturn         text                 null,
   constraint PK_STOCKOUTRETURN primary key (StockOutId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP38_FK                                     */
/*==============================================================*/
create index RELATIONSHIP38_FK on StockOutReturn (
SupplierId ASC
)
go

/*==============================================================*/
/* Table: StockOutSaleAndDonate                                 */
/*==============================================================*/
create table StockOutSaleAndDonate (
   StockOutId           uniqueidentifier     not null,
   SaleOrderId          uniqueidentifier     null,
   StockId              uniqueidentifier     null,
   StockOutType         uniqueidentifier     null,
   UserId               uniqueidentifier     null,
   StockOutCode         char(50)             null,
   Status               numeric              null,
   Note                 text                 null,
   CreatedDate          datetime             null,
   PercentComplete      char(50)             null,
   constraint PK_STOCKOUTSALEANDDONATE primary key (StockOutId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP40_FK                                     */
/*==============================================================*/
create index RELATIONSHIP40_FK on StockOutSaleAndDonate (
SaleOrderId ASC
)
go

/*==============================================================*/
/* Table: StockOutTransfer                                      */
/*==============================================================*/
create table StockOutTransfer (
   StockOutId           uniqueidentifier     not null,
   StockId              uniqueidentifier     null,
   Sto_StockId          uniqueidentifier     null,
   StockOutType         uniqueidentifier     null,
   UserId               uniqueidentifier     null,
   StockOutCode         char(50)             null,
   Status               numeric              null,
   Note                 text                 null,
   CreatedDate          datetime             null,
   PercentComplete      char(50)             null,
   constraint PK_STOCKOUTTRANSFER primary key (StockOutId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP39_FK                                     */
/*==============================================================*/
create index RELATIONSHIP39_FK on StockOutTransfer (
StockId ASC
)
go

/*==============================================================*/
/* Table: StockOutType                                          */
/*==============================================================*/
create table StockOutType (
   StockOutType         uniqueidentifier     not null,
   StockOutTypeName     varchar(255)         null,
   constraint PK_STOCKOUTTYPE primary key nonclustered (StockOutType)
)
go

/*==============================================================*/
/* Table: Supplier                                              */
/*==============================================================*/
create table Supplier (
   SupplierId           uniqueidentifier     not null,
   PurchaseOrderId      uniqueidentifier     null,
   SupplierCode         char(50)             null,
   SupplierName         varchar(100)         null,
   Addpress             varchar(150)         null,
   TaxCode              char(50)             null,
   CreatedDate          datetime             null,
   PhoneNumber          numeric              null,
   Email                varchar(100)         null,
   constraint PK_SUPPLIER primary key nonclustered (SupplierId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP21_FK                                     */
/*==============================================================*/
create index RELATIONSHIP21_FK on Supplier (
PurchaseOrderId ASC
)
go

/*==============================================================*/
/* Table: SupplierProduct                                       */
/*==============================================================*/
create table SupplierProduct (
   SuplierProductId     uniqueidentifier     not null,
   ProductId            uniqueidentifier     null,
   SupplierId           uniqueidentifier     null,
   MaxQuanlity          numeric              null,
   MinQuanlity          numeric              null,
   constraint PK_SUPPLIERPRODUCT primary key nonclustered (SuplierProductId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP12_FK                                     */
/*==============================================================*/
create index RELATIONSHIP12_FK on SupplierProduct (
ProductId ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP13_FK                                     */
/*==============================================================*/
create index RELATIONSHIP13_FK on SupplierProduct (
SupplierId ASC
)
go

/*==============================================================*/
/* Table: "User"                                                */
/*==============================================================*/
create table "User" (
   UserId               uniqueidentifier     not null,
   UserTypeId           uniqueidentifier     null,
   StockId              uniqueidentifier     null,
   UserProfileId        uniqueidentifier     null,
   UserName             char(50)             null,
   Password             char(50)             null,
   CreatedDate          datetime             null,
   IsLock               bit                  null,
   IsAdmin              bit                  null,
   IsActive             bit                  null,
   constraint PK_USER primary key nonclustered (UserId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP26_FK                                     */
/*==============================================================*/
create index RELATIONSHIP26_FK on "User" (
StockId ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP32_FK                                     */
/*==============================================================*/
create index RELATIONSHIP32_FK on "User" (
UserProfileId ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP33_FK                                     */
/*==============================================================*/
create index RELATIONSHIP33_FK on "User" (
UserTypeId ASC
)
go

/*==============================================================*/
/* Table: UserPermission                                        */
/*==============================================================*/
create table UserPermission (
   UserPermissionID     uniqueidentifier     not null,
   PermissionId         uniqueidentifier     null,
   UserId               uniqueidentifier     null,
   constraint PK_USERPERMISSION primary key nonclustered (UserPermissionID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP8_FK                                      */
/*==============================================================*/
create index RELATIONSHIP8_FK on UserPermission (
PermissionId ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP9_FK                                      */
/*==============================================================*/
create index RELATIONSHIP9_FK on UserPermission (
UserId ASC
)
go

/*==============================================================*/
/* Table: UserProfile                                           */
/*==============================================================*/
create table UserProfile (
   UserProfileId        uniqueidentifier     not null,
   UserId               uniqueidentifier     null,
   FirstName            varchar(256)         null,
   MiddleName           varchar(256)         null,
   LastName             varchar(10)          null,
   FullName             varchar(100)         null,
   IdentityCard         char(20)             null,
   Address              varchar(100)         null,
   Birthday             datetime             null,
   Email                varchar(100)         null,
   Gender               int                  null,
   Avatar               char(20)             null,
   MaritalStatus        int                  null,
   constraint PK_USERPROFILE primary key nonclustered (UserProfileId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP31_FK                                     */
/*==============================================================*/
create index RELATIONSHIP31_FK on UserProfile (
UserId ASC
)
go

/*==============================================================*/
/* Table: UserType                                              */
/*==============================================================*/
create table UserType (
   UserTypeId           uniqueidentifier     not null,
   UserTypeCode         char(50)             null,
   UserTypeName         varchar(255)         null,
   Note                 text                 null,
   constraint PK_USERTYPE primary key nonclustered (UserTypeId)
)
go

alter table Customer
   add constraint FK_CUSTOMER_RELATIONS_GROUPCUS foreign key (GroupCustomerId)
      references GroupCustomer (GroupCustomerId)
go

alter table Product
   add constraint FK_PRODUCT_RELATIONS_PRODUCTT foreign key (ProductTypeId)
      references ProductType (ProductTypeId)
go

alter table Product
   add constraint FK_PRODUCT_RELATIONS_PRODUCTC foreign key (ProductCategoryId)
      references ProductCategory (ProductCategoryId)
go

alter table Product
   add constraint FK_PRODUCT_RELATIONS_PRODUCTU foreign key (ProductUnitId)
      references ProductUnit (ProductUnitId)
go

alter table ProductOnStock
   add constraint FK_PRODUCTO_RELATIONS_STOCK foreign key (StockId)
      references Stock (StockId)
go

alter table ProductOnStock
   add constraint FK_PRODUCTO_RELATIONS_PRODUCT foreign key (ProductId)
      references Product (ProductId)
go

alter table ProductType
   add constraint FK_PRODUCTT_NHOM_PRODUCTT foreign key (ProProducttypeid)
      references ProductType (ProductTypeId)
go

alter table PurchaseOrder
   add constraint FK_PURCHASE_RELATIONS_USER foreign key (UserId)
      references "User" (UserId)
go

alter table PurchaseOrderDetail
   add constraint FK_PURCHASE_RELATIONS_PRODUCT foreign key (ProductId)
      references Product (ProductId)
go

alter table PurchaseOrderDetail
   add constraint FK_PURCHASE_RELATIONS_PURCHASE foreign key (PurchaseOrderId)
      references PurchaseOrder (PurchaseOrderId)
go

alter table SaleOrder
   add constraint FK_SALEORDE_CREATEDBY_USER foreign key (UserId)
      references "User" (UserId)
go

alter table SaleOrder
   add constraint FK_SALEORDE_RELATIONS_CUSTOMER foreign key (CustomerId)
      references Customer (CustomerId)
go

alter table SaleOrderDetail
   add constraint FK_SALEORDE_RELATIONS_SALEORDE foreign key (SaleOrderId)
      references SaleOrder (SaleOrderId)
go

alter table SaleOrderDetail
   add constraint FK_SALEORDE_RELATIONS_PRODUCT foreign key (ProductId)
      references Product (ProductId)
go

alter table StockIn
   add constraint FK_STOCKIN_RELATIONS_USER foreign key (UserId)
      references "User" (UserId)
go

alter table StockIn
   add constraint FK_STOCKIN_RELATIONS_STOCK foreign key (StockId)
      references Stock (StockId)
go

alter table StockIn
   add constraint FK_STOCKIN_RELATIONS_STOCKINT foreign key (StockInTypeId)
      references StockInType (StockInTypeId)
go

alter table StockInDetail
   add constraint FK_STOCKIND_RELATIONS_STOCKIN foreign key (StockInId)
      references StockIn (StockInId)
go

alter table StockInPurchaseAndDonate
   add constraint FK_STOCKINP_INHERITAN_STOCKIN foreign key (StockInId)
      references StockIn (StockInId)
go

alter table StockInPurchaseAndDonate
   add constraint FK_STOCKINP_RELATIONS_PURCHASE foreign key (PurchaseOrderId)
      references PurchaseOrder (PurchaseOrderId)
go

alter table StockInReturn
   add constraint FK_STOCKINR_INHERITAN_STOCKIN foreign key (StockInId)
      references StockIn (StockInId)
go

alter table StockInTransfer
   add constraint FK_STOCKINT_INHERITAN_STOCKIN foreign key (StockInId)
      references StockIn (StockInId)
go

alter table StockInTransfer
   add constraint FK_STOCKINT_RELATIONS_STOCK foreign key (StockId)
      references Stock (StockId)
go

alter table StockInType
   add constraint FK_STOCKINT_RELATIONS_STOCKINT foreign key (StoStockintypeid)
      references StockInType (StockInTypeId)
go

alter table StockOut
   add constraint FK_STOCKOUT_RELATIONS_USER foreign key (UserId)
      references "User" (UserId)
go

alter table StockOut
   add constraint FK_STOCKOUT_RELATIONS_STOCKOUTTYPE foreign key (StockOutType)
      references StockOutType (StockOutType)
go

alter table StockOut
   add constraint FK_STOCKOUT_WAREHOUSE_STOCK foreign key (StockId)
      references Stock (StockId)
go

alter table StockOutDestroy
   add constraint FK_STOCKOUTDESTROY_INHERITAN_STOCKOUT foreign key (StockOutId)
      references StockOut (StockOutId)
go

alter table StockOutDetail
   add constraint FK_STOCKOUTDETAIL_RELATIONS_STOCKOUT foreign key (StockOutId)
      references StockOut (StockOutId)
go

alter table StockOutReturn
   add constraint FK_STOCKOUTRETURN_INHERITAN_STOCKOUT foreign key (StockOutId)
      references StockOut (StockOutId)
go

alter table StockOutReturn
   add constraint FK_STOCKOUT_RELATIONS_SUPPLIER foreign key (SupplierId)
      references Supplier (SupplierId)
go

alter table StockOutSaleAndDonate
   add constraint FK_STOCKOUTSALEANDDOANTE_INHERITAN_STOCKOUT foreign key (StockOutId)
      references StockOut (StockOutId)
go

alter table StockOutSaleAndDonate
   add constraint FK_STOCKOUT_RELATIONS_SALEORDE foreign key (SaleOrderId)
      references SaleOrder (SaleOrderId)
go

alter table StockOutTransfer
   add constraint FK_STOCKOUTTRANSFER_INHERITAN_STOCKOUT foreign key (StockOutId)
      references StockOut (StockOutId)
go

alter table StockOutTransfer
   add constraint FK_STOCKOUT_RELATIONS_STOCK foreign key (StockId)
      references Stock (StockId)
go

alter table Supplier
   add constraint FK_SUPPLIER_RELATIONS_PURCHASE foreign key (PurchaseOrderId)
      references PurchaseOrder (PurchaseOrderId)
go

alter table SupplierProduct
   add constraint FK_SUPPLIER_RELATIONS_PRODUCT foreign key (ProductId)
      references Product (ProductId)
go

alter table SupplierProduct
   add constraint FK_SUPPLIER_RELATIONS_SUPPLIER foreign key (SupplierId)
      references Supplier (SupplierId)
go

alter table "User"
   add constraint FK_USER_RELATIONS_STOCK foreign key (StockId)
      references Stock (StockId)
go

alter table "User"
   add constraint FK_USER_RELATIONS_USERPROF foreign key (UserProfileId)
      references UserProfile (UserProfileId)
go

alter table "User"
   add constraint FK_USER_RELATIONS_USERTYPE foreign key (UserTypeId)
      references UserType (UserTypeId)
go

alter table UserPermission
   add constraint FK_USERPERM_RELATIONS_PERMISSI foreign key (PermissionId)
      references Permission (PermissionId)
go

alter table UserPermission
   add constraint FK_USERPERM_RELATIONS_USER foreign key (UserId)
      references "User" (UserId)
go

alter table UserProfile
   add constraint FK_USERPROF_RELATIONS_USER foreign key (UserId)
      references "User" (UserId)
go


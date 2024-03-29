/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     31/12/2020 10:41:10 CH                       */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('AddressCustomer') and o.name = 'FK_ADDRESSC_RELATIONS_CUSTOMER')
alter table AddressCustomer
   drop constraint FK_ADDRESSC_RELATIONS_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('GroupMember') and o.name = 'FK_GROUPMEM_RELATIONS_CUSTOMER')
alter table GroupMember
   drop constraint FK_GROUPMEM_RELATIONS_CUSTOMER
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
   where r.fkeyid = object_id('ProductType') and o.name = 'FK_PRODUCTT_GROUP_PRODUCTT')
alter table ProductType
   drop constraint FK_PRODUCTT_GROUP_PRODUCTT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PurchaseOrder') and o.name = 'FK_PURCHASE_RELATIONS_USER')
alter table PurchaseOrder
   drop constraint FK_PURCHASE_RELATIONS_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PurchaseOrder') and o.name = 'FK_PURCHASE_RELATIONS_SUPPLIER')
alter table PurchaseOrder
   drop constraint FK_PURCHASE_RELATIONS_SUPPLIER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PurchaseOrder') and o.name = 'FK_PURCHASE_RELATIONS_STOCK')
alter table PurchaseOrder
   drop constraint FK_PURCHASE_RELATIONS_STOCK
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
   where r.fkeyid = object_id('StockIn') and o.name = 'FK_STOCKIN_RELATIONS_PURCHASE')
alter table StockIn
   drop constraint FK_STOCKIN_RELATIONS_PURCHASE
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
   where r.fkeyid = object_id('StockIn') and o.name = 'FK_STOCKIN_RELATIONS_STOCKINTYPE')
alter table StockIn
   drop constraint FK_STOCKIN_RELATIONS_STOCKINTYPE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockInDetail') and o.name = 'FK_STOCKINDDETAIL_RELATIONS_STOCKIN')
alter table StockInDetail
   drop constraint FK_STOCKINDDETAIL_RELATIONS_STOCKIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockManager') and o.name = 'FK_STOCKMAN_RELATIONS_USER')
alter table StockManager
   drop constraint FK_STOCKMAN_RELATIONS_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockManager') and o.name = 'FK_STOCKMAN_RELATIONS_STOCK')
alter table StockManager
   drop constraint FK_STOCKMAN_RELATIONS_STOCK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockOut') and o.name = 'FK_STOCKOUT_RELATIONS_USER')
alter table StockOut
   drop constraint FK_STOCKOUT_RELATIONS_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockOut') and o.name = 'FK_STOCKOUT_RELATIONS_SUPPLIER')
alter table StockOut
   drop constraint FK_STOCKOUT_RELATIONS_SUPPLIER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockOut') and o.name = 'FK_STOCKOUT_RELATIONS_STOCK')
alter table StockOut
   drop constraint FK_STOCKOUT_RELATIONS_STOCK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockOut') and o.name = 'FK_STOCKOUT_RELATIONS_STOCKOUTTYPE')
alter table StockOut
   drop constraint FK_STOCKOUT_RELATIONS_STOCKOUTTYPE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockOut') and o.name = 'FK_STOCKOUT_RELATIONS_SALEORDE')
alter table StockOut
   drop constraint FK_STOCKOUT_RELATIONS_SALEORDE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockOut') and o.name = 'FK_STOCKOUT_WAREHOUSE_STOCK')
alter table StockOut
   drop constraint FK_STOCKOUT_WAREHOUSE_STOCK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('StockOutDetail') and o.name = 'FK_STOCKOUTDETAIL_RELATIONS_STOCKOUT')
alter table StockOutDetail
   drop constraint FK_STOCKOUTDETAIL_RELATIONS_STOCKOUT
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
            from  sysindexes
           where  id    = object_id('AddressCustomer')
            and   name  = 'RELATIONSHIP40_FK'
            and   indid > 0
            and   indid < 255)
   drop index AddressCustomer.RELATIONSHIP40_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AddressCustomer')
            and   type = 'U')
   drop table AddressCustomer
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
            from  sysindexes
           where  id    = object_id('GroupMember')
            and   name  = 'RELATIONSHIP45_FK'
            and   indid > 0
            and   indid < 255)
   drop index GroupMember.RELATIONSHIP45_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GroupMember')
            and   type = 'U')
   drop table GroupMember
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
            and   name  = 'RELATIONSHIP44_FK'
            and   indid > 0
            and   indid < 255)
   drop index PurchaseOrder.RELATIONSHIP44_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PurchaseOrder')
            and   name  = 'RELATIONSHIP42_FK'
            and   indid > 0
            and   indid < 255)
   drop index PurchaseOrder.RELATIONSHIP42_FK
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
            and   name  = 'RELATIONSHIP15_FK'
            and   indid > 0
            and   indid < 255)
   drop index StockIn.RELATIONSHIP15_FK
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
            from  sysobjects
           where  id = object_id('StockInType')
            and   type = 'U')
   drop table StockInType
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StockManager')
            and   name  = 'RELATIONSHIP43_FK'
            and   indid > 0
            and   indid < 255)
   drop index StockManager.RELATIONSHIP43_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StockManager')
            and   name  = 'RELATIONSHIP42_FK'
            and   indid > 0
            and   indid < 255)
   drop index StockManager.RELATIONSHIP42_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('StockManager')
            and   type = 'U')
   drop table StockManager
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StockOut')
            and   name  = 'RELATIONSHIP38_FK'
            and   indid > 0
            and   indid < 255)
   drop index StockOut.RELATIONSHIP38_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StockOut')
            and   name  = 'RELATIONSHIP40_FK'
            and   indid > 0
            and   indid < 255)
   drop index StockOut.RELATIONSHIP40_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('StockOut')
            and   name  = 'RELATIONSHIP39_FK'
            and   indid > 0
            and   indid < 255)
   drop index StockOut.RELATIONSHIP39_FK
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
            from  sysobjects
           where  id = object_id('StockOutType')
            and   type = 'U')
   drop table StockOutType
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
            from  sysobjects
           where  id = object_id('UserType')
            and   type = 'U')
   drop table UserType
go

/*==============================================================*/
/* Table: AddressCustomer                                       */
/*==============================================================*/
create table AddressCustomer (
   AddressCustomerId    uniqueidentifier     not null,
   CustomerId           uniqueidentifier     null,
   ProvinceCity         nvarchar(255)        null,
   District             nvarchar(255)        null,
   Ward                 nvarchar(255)        null,
   Detail               nvarchar(255)        null,
   Note                 nvarchar(255)        null,
   CreatedDate          datetime             null,
   constraint PK_ADDRESSCUSTOMER primary key nonclustered (AddressCustomerId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP40_FK                                     */
/*==============================================================*/
create index RELATIONSHIP40_FK on AddressCustomer (
CustomerId ASC
)
go

/*==============================================================*/
/* Table: Customer                                              */
/*==============================================================*/
create table Customer (
   CustomerId           uniqueidentifier     not null,
   CustomerCode         varchar(50)          null,
   FullName             nvarchar(255)        null,
   Birthday             datetime             null,
   NumberPhone          numeric              null,
   Email                varchar(50)          null,
   CreatedDate          datetime             null,
   UpdatedDate          datetime             null,
   Note                 nvarchar(255)        null,
   Avatar               varchar(1024)        null,
   constraint PK_CUSTOMER primary key nonclustered (CustomerId)
)
go

/*==============================================================*/
/* Table: GroupCustomer                                         */
/*==============================================================*/
create table GroupCustomer (
   GroupCustomerId      uniqueidentifier     not null,
   GroupCustomerCode    varchar(50)          null,
   GroupCustomerName    nvarchar(255)        null,
   CreatedDate          datetime             null,
   CreatedPerson        uniqueidentifier     null,
   constraint PK_GROUPCUSTOMER primary key nonclustered (GroupCustomerId)
)
go

/*==============================================================*/
/* Table: GroupMember                                           */
/*==============================================================*/
create table GroupMember (
   GroupMemberID        uniqueidentifier     not null,
   CustomerId           uniqueidentifier     null,
   GroupCustomerId      uniqueidentifier     null,
   CreatedDate          datetime             null,
   constraint PK_GROUPMEMBER primary key nonclustered (GroupMemberID)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP45_FK                                     */
/*==============================================================*/
create index RELATIONSHIP45_FK on GroupMember (
CustomerId ASC
)
go

/*==============================================================*/
/* Table: Permission                                            */
/*==============================================================*/
create table Permission (
   PermissionId         uniqueidentifier     not null,
   NamePermission       nvarchar(255)        null,
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
   ProductCode          varchar(50)          null,
   ProductName          nvarchar(255)        null,
   Price                money                null,
   Weight               float                null,
   Size                 float                null,
   Color                nvarchar(255)        null,
   Picture              text                 null,
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
   ProductCategoryCode  varchar(50)          null,
   ProductCategoryName  nvarchar(255)        null,
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
   GroupBy              uniqueidentifier     null,
   ProductTypeCode      varchar(50)          null,
   ProductTypeName      nvarchar(255)        null,
   CreatedDate          datetime             null,
   constraint PK_PRODUCTTYPE primary key nonclustered (ProductTypeId)
)
go

/*==============================================================*/
/* Index: NHOM_FK                                               */
/*==============================================================*/
create index NHOM_FK on ProductType (
GroupBy ASC
)
go

/*==============================================================*/
/* Table: ProductUnit                                           */
/*==============================================================*/
create table ProductUnit (
   ProductUnitId        uniqueidentifier     not null,
   ProductUnitCode      char(50)             null,
   ProductUnitName      nvarchar(255)        null,
   constraint PK_PRODUCTUNIT primary key nonclustered (ProductUnitId)
)
go

/*==============================================================*/
/* Table: PurchaseOrder                                         */
/*==============================================================*/
create table PurchaseOrder (
   PurchaseOrderId      uniqueidentifier     not null,
   StockId              uniqueidentifier     null,
   CreatedBy            uniqueidentifier     null,
   SupplierId           uniqueidentifier     null,
   PurchaseOrderCode    varchar(50)          null,
   Status               numeric              null,
   IsPay                bit                  null,
   constraint PK_PURCHASEORDER primary key nonclustered (PurchaseOrderId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP24_FK                                     */
/*==============================================================*/
create index RELATIONSHIP24_FK on PurchaseOrder (
CreatedBy ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP42_FK                                     */
/*==============================================================*/
create index RELATIONSHIP42_FK on PurchaseOrder (
SupplierId ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP44_FK                                     */
/*==============================================================*/
create index RELATIONSHIP44_FK on PurchaseOrder (
StockId ASC
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
   CreatedBy            uniqueidentifier     null,
   CustomerId           uniqueidentifier     null,
   SaleOrderCode        varchar(50)          null,
   ShipAddress          nvarchar(255)        null,
   Status               numeric              null,
   CancelReason         text                 null,
   NoteGeneral          text                 null,
   TotalAmount          money                null,
   DiscountPercent      float                null,
   IsPay                bit                  null,
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
CreatedBy ASC
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
   StockCode            varchar(50)          null,
   StockName            nvarchar(255)        null,
   Address              nvarchar(255)        null,
   PhoneNumber          numeric              null,
   constraint PK_STOCK primary key nonclustered (StockId)
)
go

/*==============================================================*/
/* Table: StockIn                                               */
/*==============================================================*/
create table StockIn (
   StockInId            uniqueidentifier     not null,
   ToStock              uniqueidentifier     null,
   CreatedBy            uniqueidentifier     null,
   PurchaseOrderId      uniqueidentifier     null,
   StockInTypeId        uniqueidentifier     null,
   StockInCode          varchar(50)          null,
   Status               numeric              null,
   AccountingDate       datetime             null,
   PercentComplete      float                null,
   ReasonReturn         text                 null,
   constraint PK_STOCKIN primary key nonclustered (StockInId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP25_FK                                     */
/*==============================================================*/
create index RELATIONSHIP25_FK on StockIn (
CreatedBy ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP34_FK                                     */
/*==============================================================*/
create index RELATIONSHIP34_FK on StockIn (
ToStock ASC
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
/* Index: RELATIONSHIP15_FK                                     */
/*==============================================================*/
create index RELATIONSHIP15_FK on StockIn (
PurchaseOrderId ASC
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
/* Table: StockInType                                           */
/*==============================================================*/
create table StockInType (
   StockInTypeId        uniqueidentifier     not null,
   StockInTypeName      nvarchar(255)        null,
   constraint PK_STOCKINTYPE primary key nonclustered (StockInTypeId)
)
go

/*==============================================================*/
/* Table: StockManager                                          */
/*==============================================================*/
create table StockManager (
   StockManagerId       uniqueidentifier     not null,
   UserId               uniqueidentifier     null,
   StockId              uniqueidentifier     null,
   FromDate             datetime             null,
   ToDate               datetime             null,
   constraint PK_STOCKMANAGER primary key nonclustered (StockManagerId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP42_FK                                     */
/*==============================================================*/
create index RELATIONSHIP42_FK on StockManager (
UserId ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP43_FK                                     */
/*==============================================================*/
create index RELATIONSHIP43_FK on StockManager (
StockId ASC
)
go

/*==============================================================*/
/* Table: StockOut                                              */
/*==============================================================*/
create table StockOut (
   StockOutId           uniqueidentifier     not null,
   FromStock            uniqueidentifier     null,
   ToStock              uniqueidentifier     null,
   StockOutType         uniqueidentifier     null,
   SupplierId           uniqueidentifier     null,
   CreatedBy            uniqueidentifier     null,
   SaleOrderId          uniqueidentifier     null,
   StockOutCode         varchar(50)          null,
   Status               numeric              null,
   PercentComplete      float                null,
   DestroyReason        text                 null,
   ReasonReturn         text                 null,
   constraint PK_STOCKOUT primary key nonclustered (StockOutId)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP22_FK                                     */
/*==============================================================*/
create index RELATIONSHIP22_FK on StockOut (
CreatedBy ASC
)
go

/*==============================================================*/
/* Index: WAREHOUSEARRIVED_FK                                   */
/*==============================================================*/
create index WAREHOUSEARRIVED_FK on StockOut (
FromStock ASC
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
/* Index: RELATIONSHIP39_FK                                     */
/*==============================================================*/
create index RELATIONSHIP39_FK on StockOut (
ToStock ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP40_FK                                     */
/*==============================================================*/
create index RELATIONSHIP40_FK on StockOut (
SaleOrderId ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP38_FK                                     */
/*==============================================================*/
create index RELATIONSHIP38_FK on StockOut (
SupplierId ASC
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
/* Table: StockOutType                                          */
/*==============================================================*/
create table StockOutType (
   StockOutType         uniqueidentifier     not null,
   StockOutTypeName     nvarchar(255)        null,
   constraint PK_STOCKOUTTYPE primary key nonclustered (StockOutType)
)
go

/*==============================================================*/
/* Table: Supplier                                              */
/*==============================================================*/
create table Supplier (
   SupplierId           uniqueidentifier     not null,
   SupplierCode         varchar(50)          null,
   SupplierName         nvarchar(255)        null,
   Address              nvarchar(255)        null,
   TaxCode              varchar(50)          null,
   PhoneNumber          numeric              null,
   Email                varchar(50)          null,
   constraint PK_SUPPLIER primary key nonclustered (SupplierId)
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
   UserCode             varchar(50)          null,
   UserName             varchar(50)          null,
   Password             nvarchar(255)        null,
   FirstName            nvarchar(255)        null,
   MiddleName           nvarchar(255)        null,
   LastName             nvarchar(255)        null,
   FullName             nvarchar(255)        null,
   IdentityCard         varchar(50)          null,
   Address              nvarchar(255)        null,
   Birthday             datetime             null,
   Email                varchar(50)          null,
   Gender               int                  null,
   Avatar               varchar(1024)        null,
   MaritalStatus        int                  null,
   CreatedDate          datetime             null,
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
/* Table: UserType                                              */
/*==============================================================*/
create table UserType (
   UserTypeId           uniqueidentifier     not null,
   UserTypeCode         varchar(50)          null,
   UserTypeName         nvarchar(255)        null,
   constraint PK_USERTYPE primary key nonclustered (UserTypeId)
)
go

alter table AddressCustomer
   add constraint FK_ADDRESSC_RELATIONS_CUSTOMER foreign key (CustomerId)
      references Customer (CustomerId)
go

alter table GroupMember
   add constraint FK_GROUPMEM_RELATIONS_CUSTOMER foreign key (CustomerId)
      references Customer (CustomerId)
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
   add constraint FK_PRODUCTT_GROUP_PRODUCTT foreign key (GroupBy)
      references ProductType (ProductTypeId)
go

alter table PurchaseOrder
   add constraint FK_PURCHASE_RELATIONS_USER foreign key (CreatedBy)
      references "User" (UserId)
go

alter table PurchaseOrder
   add constraint FK_PURCHASE_RELATIONS_SUPPLIER foreign key (SupplierId)
      references Supplier (SupplierId)
go

alter table PurchaseOrder
   add constraint FK_PURCHASE_RELATIONS_STOCK foreign key (StockId)
      references Stock (StockId)
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
   add constraint FK_SALEORDE_CREATEDBY_USER foreign key (CreatedBy)
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
   add constraint FK_STOCKIN_RELATIONS_PURCHASE foreign key (PurchaseOrderId)
      references PurchaseOrder (PurchaseOrderId)
go

alter table StockIn
   add constraint FK_STOCKIN_RELATIONS_USER foreign key (CreatedBy)
      references "User" (UserId)
go

alter table StockIn
   add constraint FK_STOCKIN_RELATIONS_STOCK foreign key (ToStock)
      references Stock (StockId)
go

alter table StockIn
   add constraint FK_STOCKIN_RELATIONS_STOCKINTYPE foreign key (StockInTypeId)
      references StockInType (StockInTypeId)
go

alter table StockInDetail
   add constraint FK_STOCKINDDETAIL_RELATIONS_STOCKIN foreign key (StockInId)
      references StockIn (StockInId)
go

alter table StockManager
   add constraint FK_STOCKMAN_RELATIONS_USER foreign key (UserId)
      references "User" (UserId)
go

alter table StockManager
   add constraint FK_STOCKMAN_RELATIONS_STOCK foreign key (StockId)
      references Stock (StockId)
go

alter table StockOut
   add constraint FK_STOCKOUT_RELATIONS_USER foreign key (CreatedBy)
      references "User" (UserId)
go

alter table StockOut
   add constraint FK_STOCKOUT_RELATIONS_SUPPLIER foreign key (SupplierId)
      references Supplier (SupplierId)
go

alter table StockOut
   add constraint FK_STOCKOUT_RELATIONS_STOCK foreign key (ToStock)
      references Stock (StockId)
go

alter table StockOut
   add constraint FK_STOCKOUT_RELATIONS_STOCKOUTTYPE foreign key (StockOutType)
      references StockOutType (StockOutType)
go

alter table StockOut
   add constraint FK_STOCKOUT_RELATIONS_SALEORDE foreign key (SaleOrderId)
      references SaleOrder (SaleOrderId)
go

alter table StockOut
   add constraint FK_STOCKOUT_WAREHOUSE_STOCK foreign key (FromStock)
      references Stock (StockId)
go

alter table StockOutDetail
   add constraint FK_STOCKOUTDETAIL_RELATIONS_STOCKOUT foreign key (StockOutId)
      references StockOut (StockOutId)
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


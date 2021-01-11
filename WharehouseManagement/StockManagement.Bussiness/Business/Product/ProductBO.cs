using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Data;

namespace StockManagement.Business
{
    public class ProductBO : Repository<Product>, IProduct
    {
        public List<vw_ProductOnStockDetail> GetProductOnStockDetail(Guid productId)
        {
            using (var db = new StockManagementEntities())
            {
                List<vw_ProductOnStockDetail> vw_ProductOnStockDetailList = db.vw_ProductOnStockDetail.Where(x => x.ProductId == productId).ToList();

                return vw_ProductOnStockDetailList;
            }
        }
        public List<vw_ProductOnStockDetail> GetProductOnStockDetail()
        {
            using (var db = new StockManagementEntities())
            {
                List<vw_ProductOnStockDetail> vw_ProductOnStockDetailList = db.vw_ProductOnStockDetail.ToList();

                return vw_ProductOnStockDetailList;
            }
        }

        public List<vw_ProductOnStock> GetProductOnStock()
        {
            using (var db = new StockManagementEntities())
            {
                List<vw_ProductOnStock> vw_ProductOnStockList = db.vw_ProductOnStock.ToList();

                return vw_ProductOnStockList;
            }

        }
        public List<ProductType> GetProductTypes()
        {
            using (var db = new StockManagementEntities())
            {
                List<ProductType> productTypes = db.ProductType.ToList();
                return productTypes;
            }
        }
        public List<vw_Product> GetProducts()
        {
            using (var db = new StockManagementEntities())
            {
                List<vw_Product> vw_ProductList = db.vw_Product.ToList();
                return vw_ProductList;
            }
        }

        //public bool AddProductType(ProductType productType)
        //{
        //    try
        //    {
        //        using (var db = new StockManagementEntities())
        //        {
        //            db.ProductType.Add(productType);
        //            db.SaveChanges();
        //            return true;
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
        public bool UpdateProductOnStock(vw_StockIn stockIn)
        {
            try
            {
                using (var db = new StockManagementEntities())
                {
                    List<StockInDetail> stockInDetailList = db.StockInDetail.Where(x => x.StockInId == stockIn.StockInId).ToList();
                    if (stockInDetailList.Count() == 0)
                    {
                        ///TODO: stockin đợi có data 
                    }
                    foreach (StockInDetail stockInDetail in stockInDetailList)
                    {
                        db.ProductOnStock.Where(x => x.StockId == stockIn.ToStock && x.ProductId == stockInDetail.ProductId).FirstOrDefault().RecentQuanlity+= stockInDetail.Quanlity;
                    }
                    db.SaveChanges();
                    return true;
                }

            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}

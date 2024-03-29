﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Data;

namespace StockManagement.Business
{
    public class SaleOrderBO : Repository<SaleOrder>, ISaleOrder
    {
        public List<vw_SaleOrder> GetData(int status)
        {
            using (var db = new StockManagementEntities())
            {
                return db.vw_SaleOrder.Where(s=>s.Status == status).ToList();
            }
        }
        public void ChangeStatus(Guid saleOrderId, Guid updatedPerson, int status)
        {
            using (var db = new StockManagementEntities())
            {
                db.SaleOrder.Find(saleOrderId).Status = 2;
                db.SaveChanges();

            }
        }

        public void AddSaleOrder(SaleOrder saleOrder)
        {
            using (var db = new StockManagementEntities())
            {
                db.SaleOrder.Add(saleOrder);
                db.SaveChanges();
            }
        }

        //public List<vw_ProductOnStockDetail> GetProductOnStockByUser()
        //{

        //}
    }
}

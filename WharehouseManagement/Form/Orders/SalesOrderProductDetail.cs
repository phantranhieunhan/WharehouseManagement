using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StockManagement.Data;

namespace StockManagement.Form.Orders
{
    public partial class SalesOrderProductDetail : DevExpress.XtraEditors.XtraForm
    {
        public SalesOrderProductDetail()
        {
            InitializeComponent();
        }
        public SalesOrderProductDetail(List<Data.vw_ProductOnStockDetail> vw_ProductOnStockDetailList)
        {
            try
            {
                //if (vw_ProductOnStockDetailList.Any())
                //{
                //    lb_MaSP.Text = "abc"; 
                //        //vw_ProductOnStockDetailList.FirstOrDefault().ProductCode;
                    
                //    lb_TenSP.Text = vw_ProductOnStockDetailList.FirstOrDefault().ProductName;

                //    Gc_ProductOnStock.DataSource = vw_ProductOnStockDetailList;
                //}
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
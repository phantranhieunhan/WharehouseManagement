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
    public partial class ProductOnStockDetail : DevExpress.XtraEditors.XtraForm
    {
        public ProductOnStockDetail()
        {
            InitializeComponent();
        }
        public ProductOnStockDetail(List<Data.vw_ProductOnStockDetail> vw_ProductOnStockDetailList)
        {
            InitializeComponent();
            try
            {
                if (vw_ProductOnStockDetailList.Any())
                {
                    lb_MaSP.Text = vw_ProductOnStockDetailList.FirstOrDefault().ProductCode;

                    lb_TenSP.Text = vw_ProductOnStockDetailList.FirstOrDefault().ProductName;

                    Gc_ProductOnStock.DataSource = vw_ProductOnStockDetailList;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
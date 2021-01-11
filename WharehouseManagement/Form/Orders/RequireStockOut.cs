using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagement.Data;
using StockManagement.Business.Model;
using StockManagement.Business;

namespace StockManagement.Form.Orders
{
    public partial class RequireStockOut : DevExpress.XtraEditors.XtraForm
    {

        private Guid SaleOrderType = new Guid("D46275C5-9D4A-42D6-8791-24AD89CB3247");
        public RequireStockOut()
        {
            InitializeComponent();

            //gridColumn14.Width = Unit.Pixel(170);
            //gridColumn14.SettingsHeaderFilter.Mode = GridHeaderFilterMode.CheckedList;
            //gridColumn14.Settings.AutoFilterCondition = AutoFilterCondition.Contains;
            //gridColumn14.ReadOnly = false;
            //column.Visible = true;
            //column.ColumnType = MVCxGridViewColumnType.SpinEdit;
            //var columnSettings = column.PropertiesEdit as SpinEditProperties;
            //columnSettings.ValidationSettings.Display = Display.Dynamic;
            //columnSettings.ValidationSettings.ErrorTextPosition = ErrorTextPosition.Left;
            //columnSettings.AllowNull = false;
            //columnSettings.MinValue = 0;
            //columnSettings.MaxValue = byte.MaxValue;
            //columnSettings.NumberType = SpinEditNumberType.Integer;
            //columnSettings.DecrementButtonStyle.Height = Unit.Pixel(10);
        }
        List<RequireStockOutModel> vw_StockOutDetailList = new List<RequireStockOutModel>();
        List<vw_SaleOrder> saleOrderList;
        IStockOut stockOutBO = new StockOutBO();
        public RequireStockOut(List<vw_SaleOrder> vw_SaleList)
        {
            InitializeComponent();
            saleOrderList = vw_SaleList;
            vw_SaleOrder vw_Sale = vw_SaleList.FirstOrDefault();

            lb_SaleOrderName.Text = "Đơn hàng : " + vw_Sale.SaleOrderCode;
            lb_address.Text = vw_Sale.FullAddress;
            lb_PhoneNumber.Text = "0" + vw_Sale.NumberPhone.ToString();

            Data.StockOut stockOut = new Data.StockOut();
            stockOut.SaleOrderId = vw_Sale.SaleOrderId;
            stockOut.Status = 1;
            stockOut.StockOutCode = "SO01" + vw_Sale.SaleOrderCode;

            foreach (vw_SaleOrder vw_saleOrderItem in vw_SaleList)
            {
                //StockOutDetail stockOutDetail = new StockOutDetail();
                //stockOutDetail.StockOutDetailId = Guid.NewGuid();
                //stockOutDetail.StockOutId = stockOut.SaleOrderId;
                //stockOutDetail.Quanlity = 0;
                //stockOutDetail.ProductId = vw_saleOrderItem.ProductId;

                RequireStockOutModel requireStockOutModel = new RequireStockOutModel();
                requireStockOutModel.ProductId = vw_saleOrderItem.ProductId;
                requireStockOutModel.ProductCode = vw_saleOrderItem.ProductCode;
                requireStockOutModel.ProductName = vw_saleOrderItem.ProductName;
                requireStockOutModel.QuanlityRequire = Convert.ToInt32(vw_saleOrderItem.QuanlityOfCustomer);
                requireStockOutModel.QuanlityProvide = 0;

                vw_StockOutDetailList.Add(requireStockOutModel);
                //stockOut.StockOutDetail.Add(stockOutDetail);
            }
            gc_Product.DataSource = new BindingList<RequireStockOutModel>(vw_StockOutDetailList.OrderBy(x => x.ProductCode).ToList());
        }


        private void RequireStockOut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockManagementDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.stockManagementDataSet.Stock);

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            RequireStockOutModel requireStockOutModel = (RequireStockOutModel)gridView1.GetFocusedRow();

            RequireStockOutModel newRequireStockOutModel = new RequireStockOutModel();

            if (!vw_StockOutDetailList.Where(x => x.ProductId == requireStockOutModel.ProductId && x.StockId == Guid.Empty).Any())
            {
                newRequireStockOutModel.RequireStockOutModelId = Guid.NewGuid();
                newRequireStockOutModel.ProductId = requireStockOutModel.ProductId;
                newRequireStockOutModel.ProductName = requireStockOutModel.ProductName;
                newRequireStockOutModel.ProductCode = requireStockOutModel.ProductCode;
                newRequireStockOutModel.QuanlityRequire = requireStockOutModel.QuanlityRequire;
                newRequireStockOutModel.QuanlityProvide = 0;
                newRequireStockOutModel.StockId = Guid.Empty;

                vw_StockOutDetailList.Add(newRequireStockOutModel);
            }


            gc_Product.DataSource = new BindingList<RequireStockOutModel>(vw_StockOutDetailList.OrderBy(x => x.ProductCode).ToList());
        }

        private void se_Provide_EditValueChanged(object sender, EventArgs e)
        {
            List<RequireStockOutModel> requireStockOutModelList = vw_StockOutDetailList.OrderBy(x => x.ProductCode).ToList();
            Guid temProductId = requireStockOutModelList.FirstOrDefault().ProductId;
            int sum = 0;
            int sumPre = 0;
            foreach (RequireStockOutModel requireItem in requireStockOutModelList)
            {
                if (requireItem.ProductId == temProductId)
                {
                    sum += requireItem.QuanlityProvide;
                    sumPre = requireItem.QuanlityRequire;
                }
                else
                {
                    if (sum > sumPre)
                    {
                        bt_require.Enabled = false;
                    }
                    else
                    {
                        bt_require.Enabled = true;
                    }
                    temProductId = requireItem.ProductId;
                }
            }
            //se_Provide.Buttons[gridView1.GetFocusedDataSourceRowIndex()].Enabled = true;
        }
        private class RequireData
        {
            public Guid StockId;
            public List<RequireStockOutModel> RequireStockOutModelList;
        }
        private void bt_require_Click(object sender, EventArgs e)
        {
            try
            {
                vw_SaleOrder vw_Sale = saleOrderList.FirstOrDefault();

                List<RequireData> requireDatas = new List<RequireData>();
                RequireStockOutModel requireStockOutModel = vw_StockOutDetailList.FirstOrDefault();

                List<Guid> stockInIdList = vw_StockOutDetailList.OrderBy(x => x.StockId).Select(x => x.StockId).Distinct().ToList();
                stockInIdList.Remove(Guid.Empty);
                foreach (Guid guid in stockInIdList)
                {
                    RequireData requireData = new RequireData();
                    requireData.StockId = guid;
                    requireData.RequireStockOutModelList = new List<RequireStockOutModel>();
                    foreach (RequireStockOutModel item in vw_StockOutDetailList)
                    {
                        if (guid == item.StockId)
                        {
                            requireData.RequireStockOutModelList.Add(item);
                        }
                    }
                    requireDatas.Add(requireData);
                }



                foreach (RequireData item in requireDatas)
                {
                    Data.StockOut stockOut = new Data.StockOut();
                    stockOut.StockOutId = Guid.NewGuid();
                    stockOut.FromStock = item.StockId;
                    stockOut.CreatedBy = Session.UserId;
                    stockOut.CreatedDate = DateTime.Now;
                    stockOut.SaleOrderId = vw_Sale.SaleOrderId;
                    stockOut.StockOutType = SaleOrderType;
                    stockOut.StockOutCode = vw_Sale.SaleOrderCode + "SO" + (stockOutBO.GetAll().Count() + 1).ToString();
                    stockOut.Status = 1;
                    stockOut.CreatedBy = new Guid("217F9628-607F-4F74-8DFD-685B97696263");

                    foreach (RequireStockOutModel require in item.RequireStockOutModelList)
                    {
                        StockOutDetail stockOutDetail = new StockOutDetail();
                        stockOutDetail.StockOutDetailId = Guid.NewGuid();
                        stockOutDetail.ProductId = require.ProductId;
                        stockOutDetail.Quanlity = require.QuanlityProvide;
                        stockOutDetail.Status = 1;
                        stockOutDetail.StockOutId = stockOut.StockOutId;
                        stockOut.StockOutDetail.Add(stockOutDetail);
                    }

                    stockOutBO.Add(stockOut);
                    MessageBox.Show("Yêu cầu xuất kho thành công!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
    //foreach (RequireStockOutModel item in vw_StockOutDetailList)
    //{
    //    Data.StockOut stockOut = new Data.StockOut();
    //    stockOut.StockOutId = Guid.NewGuid();
    //    stockOut.SaleOrderId
    //    stockOutBO.Add()
    //}

}

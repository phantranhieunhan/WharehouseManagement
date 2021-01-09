using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StockManagement.Data;
using StockManagement.Business;

namespace StockManagement.Form.Supplier
{
    public partial class SupplierList : DevExpress.XtraEditors.XtraUserControl
    {
        public SupplierList()
        {
            InitializeComponent();
            GetInit();
        }
        ISupplier supplierBO = new SupplierBO();

        public void GetInit()
        {
            GetDataActive();
        }

        private void GetDataActive()
        {
            Gc_Supplier.DataSource = supplierBO.GetSuppliers(true); 
        }
        private void GetDataUnActive()
        {
            Gc_Unactive.DataSource = supplierBO.GetSuppliers(true);
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            AddSupplier addSupplier = new AddSupplier();
            addSupplier.Show();
        }

        private void btClickDelete(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Data.Supplier supplier = (Data.Supplier)gridView1.GetFocusedRow();

            if (XtraMessageBox.Show("Bạn có muốn tắt hoạt động của nhà cung cấp "+supplier.SupplierName+" ?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                supplier.Active = false;
                supplierBO.Update(supplier);

            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex==0)
            {
                GetDataActive();
            }
            else
            {
                GetDataUnActive();
            }
        }

        private void activeButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Data.Supplier supplier = (Data.Supplier)gridView1.GetFocusedRow();

            if (XtraMessageBox.Show("Bạn có muốn bật hoạt động của nhà cung cấp " + supplier.SupplierName + " ?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                supplier.Active = true;
                supplierBO.Update(supplier);
            }
        }

        private void editButton_Active_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridView1.OptionsBehavior.Editable)
            {
                Data.Supplier supplier = (Data.Supplier)gridView1.GetFocusedRow();

                if (XtraMessageBox.Show("Bạn có muốn chỉnh sửa nhà cung cấp " + supplier.SupplierName + " ?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    supplierBO.Update(supplier);

                }

            }
        }

        private void editButton_UnActive_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridView2.OptionsBehavior.Editable)
            {
                Data.Supplier supplier = (Data.Supplier)gridView2.GetFocusedRow();

                if (XtraMessageBox.Show("Bạn có muốn chỉnh sửa nhà cung cấp " + supplier.SupplierName + " ?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    supplierBO.Update(supplier);

                }

            }
        }
    }
}

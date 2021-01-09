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
using StockManagement.Business;
using StockManagement.Data;

namespace StockManagement.Form.Supplier
{
    public partial class AddSupplier : DevExpress.XtraEditors.XtraForm
    {
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Data.Supplier supplier = new Data.Supplier();
            supplier.SupplierId = Guid.NewGuid();
            supplier.SupplierName = txt_SupplierName.Text;
            supplier.SupplierCode = txt_SupplierCode.Text;
            supplier.PhoneNumber = txt_PhoneNumber.Text;
            supplier.Address = txt_Address.Text;
            supplier.Email = txt_Email.Text;
            supplier.TaxCode = txt_TaxCode.Text;
            supplier.Active = true;

            ISupplier supplierBO = new SupplierBO();
            supplierBO.Add(supplier);
        }
    }
}
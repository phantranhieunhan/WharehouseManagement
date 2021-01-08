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

using StockManagement.Business;
using StockManagement.Data;
using DevExpress.XtraEditors.Repository;

namespace StockManagement.Form.Employee
{

    public partial class Decentralization : BaseUserForm
    {

        public Decentralization()
        {
            InitializeComponent();
            GetInit();
        }
        List<vw_UserPermission> listOffical = new List<vw_UserPermission>();
        StockManagementEntities db = new StockManagementEntities();
        public void GetInit()
        {
            IDecentralization decentralization = new DecentralizationBO();


            //RepositoryItemCheckEdit repositoryItemCheckEdit = new RepositoryItemCheckEdit();
            //repositoryItemCheckEdit.ValueChecked = 1;
            //repositoryItemCheckEdit.ValueUnchecked = 0;

            //foreach (DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn item in advBandedGridView1.Columns)
            //{
            //    if(!item.FieldName.Equals("FullName") && !item.FieldName.Equals("UserCode"))
            //    {
            //        item.ColumnEdit = repositoryItemCheckEdit;
            //    }
            //}
            //listOffical = decentralization.GetMany();

            gC_DanhSach.DataSource = db.vw_UserPermission.ToList();
            //db.UserPermission.Where(x=>x.UserPermissionID = )
        }

        private void advBandedGridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView data = (DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView)sender;
                string focusColumn = data.FocusedColumn.FieldName;
                
                vw_UserPermission userPermission = (vw_UserPermission)data.GetFocusedRow();

                bool valueChange = Convert.ToBoolean(data.GetFocusedValue());

                IDecentralization decentralizationBO = new DecentralizationBO();
                decentralizationBO.Post(userPermission.UserPermissionID, focusColumn, !valueChange);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

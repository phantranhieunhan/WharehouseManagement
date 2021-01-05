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
        List<System.Dynamic.ExpandoObject> listDecen = new List<System.Dynamic.ExpandoObject>();
        List<UserPermission> listOffical = new List<UserPermission>();
        public void GetInit()
        {
            IDecentralization decentralization = new DecentralizationBO();
            

            RepositoryItemCheckEdit repositoryItemCheckEdit = new RepositoryItemCheckEdit();
            repositoryItemCheckEdit.ValueChecked = 1;
            repositoryItemCheckEdit.ValueUnchecked = 0;

            foreach (DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn item in advBandedGridView1.Columns)
            {
                if(!item.FieldName.Equals("FullName") && !item.FieldName.Equals("UserCode"))
                {
                    item.ColumnEdit = repositoryItemCheckEdit;
                }
            }
            listDecen = decentralization.GetMany(Session.UserId);
            gridControl1.DataSource = listDecen;

        }

        private void advBandedGridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //using (var db = new StockManagementEntities())
            //{
            //    foreach (System.Dynamic.ExpandoObject item in listDecen)
            //    {
            //        dynamic newUserPermission = item;
            //        Guid userId = newUserPermission.UserId;
            //        var userPermission = db.UserPermissions.Where(u => u.UserId == userId);
            //    }
            //}

            
        }
    }
}

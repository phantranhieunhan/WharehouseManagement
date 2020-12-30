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

namespace StockManagement.Form
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
            txt_username.Text = "nhandora123";
            txt_password.Text = "123456";
            //LoginBO loginBO = new LoginBO();
            //loginBO.Register(new User()
            //{
            //    UserId = Guid.NewGuid(),
            //    UserName = "nhandora123",
            //    Password = "123456",
            //    CreatedDate = DateTime.Now
            //});
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            LoginBO loginBO = new LoginBO();
            bool check = loginBO.CheckUser(txt_username.Text, txt_password.Text);
            if (check)
            {
                this.Hide();
                FormMain mainForm = new FormMain();
                mainForm.Show();
            }
            else
            {
                DialogResult result = XtraMessageBox.Show("Do you want to quit the application?", "Confirmation", MessageBoxButtons.OK);
                if(result == DialogResult.OK)
                {
                    this.Close();
                }

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Utils;

namespace StockManagement
{
    public class BaseForm : DevExpress.XtraEditors.XtraForm
    {
        //protected ISession _session = new Session();
        public BaseForm()
        {
        }
        public bool IsLogin { get; set; }
        public Guid UserId { get; set; }

        public void Clear()
        {

        }
    }
    public class BaseUserForm : DevExpress.XtraEditors.XtraUserControl
    {
        //protected ISession _session = new Session();
        public BaseUserForm()
        {
        }
        public bool IsLogin { get; set; }
        public Guid UserId { get; set; }

        public void Clear()
        {

        }
    }
}

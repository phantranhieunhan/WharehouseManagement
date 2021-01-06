using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagement.Data;

namespace StockManagement.Business
{
    public interface IDecentralization
    {
        List<string> GetOne(Guid userId);
        List<vw_UserPermission> GetMany();
        void Post(Guid userPermissionId, string nameColumn, bool valueChange);
    }
}

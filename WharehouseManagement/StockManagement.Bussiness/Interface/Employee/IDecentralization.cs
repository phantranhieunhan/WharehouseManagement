using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Business
{
    public interface IDecentralization
    {
        List<ExpandoObject> GetMany(Guid userId);
    }
}

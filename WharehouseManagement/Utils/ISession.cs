using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Utils
{
    public interface ISession
    {
        void Clear();
        bool IsLogin { get; set; }
        Guid UserId { get; set; }

        
    }
}

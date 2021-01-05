using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    public static class Session
    {
        public static bool IsLogin { get; set; }
        public static Guid UserId { get; set; }
        public static string FullName { get; set; }

        public static void Clear()
        {
            UserId = Guid.Empty;
            IsLogin = false;
        }
    }
}

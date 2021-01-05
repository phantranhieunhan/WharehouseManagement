using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using StockManagement.Business.Utils;
using StockManagement.Data;

namespace StockManagement.Business
{
    public class DecentralizationBO:Repository<UserPermission>
    {
        //public List<ExpandoObject> GetMany(Guid userId)
        //{
        //    try
        //    {
        //        using (var db = new StockManagementEntities())
        //        {
                   
        //        }
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}
        //public void PostMany(List<ExpandoObject> abc)
        //{
        //    try
        //    {
        //        using (var db = new StockManagementEntities())
        //        {
        //            db.Database.CommandTimeout = 1000;
        //            using (IDbConnection conn = (SqlConnection)db.Database.Connection)
        //            {

        //                StreamReader sqlFile = new StreamReader("D:/DoAnTotNghiep/WharehouseManagement/SQLScripts/" + "Decentralization.sql");
        //                string sqlQuery = sqlFile.ReadToEnd();

        //                DynamicParameters param = new DynamicParameters();
        //                param.Add("userId", userId);

        //                using (var multiResult = conn.QueryMultiple(sqlQuery, param))
        //                {
        //                    List<ExpandoObject> result = multiResult.Read<dynamic>().Select(x => (ExpandoObject)DapperHelper.ToExpandoDynamic(x)).ToList();
        //                    return result;
        //                }
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

    }
}

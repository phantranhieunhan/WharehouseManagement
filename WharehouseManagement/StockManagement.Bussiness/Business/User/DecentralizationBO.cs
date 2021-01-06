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
    public class DecentralizationBO:Repository<UserPermission>, IDecentralization
    {
        public List<string> GetOne(Guid userId)
        {
            try
            {
                using (var db = new StockManagementEntities())
                {
                    using (IDbConnection conn = (SqlConnection)db.Database.Connection)
                    {
                        DynamicParameters param = new DynamicParameters();
                        string sqlQuery = @"select PermissionName from (select  UserId, PermissionName, Status
                                            from UserPermission a
                                            unpivot
                                            (
                                                Status
                                                for PermissionName in ([btn_CustomerGroup], [btn_CustomerList], [btn_Decentralization], [btn_EmployeeList], [btn_InventoryManagement], [btn_ProductList], [btn_ProductPortfolio], [btn_PurchaseOrder], [btn_SaleOrder], [btn_StockIn], [btn_StockOut], [btn_SupplierList], [btn_SupplierProduct], [btn_TypeEmployee], [btn_WarehouseList], [btn_Report1], [btn_Report2], [btn_Report3], [btn_Report4], [btn_Report5], [btn_Setting1], [btn_Setting2], [btn_Setting3], [btn_Setting4], [btn_Setting5])
                                            ) b) c
                                            where Status = 1 and UserId = @userId";
                        param.Add("userId", userId);
                        var resultData = conn.Query<string>(sqlQuery, param).ToList();
                        return resultData;
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        public List<vw_UserPermission> GetMany()
        {
            try
            {
                using (var db = new StockManagementEntities())
                {
                    List<vw_UserPermission> vw_UserPermissions = db.vw_UserPermission.ToList();

                    return vw_UserPermissions;
                }
            }
            catch
            {
                throw;
            }
        }
        public void Post(Guid userPermissionId, string nameColumn, bool valueChange)
        {
            try
            {
                using (var db = new StockManagementEntities())
                {

                    typeof(UserPermission).GetProperty(nameColumn).SetValue(db.UserPermission.Find(userPermissionId), valueChange);

                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            //try
            //{
            //    using (var db = new StockManagementEntities())
            //    {
            //        db.Database.CommandTimeout = 1000;
            //        using (IDbConnection conn = (SqlConnection)db.Database.Connection)
            //        {

            //            StreamReader sqlFile = new StreamReader("D:/DoAnTotNghiep/WharehouseManagement/SQLScripts/" + "Decentralization.sql");
            //            string sqlQuery = sqlFile.ReadToEnd();

            //            DynamicParameters param = new DynamicParameters();
            //            param.Add("userId", userId);

            //            using (var multiResult = conn.QueryMultiple(sqlQuery, param))
            //            {
            //                List<ExpandoObject> result = multiResult.Read<dynamic>().Select(x => (ExpandoObject)DapperHelper.ToExpandoDynamic(x)).ToList();
            //                return result;
            //            }
            //        }
            //    }
            //}
            //catch
            //{
            //    throw;
            //}
        }

    }
}

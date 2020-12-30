using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dapper;


namespace StockManagement.Data
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        #region Variables
        //string MsgCode, MsgMessage;
        protected ConnectionFactory IConnect;
        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        protected Repository()
        {
            if (IConnect == null)
            {
                IConnect = new ConnectionFactory(new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString));
            }
        }

        #endregion

        #region Get Data

        /// <summary>
        /// Get List object
        /// </summary>
        /// <param name="navigationProperties">parameter</param>
        /// <returns>Return IList objects</returns>
        public IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            try
            {
                using (var db = new StockManagementEntities())
                {
                    List<T> list;
                    IQueryable<T> dbQuery = db.Set<T>();

                    //Apply eager loading
                    foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                        dbQuery = dbQuery.Include<T, object>(navigationProperty);

                    list = dbQuery
                        .AsNoTracking()
                        .ToList<T>();
                    this.TotalRows = list.Count();
                    return list;
                }
            }
            catch
            {
                throw;
            }
        }

        public IList<T> GetAll(int startRow, int maxRow, params Expression<Func<T, object>>[] navigationProperties)
        {
            try
            {
                using (var db = new StockManagementEntities())
                {
                    List<T> list;
                    IQueryable<T> dbQuery = db.Set<T>();

                    //Apply eager loading
                    foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                        dbQuery = dbQuery.Include<T, object>(navigationProperty);

                    list = dbQuery
                        .AsNoTracking()
                        .ToList<T>();
                    this.TotalRows = list.Count();
                    return list.Skip(startRow).Take(maxRow).ToList();
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Get list object by some conditions 
        /// </summary>
        /// <param name="where">Where conditions</param>
        /// <param name="navigationProperties"></param>
        /// <returns></returns>
        public IList<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            try
            {
                using (var db = new StockManagementEntities())
                {
                    List<T> list;
                    IQueryable<T> dbQuery = db.Set<T>();

                    //Apply eager loading
                    foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                        dbQuery = dbQuery.Include<T, object>(navigationProperty);

                    list = dbQuery
                        .AsNoTracking()
                        .Where(where)
                        .ToList<T>();
                    this.TotalRows = list.Count();
                    return list;
                }
            }
            catch
            {
                throw;
            }
        }

        public IList<T> RunFullTextContainsQuery(Expression<Func<T, object>> property, string search)
        {
            using (var db = new StockManagementEntities())
            {
                if (string.IsNullOrWhiteSpace(search))
                {
                    return Enumerable.Empty<T>().ToList();
                }

                var unaryExpression = property.Body as UnaryExpression;

                var memberExpression = property.Body as MemberExpression ?? (unaryExpression != null ? unaryExpression.Operand as MemberExpression : null);

                if (memberExpression == null)
                {
                    throw new Exception(string.Format("Invalid lambda expression: '{0}'.", property));
                }

                var query = string.Format("SELECT * FROM {0} WHERE freetext( ({1}), @search)", GetTableName(), memberExpression.Member.Name);

                return db.Database.SqlQuery<T>(query, new SqlParameter("@search", search)).ToList();
            }
        }

        public IList<T> GetList(int startRow, int maxRow, Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            try
            {
                using (var db = new StockManagementEntities())
                {
                    List<T> list;
                    IQueryable<T> dbQuery = db.Set<T>();

                    //Apply eager loading
                    foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                        dbQuery = dbQuery.Include<T, object>(navigationProperty);

                    list = dbQuery
                        .AsNoTracking()
                        .Where(where)
                        .ToList<T>();
                    this.TotalRows = list.Count();
                    return list.Skip(startRow).Take(maxRow).ToList();
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Get single object
        /// </summary>
        /// <param name="where">Where some conditions</param>
        /// <param name="navigationProperties"></param>
        /// <returns>Return Object </returns>
        public T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            try
            {
                using (var db = new StockManagementEntities())
                {
                    T item = null;
                    IQueryable<T> dbQuery = db.Set<T>();

                    //Apply eager loading
                    foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                        dbQuery = dbQuery.Include<T, object>(navigationProperty);

                    item = dbQuery
                        .AsNoTracking() //Don't track any changes for the selected item
                        .FirstOrDefault(where); //Apply where clause
                    this.TotalRows = 1;
                    return item;
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Get object by object ID
        /// </summary>
        /// <param name="ID">object ID</param>
        /// <returns>Return only object</returns>
        public T GetByID(object ID)
        {
            try
            {
                using (var db = new StockManagementEntities())
                {
                    return db.Set<T>().Find(ID);
                }
            }
            catch
            {
                throw;
            }
        }




        #endregion

        #region Insert, Update, Delete

        /// <summary>
        /// Add new item
        /// </summary>
        /// <param name="item">Object</param>
        /// <returns>True/False</returns>
        public bool Add(T item)
        {
            try
            {
                using (var db = new StockManagementEntities())
                {
                    db.Entry(item).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Add news multi items
        /// </summary>
        /// <param name="items">list items</param>
        /// <returns>True/False</returns>
        public bool Add(List<T> items)
        {
            try
            {
                using (var db = new StockManagementEntities())
                {
                    foreach (T item in items)
                    {
                        db.Entry(item).State = System.Data.Entity.EntityState.Added;
                    }
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {

                throw;
            }
        }

        /// <summary>
        /// Update item
        /// </summary>
        /// <param name="item">Item</param>
        /// <returns>True/False</returns>
        public bool Update(T item)
        {
            try
            {
                using (var db = new StockManagementEntities())
                {
                    DbSet dbSet = db.Set<T>();
                    db.Entry(item).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Update list items
        /// </summary>
        /// <param name="items">List items</param>
        /// <returns>True/False</returns>
        public bool Update(List<T> items)
        {
            try
            {
                using (var db = new StockManagementEntities())
                {
                    foreach (T item in items)
                    {
                        db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Delete item by ID
        /// </summary>
        /// <param name="ID">Item ID</param>
        /// <returns>True/False</returns>
        public bool Delete(object ID)
        {
            try
            {
                using (var db = new StockManagementEntities())
                {
                    DbSet<T> dbSet;
                    dbSet = db.Set<T>();
                    T obj = db.Set<T>().Find(ID);
                    if (db.Entry(obj).State == EntityState.Detached)
                    {
                        dbSet.Attach(obj);
                    }

                    dbSet.Remove(obj);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (DbUpdateException ex)
            {
                throw ex;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Delete multi items
        /// </summary>
        /// <param name="items">List items</param>
        /// <returns>True/False</returns>
        public bool Delete(List<T> items)
        {
            try
            {
                using (var db = new StockManagementEntities())
                {
                    DbSet<T> dbSet;
                    dbSet = db.Set<T>();
                    dbSet.RemoveRange(items);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (DbUpdateException ex)
            {
                throw ex;
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region Utils Functions



        #endregion

        #region Get & Set
        public int TotalRows { get; set; }




        #endregion

        #region Private 

        private string GetTableName()
        {
            using (var db = new StockManagementEntities())
            {
                var objectContext = ((IObjectContextAdapter)db).ObjectContext;
                var sql = objectContext.CreateObjectSet<T>().ToTraceString();
                var regex = new Regex(@"FROM\s+(?<table>.+)\s+AS");
                var match = regex.Match(sql);

                return match.Groups["table"].Value;
            }
        }

        public decimal GetCurrentRefNo(string sequenceName)
        {
            using (System.Data.IDbConnection conn = IConnect.GetOpenConnection())
            {
                #region Where Clause
                DynamicParameters param = new DynamicParameters();
                var sqlWhere = new StringBuilder("name=@pName");
                param.Add("pName", sequenceName);
                #endregion

                string sqlQuery = @"SELECT current_value FROM sys.sequences where " + sqlWhere;

                using (var multiResult = conn.QueryMultiple(sqlQuery, param))
                {
                    return multiResult.Read<int>().Single() + 1;
                }
            }
        }




        #endregion
    }

}

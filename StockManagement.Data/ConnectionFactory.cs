using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Data
{

    public class ConnectionFactory : IDisposable
    {
        #region Properties

        /// <summary>
        /// 
        /// </summary>
        private IDbConnection _connection;

        #endregion

        /// <summary>
        /// Constructors
        /// </summary>
        /// <param name="connection"></param>
        public ConnectionFactory(IDbConnection connection)
        {
            _connection = connection;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IDbConnection GetOpenConnection()
        {
            string connectionString = "Data Source=LAPTOP-IJLQ1L9S;Initial Catalog=StockManagement;Integrated Security=True";
            _connection = new SqlConnection(connectionString);
            //if (_connection == null)
            //{
            //    //Initalize sql connection
            //    _connection = new SqlConnection(connectionString);
            //}
            //else if (string.IsNullOrEmpty(_connection.ConnectionString))
            //{
            //    //Reinitalize sql connectionstring
            //    _connection.ConnectionString = connectionString;
            //}

            if (_connection.State != ConnectionState.Open && _connection.State != ConnectionState.Connecting)
            {
                //Open connection
                _connection.Open();
            }
            return _connection;
        }

        /// <summary>
        /// Close the connection if this is open
        /// </summary>
        public void Dispose()
        {
            if (_connection != null && _connection.State != ConnectionState.Closed)
                _connection.Close();
        }
    }
}

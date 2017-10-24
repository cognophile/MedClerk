using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MedClerk.Database
{
    class DatabaseManager
    {
        private string connectionStr;
        private System.Data.SqlClient.SqlConnection connection;
        private System.Data.SqlClient.SqlDataAdapter adapter;

        /// <summary>
        /// Constructer to set the connection string from soloution properties 
        /// </summary>
        /// <param name="connectionStr">String representing database location and settings</param>
        public DatabaseManager(string connectionStr)
        {
            this.connectionStr = connectionStr;
        }

        /// <summary>
        /// Create a connection to the member variable database 
        /// </summary>
        public void OpenConnection()
        {
            connection = new System.Data.SqlClient.SqlConnection(connectionStr);
            connection.Open();
        }

        /// <summary>
        /// Close the connection to the member variable database
        /// </summary>
        public void CloseConnection()
        {
            connection.Close();
        }

        /// <summary>
        /// Given a SQL statement, execute the query on the database
        /// </summary>
        /// <param name="sql">A string of SQL statements</param>
        /// <returns>DataSet object representing results of the query</returns>
        public DataSet ExecuteQuery(string sql)
        {
            DataSet results;
            adapter = new System.Data.SqlClient.SqlDataAdapter(sql, connection);

            results = new DataSet();
            adapter.Fill(results);

            return results;
        }
    }
}

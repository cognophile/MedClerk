using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MedClerk.Database
{
    class DatabaseManager
    {
        private string connectionStr;
        private SqlConnection connection;
        private SqlDataAdapter adapter;

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
            if (this.connection == null)
            {
                this.connection = new SqlConnection(this.connectionStr);
            }

            connection.Open();
        }
        
        /// <summary>
        /// Close the connection to the member variable database
        /// </summary>
        public void CloseConnection()
        {
            connection.Close();
        }

        public SqlCommand CreateCommand(string sql, SqlConnection connection)
        {
            return new SqlCommand(sql, connection);
        }

        /// <summary>
        /// Given a SQL statement, execute the query on the database
        /// </summary>
        /// <param name="sql">A string of SQL statements</param>
        /// <returns>DataSet object representing results of the query</returns>
        public DataSet ExecuteQuery(string sql)
        {
            DataSet results;
            adapter = new SqlDataAdapter(sql, connection);

            results = new DataSet();
            adapter.Fill(results);

            return results;
        }

        /// <summary>
        /// Given a SQL statement, execute the command on the database
        /// </summary>
        /// <param name="sql">A string of SQL statements</param>
        /// <returns>DataSet object representing results of the query</returns>
        public int ExecuteCommand(string sql)
        {
            using (SqlCommand cmd = new SqlCommand(sql, this.connection))
            {
                cmd.CommandType = CommandType.Text;

                var result = cmd.ExecuteNonQuery();
                return result;
            }
        }
    }
}

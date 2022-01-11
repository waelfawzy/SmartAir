//using DAL.Entities;
using Microsoft.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace BLL.Repo
{
    public   class TestQuery
    {
      
       
        public static  async Task<List<T>>  GetOracle<T>(string squery, Dictionary<string, object> para = null, int type = 0)
        {
            IConfiguration config = null;
            string connectionString = config.GetConnectionString("MainConnection");
            string command = squery;

            await using (OracleConnection conn = new OracleConnection(connectionString))
            {
                await using (OracleCommand cmd = new OracleCommand(command, conn))
                {
                    if (type == 1)
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        List<OracleParameter> orapar = new List<OracleParameter>();
                        foreach (var item in para)
                        {
                            var param = new OracleParameter();
                            param.ParameterName = item.Key;
                            param.OracleDbType = OracleDbType.Decimal;
                            param.Value = item.Value;
                            orapar.Add(param);
                        }
                        cmd.Parameters.AddRange(orapar.ToArray());
                        cmd.Parameters.Add("CURSORPARAM", OracleDbType.RefCursor, ParameterDirection.Output);
                    }
                    OracleDataReader Reader = null;
                    DataTable Data = new DataTable();
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    Reader = cmd.ExecuteReader();

                    if (Reader.HasRows)
                    {
                        Data.Load(Reader);
                    }
                   return  ConvertDataTable<T>(Data);
                }
            }
        }

        public static async Task<List<T>> GetSql<T>(string squery, Dictionary<string, object> para = null, int type = 0)
        {
            IConfiguration config = null;
            string connectionString = config.GetConnectionString("MainConnection");
            string command = squery;

            await using (SqlConnection conn = new SqlConnection(connectionString))
            {
                await using (SqlCommand  cmd = new SqlCommand(command, conn))
                {
                    if (type == 1)
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        List<SqlParameter> orapar = new List<SqlParameter>();
                        foreach (var item in para)
                        {
                            var param = new SqlParameter();
                            param.ParameterName = item.Key;
                            param.SqlDbType = SqlDbType.Decimal;
                            param.Value = item.Value;
                            orapar.Add(param);
                        }
                        cmd.Parameters.AddRange(orapar.ToArray());
                       
                    }
                    SqlDataReader  Reader = null;
                    DataTable Data = new DataTable();
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    Reader = cmd.ExecuteReader();

                    if (Reader.HasRows)
                    {
                        Data.Load(Reader);
                    }
                    return ConvertDataTable<T>(Data);
                }
            }
        }
        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }

    }
}

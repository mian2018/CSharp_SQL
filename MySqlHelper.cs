using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_SQL
{
    /// <summary>
    /// 数据库使用类
    /// </summary>
    public static class MySqlHelper
    {

        /// <summary>
        /// 1.数据库连接字符串
        /// </summary>
        public static string conStr;

        /// <summary>
        /// SQL 增 删 改
        /// </summary>
        /// <param name="sql">sql命令</param>
        /// <param name="ps">sql参数</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, params SqlParameter[] ps)
        {
            try
            {
                //2.创建连接对象  using结束后会自动释放资源
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    //3.创建执行SQL语句的对象
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    //4.编写SQL语句
                    cmd.Parameters.AddRange(ps);
                    cmd.CommandTimeout = 1;

                    //5.打开SQL连接
                    conn.Open();

                    //6.执行SQL语句
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// SQL 查询一行数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, params SqlParameter[] ps)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddRange(ps);
                    cmd.CommandTimeout = 1;
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// SQL 查询一块数据，并把数据存放在一个表中
        /// </summary>
        /// <param name="sql">命令</param>
        /// <param name="ps">参数</param>
        /// <returns>内存中的表</returns>
        public static DataTable ExecuteTable(string sql, params SqlParameter[] ps)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    adapter.SelectCommand.Parameters.AddRange(ps);
                    adapter.SelectCommand.CommandTimeout = 1;
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// SQL 查询一块数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] ps)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddRange(ps);
                cmd.CommandTimeout = 1;
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

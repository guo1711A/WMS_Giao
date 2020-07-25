using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using System.Linq;

namespace WMS_DataAccess.Hanna_DataAccess
{
    public class DALSqlHelper : IDAL
    {
        /// <summary>
        /// 使用dapper反射时连接数据库字符串
        /// </summary>
        public string con = "Data Source=192.168.43.236;Initial Catalog=WMSDB;User ID=sa;password=1234";

        #region 增删改  返回受影响行数
        /// <summary>
        /// 增删改
        /// 返回受影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int DBPost(string sql)
        {
            int flag = 0;
            using (IDbConnection connection = new SqlConnection(con) { ConnectionString = con })
            {
                flag = connection.Execute(sql);
            }
            return flag;
        }
        #endregion

        #region 返回数据库链接connection的方法
        //public IDbConnection DbConnection()
        //{
        //    using (IDbConnection connection=new SqlConnection(con) { ConnectionString=con})
        //    {
        //        return connection;
        //    }
        //}
        #endregion

        #region SQL语句查询  dapper反射获取list
        /// <summary>
        /// SQL语句查询
        /// Dapper获取List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<T> GetAllList<T>(string sql) where T : class, new()
        {
            using (IDbConnection connection = new SqlConnection(con) { ConnectionString = con })
            {
                List<T> list = connection.Query<T>(sql).ToList();
                return list;
            }
        }
        #endregion

        #region 单表查询反射显示信息
        /// <summary>
        /// 显示信息，单表查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param></param>
        /// <returns></returns>
        public List<T> GetOneList<T>() where T : class, new()
        {
            using (IDbConnection connection = new SqlConnection(con) { ConnectionString = con })
            {

                Type type = typeof(T);
                string sqls = "";
                string TableName = "";
                TableName = type.Name.Replace("Model", "");
                sqls = $"select * from {TableName}";
                //调用返回数据库链接connection的方法
                return connection.Query<T>(sqls).ToList();
            }
        }
        #endregion

    }
}
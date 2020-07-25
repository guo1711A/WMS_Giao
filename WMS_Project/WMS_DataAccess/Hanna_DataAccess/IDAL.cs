using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using WMS_Models;

namespace WMS_DataAccess.Hanna_DataAccess
{
    public interface IDAL
    {
        //增删改 返回受影响行数的方法
        int DBPost(string sql);
        //返回数据库链接的方法
        //IDbConnection DbConnection();
        //反射显示
        List<T> GetOneList<T>() where T : class, new();
        //SQL语句反射显示数据
        List<T> GetAllList<T>(string sql) where T : class, new();

    }
}

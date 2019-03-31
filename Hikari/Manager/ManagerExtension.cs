﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Hikari.Manager
{
  public static  class ManagerExtension
    {
        /// <summary>
        /// 查询数据
        /// 例如：select * from Person where id=@ID
        /// valuePairs["ID"]=1;
        /// </summary>
        /// <param name="source"></param>
        /// <param name="querySql"></param>
        /// <param name="valuePairs"></param>
        /// <returns></returns>
        public static DataSet ExecuteQuery(this ManagerPool manager,string querySql, string name=null,Dictionary<string, object> valuePairs = null)
        {
            var source= manager.GetHikariDataSource(name);
            return  source.ExecuteQuery(querySql, valuePairs);
        }

        /// <summary>
        /// 查询数据
        /// 例如：select * from Person where id=@ID
        ///  valuePairs["ID"]=1;
        /// </summary>
        /// <param name="source"></param>
        /// <param name="querySql"></param>
        /// <param name="valuePairs"></param>
        /// <returns></returns>
        public static IDataReader ExecuteQueryReader(this ManagerPool manager, string querySql,string name=null, Dictionary<string, object> valuePairs = null)
        {
            var source = manager.GetHikariDataSource(name);
            return source.ExecuteQueryReader(querySql, valuePairs);

        }

        /// <summary>
        /// 执行语句
        /// 例如：insert into Person(id,name) values(@ID,@Name)
        /// valuePairs["ID"]=1;valuePairs["Name"]="jason";
        /// </summary>
        /// <param name="source"></param>
        /// <param name="Sql"></param>
        /// <param name="valuePairs"></param>
        /// <returns></returns>
        public static int ExecuteUpdate(this ManagerPool manager, string Sql,string name, Dictionary<string, object> valuePairs = null)
        {
            var source = manager.GetHikariDataSource(name);
            return  source.ExecuteUpdate(Sql, valuePairs);
        }

        /// <summary>
        /// 执行
        /// </summary>
        /// <param name="source"></param>
        /// <param name="Sql"></param>
        /// <param name="valuePairs"></param>
        /// <returns></returns>
        public static object ExecuteScalar(this ManagerPool manager, string Sql,string name=null, Dictionary<string, object> valuePairs = null)
        {
            var source = manager.GetHikariDataSource(name);
            return source.ExecuteScalar(Sql, valuePairs);
        }

    }
}
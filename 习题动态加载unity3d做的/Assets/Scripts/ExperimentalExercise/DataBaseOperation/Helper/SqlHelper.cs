
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;


namespace fvc.exp
{
    public class SqlHelper
    {
        static string connString = _GetConnStr();

    /// <summary>
    /// 获取数据库的连接字符串
    /// </summary>
    /// <returns></returns>
    private static string _GetConnStr() {
        string path = System.Environment.CurrentDirectory + "\\config.xml";
        if (!File.Exists(path)) {
            return "";
        }
        XDocument document = XDocument.Load(path);
            //获取根元素
            XElement root = document.Root;
            //获取ConnectionString节点下的所有元素
            string connStr= root.Element("ConnectionString").Value;
           
        return connStr;
       }


    
        /// <summary>
        /// 数据库的更新操作，如：增、删、改
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="param">sql参数</param>
        /// <returns></returns>
        public static int Update(string sql,params MySqlParameter []param)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            if(param!=null&&param.Length>0){
                cmd.Parameters.AddRange(param);                               //添加参数
            }
            try
            {
                //打开数据库
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
 
                throw ex;
            }
            finally { 
                //关闭数据库
                conn.Close();
            }
            
        }
 
 
        /// <summary>
        /// 获取单一结果
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="param">sql参数</param>
        /// <returns></returns>
        public static object GetSingleResult(string sql, params MySqlParameter[] param)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            if (param != null && param.Length > 0)
            {

                cmd.Parameters.AddRange(param);                          //添加参数
            }
            try
            {
                //打开数据库
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
 
                throw ex;
            }
            finally {

                conn.Close();                           //关闭数据库
            }
            
        }
 
 
        /// <summary>
        /// 获取读取器
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static MySqlDataReader GetReader(string sql, params MySqlParameter[] param)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            if (param != null && param.Length > 0)
            {

                cmd.Parameters.AddRange(param);                              //添加参数
            }
            try
            {

                conn.Open();                                                //打开数据库
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }
 
 
 
        /// <summary>
        /// 获取数据集
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="param">sql参数</param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql, params MySqlParameter[] param)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            if(param!=null&&param.Length>0){
                cmd.Parameters.AddRange(param);
            }
            MySqlDataAdapter adaper = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                adaper.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }
 
 
       /// <summary>
        /// 数据库更新操作，如：增、删、改，通过存储过程
       /// </summary>
       /// <param name="procedureName">存储过程名称</param>
       /// <param name="param">存储过程参数</param>
       /// <returns></returns>
        public static int UpdateByProcedure(string procedureName,params MySqlParameter []param) 
        {
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            cmd.CommandType = CommandType.StoredProcedure;          //声明为存储过程

            cmd.CommandText = procedureName;                        //指明存储过程名称
            if(param!=null&&param.Length>0){

                cmd.Parameters.AddRange(param);                     //添加参数
            }
            try
            {

                conn.Open();                                        //打开数据库
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
 
                throw ex;
            }
            finally {

                conn.Close();                                       //关闭数据库
            }
            
        }
 
 
        /// <summary>
        /// 获取单一结果，通过存储过程
        /// </summary>
        /// <param name="procedureName">存储过程名称</param>
        /// <param name="param">存储过程参数</param>
        /// <returns></returns>
        public static object GetSingleResultByProcedure(string procedureName,params MySqlParameter []param)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            cmd.CommandType = CommandType.StoredProcedure;               //声明为存储过程

            cmd.CommandText = procedureName;                             //指明存储过程名称
            if (param != null && param.Length > 0)
            {

                cmd.Parameters.AddRange(param);                           //添加参数
            }
            try
            {

                conn.Open();                                              //打开数据库
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
 
                throw ex;
            }
            finally
            {

                conn.Close();                                            //关闭数据库
            }
            
        }
 
 
        /// <summary>
        /// 获取读取器，通过存储过程
        /// </summary>
        /// <param name="procedureName">存储过程名称</param>
        /// <param name="param">存储过程参数</param>
        /// <returns></returns>
        public static MySqlDataReader GetReaderByProcedure(string procedureName, params MySqlParameter[] param)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            cmd.CommandType = CommandType.StoredProcedure;                      //声明为存储过程

            cmd.CommandText = procedureName;                                    //指明存储过程名称
            if (param != null && param.Length > 0)
            {

                cmd.Parameters.AddRange(param);                                 //添加参数
            }
 
            try
            {

                conn.Open();                                                    //打开数据库
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }
 
 
        /// <summary>
        /// 获取数据集,通过存储过程
        /// </summary>
        /// <param name="procedureName">存储过程名称</param>
        /// <param name="param">存储过程参数</param>
        /// <returns></returns>
        public static DataSet GetDataSetByProcedure(string procedureName, params MySqlParameter[] param)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procedureName;
            if (param != null && param.Length > 0)
            {
                cmd.Parameters.AddRange(param);
            }
            MySqlDataAdapter adaper = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                adaper.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
 
                throw ex;
            }
 
        }
 
 
 
        /// <summary>
        /// 通过事务的方式执行批量sql语句
        /// </summary>
        /// <param name="sqlList">要执行的批量sql语句</param>
        /// <param name="param">sql参数</param>
        /// <returns></returns>
        public static int UpdateByTransaction(string []sqlList,params MySqlParameter []param) 
        {
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            if(param!=null&&param.Length>0){
                cmd.Parameters.AddRange(param);
            }
     
            try
            {

                conn.Open();                                    //打开数据库
               
                cmd.Transaction=conn.BeginTransaction();        //开启事务
                int executeResult = 0;

                foreach (string sql in sqlList)                 //遍历执行sql语句
                {
                    cmd.CommandText = sql;
                    executeResult += cmd.ExecuteNonQuery();
                }

                cmd.Transaction.Commit();                       //都执行成功，则提交事务
                return executeResult;
            }
            catch (Exception ex)
            {
                
                if(cmd.Transaction!=null){                      //回滚事务
                    cmd.Transaction.Rollback();
                }
                throw ex;
            }
            finally { 
                
                if(cmd.Transaction!=null){                      //清空事务
                    cmd.Transaction = null;
                }

                conn.Close();                                   //关闭数据库
            }
           
           
        }
        
        
        
                                                                        
        
        /// <summary>
        /// 数据库连接测试
        /// </summary>
        /// <returns></returns>
        public static int DataBaseLinkTest() 
        {
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                return 1;
            }
            catch (Exception)
            {
 
                return -1;
            }
            finally {
                conn.Close();
            }
           
        }  
    }
}

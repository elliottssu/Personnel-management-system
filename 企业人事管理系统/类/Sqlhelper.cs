using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace 企业人事管理系统
{
    class Sqlhelper
    {
        SqlConnection conn;
        SqlCommand sqlCom;
        SqlDataAdapter sqlAdl;
        SqlDataReader dr;
        DataSet ds = new DataSet();
        public Sqlhelper(string strcon)
        {

            conn = new SqlConnection(strcon);
            sqlCom = new SqlCommand();
            sqlCom.Connection = conn;
        }
        public Sqlhelper(string strcon, string comtext)
        {
            conn = new SqlConnection(strcon);
            sqlCom = new SqlCommand(comtext, conn);
            sqlAdl = new SqlDataAdapter(sqlCom);




        }
        public  void Open()
        {
            try
            {
                if (conn != null && conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //查找指定表中是否有记录。
        public bool findname(string comtext)
        {
            sqlCom.CommandText = comtext;
            Open();
            dr = sqlCom.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Close();
                conn.Close();
                return true;
            }
            else
            {
                dr.Close();
                conn.Close();
                return false;
            }
        }
        public string  finduser(string comtext)
        {
            sqlCom.CommandText = comtext;
            Open();
            dr = sqlCom.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                conn.Close();
                return dr.GetString(5);
            }
            else
            {
                dr.Close();
                conn.Close();
                return null ;
            }
        }

     
      
         
        //可用于向指定表进行增删改的操作
        public bool ExecuteNoQuery(string comtext)
        {
            sqlCom.CommandText = comtext;
            Open();
            try
            {
                sqlCom.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        //返回Dateset对象
        public  DataSet   GetDataSet(string sql, string tablename)
        {
           
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds, tablename);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                conn.Close();
                da.Dispose();
            }
            return ds ;
        }

        //返回DataReader对象
        public SqlDataReader GetReader(string sql)
        {

            SqlCommand com = new SqlCommand(sql, conn);
            SqlDataReader dr = null;
            try
            {
                conn.Open();
                dr = com.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                dr.Close();
                com.Dispose();
                throw new Exception(ex.ToString());
            }
           
            return dr;
        }
    }
}





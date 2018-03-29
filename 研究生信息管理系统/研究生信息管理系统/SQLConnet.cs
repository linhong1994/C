using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace 研究生信息管理系统
{
    class SQLConnet
    {
        string connectString = "Data Source=.;Initial Catalog=150603047;Integrated Security=True";//连接字符串
        SqlConnection sqlCnt;//命名SqlConnection对象
        public SQLConnet()
        {

            sqlCnt = new SqlConnection(connectString);//实例化SqlConnection对象
            sqlCnt.Open();//打开连接
        }
        public void close()
        {
            sqlCnt.Close();             // 关闭数据库连接
            sqlCnt.Dispose();           // 释放数据库连接对象
        }


        //执行一段sql语句
        public void runsql(string sql)
        {
            SqlCommand cmd = sqlCnt.CreateCommand();              //创建SqlCommand对象
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;   //sql语句
            cmd.ExecuteNonQuery();
        }

        //判断数据存在否
        public bool checkit(string sql)
        {
            SqlCommand cmd = sqlCnt.CreateCommand();              //创建SqlCommand对象
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;   //sql语句
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cmd.Dispose();//释放
                reader.Close();//关闭
                return true;
            }
            else
            {
                cmd.Dispose();//释放
                reader.Close();//关闭
                return false;
            }
        }
        //读取一个字段
        public string readone(string sql, string field)
        {
            SqlCommand cmd = sqlCnt.CreateCommand();              //创建SqlCommand对象
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;   //sql语句
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string result = reader[field].ToString();
                cmd.Dispose();//释放
                reader.Close();//关闭
                return result;
            }
            else
            {
                cmd.Dispose();//释放
                reader.Close();//关闭
                return null;
            }
        }


        //读取一行
        public SqlDataReader readrow(string sql)//调用完用close关闭SqlDataReader
        {
            SqlCommand cmd = sqlCnt.CreateCommand();              //创建SqlCommand对象
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;   //sql语句
            SqlDataReader reader = cmd.ExecuteReader();
            cmd.Dispose();//释放
            return reader;
            

        }

        //添加一行
        public void addrow(string sql, string form, ArrayList filed, ArrayList fdata)
        {
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, sqlCnt);
            DataSet myDataSet = new DataSet();
            myDataAdapter.Fill(myDataSet, form);
            DataTable myTable = myDataSet.Tables[form];

            // 添加一行
            DataRow myRow = myTable.NewRow();
            for (int i = 0; filed.Count > i; i++)
            {

                if (fdata[i].GetType().ToString() == "System.Int32" || fdata[i].GetType().ToString() == "System.Boolean")//判断是否为int
                {
                    myRow[filed[i].ToString()] = Convert.ToInt32(fdata[i]);
                }
                else if (fdata[i].GetType().ToString() == "System.DateTime")
                {
                    myRow[filed[i].ToString()] = Convert.ToDateTime(fdata[i]);
                }
                else//当做string处理
                {
                    myRow[filed[i].ToString()] = fdata[i].ToString();
                }
            }
            //myRow["id"] = 100; id若为“自动增长”，此处可以不设置，即便设置也无效
            myTable.Rows.Add(myRow);

            // 将DataSet的修改提交至“数据库”
            SqlCommandBuilder mySqlCommandBuilder = new SqlCommandBuilder(myDataAdapter);
            myDataAdapter.Update(myDataSet, form);

            myDataSet.Dispose();        // 释放DataSet对象
            myDataAdapter.Dispose();    // 释放SqlDataAdapter对象
            myTable.Dispose();
            mySqlCommandBuilder.Dispose();

        }


        //获取datatable
        public DataTable getdatatable(string sql,string form)
        {
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, sqlCnt);
            DataSet myDataSet = new DataSet();
            myDataAdapter.Fill(myDataSet, form);
            DataTable datatable = myDataSet.Tables[form];
            myDataSet.Dispose();        // 释放DataSet对象
            myDataAdapter.Dispose();    // 释放SqlDataAdapter对象
            return datatable;
        }

        public void setdatatable(DataTable datatable, string sql,string form)
        {
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, sqlCnt);
            // 将DataSet的修改提交至“数据库”
            SqlCommandBuilder mySqlCommandBuilder = new SqlCommandBuilder(myDataAdapter);
            myDataAdapter.Update(datatable);
            myDataAdapter.Dispose();    // 释放SqlDataAdapter对象
            mySqlCommandBuilder.Dispose();
        }

    }
}

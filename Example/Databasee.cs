﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace Example
{
    public class Database
    {
        private string connectionString = @"Data Source=ADMIN\MANTRUONG;Initial Catalog=QLSV;User ID=sa; Password=1112004";
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;

        public Database()
        {
            try
            {
                conn = new SqlConnection(connectionString);  // Khởi tạo SqlConnection
                conn.Open();  // Mở kết nối
                Console.WriteLine("Connection successful!");  // Thông báo thành công
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection failed: " + ex.Message);  // Thông báo lỗi
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();  // Đóng kết nối nếu đang mở
                }
            }
        }

        public DataTable SelectData(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var para in lstPara)
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }    
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi load dữ liệu: " + ex.Message);
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();  // Đảm bảo đóng kết nối sau khi thực hiện xong
                }
            }
        }
        public DataRow Select(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Lỗi load thông tin chi tiết: "+ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public int ExeCute(string sql, List<CustomParameter>lstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql,conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var p in lstPara)
                   {
                        cmd.Parameters.AddWithValue(p.key, p.value);
                    }   
                var rs = cmd.ExecuteNonQuery();
                return (int)rs;
            }
            catch( Exception ex )
            {
                MessageBox.Show("Lỗi thực thi câu lệnh: " + ex.Message);
                return -100;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

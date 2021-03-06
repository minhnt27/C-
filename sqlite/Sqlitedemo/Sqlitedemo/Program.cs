﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
//using System.Data.SqlClient;

namespace Sqlitedemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://o7planning.org/vi/10515/huong-dan-lam-viec-voi-database-sql-server-su-dung-csharp

            //string datasource = @"127.0.0.1\SQLEXPRESS";
            //string database = "";
            //string username = "sa";
            //string password = "123456a@";
            //string connString = @"Data Source=" + datasource + ";Initial Catalog="+ database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            string connString = @"URI=file:E:\Lab\Demo\sqlite\db\sqlite\testDB.db";

            SQLiteConnection conn = new SQLiteConnection(connString);

            // =======Solution 1:
            /*    
            // Tạo một đối tượng Command từ đối tượng Connection.
                SqlCommand cmd = conn.CreateCommand();
            // Set Command Text
                String sql = "";
                cmd.CommandText = sql;
            */
            
            // =======Solution 2:
            /*
            // Tạo đối tượng Command.
                String sql = "";
                SqlCommand cmd = new SqlCommand(sql);
            // Liên hợp Connection với Command.
                cmd.Connection = conn;
            */

            // =======Solution 3:
            /*
            // Tạo một đối tượng Command với 2 tham số: Command Text & Connection.
                String sql="";
                SqlCommand cmd = new SqlCommand(sql, conn);
            */

            conn.Open();

            try
            {
                //using solution 1
                SQLiteCommand cmd = new SQLiteCommand(conn);

                cmd.CommandText = "DROP TABLE IF EXISTS AcsPin";
                cmd.ExecuteNonQuery();

                cmd.CommandText = @"CREATE TABLE AcsPin(id INTEGER PRIMARY KEY, teamid INT, checkin TEXT, checkout TEXT, pin TEXT, asign TEXT, stat TEXT)";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO AcsPin(teamid, checkin, checkout, pin, asign, stat) VALUES(2, '12/5/2020 14:00:00', '12/5/2020 16:00:00', '224466', 'Nhungld', 'pass')";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO AcsPin(teamid, checkin, checkout, pin, asign, stat) VALUES(3, '12/5/2020 16:00:00', '12/5/2020 18:00:00', '664422', 'minhnt27', 'next')";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO AcsPin(teamid, checkin, checkout, pin, asign, stat) VALUES(4, '12/5/2020 14:00:00', '12/5/2020 16:00:00', '224466', 'Nhungld', 'pass')";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO AcsPin(teamid, checkin, checkout, pin, asign, stat) VALUES(3, '12/5/2020 16:00:00', '12/5/2020 18:00:00', '664422', 'minhnt27', 'next')";
                cmd.ExecuteNonQuery();

                Console.WriteLine("Table AcsPin is ready");

                //using solution 3
                string stm = "SELECT * FROM AcsPin LIMIT 5";
                SQLiteCommand cmd2 = new SQLiteCommand(stm, conn);

                SQLiteDataReader rdr = cmd2.ExecuteReader();

                Console.WriteLine($"{rdr.GetName(0),-3} {rdr.GetName(1),-8} {rdr.GetName(2),-20} {rdr.GetName(3),-20} {rdr.GetName(4),-8} {rdr.GetName(5),-8} {rdr.GetName(6),-8}");
                while (rdr.Read())
                {
                    Console.WriteLine($"{rdr.GetInt32(0),-3} {rdr.GetInt32(1),-8} {rdr.GetString(2),-20} {rdr.GetString(3),-20} {rdr.GetString(4),-8} {rdr.GetString(5),-8} {rdr.GetString(6),-8}");
                }

                //Là đối tượng của Interface IDispose, Gọi phương thức để tiêu hủy đối tượng, Giải phóng tài nguyên
                rdr.Dispose();

            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                // Đóng kết nối.
                conn.Close();
                // Hủy đối tượng, giải phóng tài nguyên.
                conn.Dispose();
            }
            

            


        }
    }
}

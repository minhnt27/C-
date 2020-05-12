using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Sqlitedemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = @"URI=file:E:\Lab\Demo\sqlite\db\sqlite\testDB.db";

            SQLiteConnection con = new SQLiteConnection(cs);
            con.Open();

            SQLiteCommand cmd = new SQLiteCommand(con);

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

            string stm = "SELECT * FROM AcsPin LIMIT 5";

            SQLiteCommand qry = new SQLiteCommand(stm, con);
            SQLiteDataReader rdr = qry.ExecuteReader();

            Console.WriteLine($"{rdr.GetName(0),-3} {rdr.GetName(1),-8} {rdr.GetName(2),-20} {rdr.GetName(3),-20} {rdr.GetName(4),-8} {rdr.GetName(5),-8} {rdr.GetName(6),-8}");
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr.GetInt32(0),-3} {rdr.GetInt32(1),-8} {rdr.GetString(2),-20} {rdr.GetString(3),-20} {rdr.GetString(4),-8} {rdr.GetString(5),-8} {rdr.GetString(6),-8}");
            }
        }
    }
}

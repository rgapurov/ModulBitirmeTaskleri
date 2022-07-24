using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankamatik
{
    public class methods
    {

        public void DBOlustur()
        {
            try
            {
                string cmdString = "Create Database rustam";
                string server = System.Environment.MachineName;
                SqlConnection con = new SqlConnection("server=" + server + "\\SQLEXPRESS; Initial Catalog=master; Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = cmdString;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch { }
            
            
        }
        public void TabloOluştur()
        {
            try
            {
                string server = System.Environment.MachineName;
                SqlConnection con = new SqlConnection("server=" + server + "\\SQLEXPRESS; Initial Catalog=rustam; Integrated Security=True");
                SqlCommand cmd = new SqlCommand();
                string cmdString = "create table accounts"
                          + "(accountID int primary key identity," +
                            "accountTC int," +
                            "accountName varchar(30)," +
                            "accountPassword int," +
                            "accountAmount int)" +
                            "create table transactions" +
                            "(trID int primary key identity," +
                            "trDate datetime," +
                            "trType varchar(50)," +
                            "trAccount int," +
                            "trAmount int)";

                cmd.Connection=con;
                cmd.CommandText = cmdString;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            catch { }    
        }
        public bool KullanıcıKontrol(string user, string pass)
        {
            SqlConnection con = new SqlConnection("server=" + System.Environment.MachineName + "\\SQLEXPRESS; Initial Catalog = rustam; Integrated Security = True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Count (*) from accounts where accountTC = @user and accountPassword = @pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            con.Open();
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            if (result == 0) { return false; }
            else { return true; }
        }
    } 
    public class renkler
    {
        public static Color pembeFocus = Color.FromArgb(238, 118, 165);
        public static Color maviUnFocus = Color.FromArgb(94, 133, 163);
    }
}

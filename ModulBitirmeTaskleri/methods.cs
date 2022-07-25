using LinqToDB.Data;
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
        public bool KullanıcıOlustur(int tc, string ad, int pass, int bakiye)
        {
            try
            {
                SqlConnection con = new SqlConnection("server=" + System.Environment.MachineName + "\\SQLEXPRESS; Initial Catalog = rustam; Integrated Security = True");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into accounts values (" + tc.ToString() + ", '" + ad + "'," + pass.ToString() + ", " + bakiye.ToString() + ")";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch { return false; }
        }
        public string IsimGetir(int tc)
        {
            SqlConnection con = new SqlConnection("server=" + System.Environment.MachineName + "\\SQLEXPRESS; Initial Catalog = rustam; Integrated Security = True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select accountName from accounts where accountTC = @tc";
            cmd.Parameters.AddWithValue("@tc", tc);
            con.Open();
            string ad = Convert.ToString(cmd.ExecuteScalar());
            con.Close();
            return ad;
        }
        public int BakiyeGetir(int tc)
        {
            SqlConnection con = new SqlConnection("server=" + System.Environment.MachineName + "\\SQLEXPRESS; Initial Catalog = rustam; Integrated Security = True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select accountAmount from accounts where accountTC = @tc";
            cmd.Parameters.AddWithValue("@tc", tc);
            con.Open();
            int bakiye = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return bakiye;
        }
        public void ParaCek(int tc, int miktar)
        {
            // para çekilme işlemi
            SqlConnection con = new SqlConnection("server=" + System.Environment.MachineName + "\\SQLEXPRESS; Initial Catalog=rustam; Integrated Security=True") ;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update accounts set accountAmount = accountAmount - @miktar where accountTC = @tc";
            cmd.Parameters.AddWithValue("@tc", tc);
            cmd.Parameters.AddWithValue("@miktar", miktar);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            // hesap özetine ekleme
            cmd.CommandText = "insert into transactions values(@date, '@type', @hesap, @tutar)";
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.Parameters.AddWithValue("@Type", "Para Çekme");
            cmd.Parameters.AddWithValue("@hesap", tc);
            cmd.Parameters.AddWithValue("@tutar", -miktar);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void ParaYatir(int tc, int miktar)
        {
            // para yatırma işlemi
            SqlConnection con = new SqlConnection("server=" + System.Environment.MachineName + "\\SQLEXPRESS; Initial Catalog=rustam; Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update accounts set accountAmount = accountAmount + @miktar where accountTC = @tc";
            cmd.Parameters.AddWithValue("@tc", tc);
            cmd.Parameters.AddWithValue("@miktar", miktar);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            // hesap özetine ekleme
            cmd.CommandText = "insert into transactions values(@date, '@type', @hesap, @tutar)";
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.Parameters.AddWithValue("@Type", "Para Yatırma");
            cmd.Parameters.AddWithValue("@hesap", tc);
            cmd.Parameters.AddWithValue("@tutar", miktar);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    } 
    public class renkler
    {
        public static Color pembeFocus = Color.FromArgb(238, 118, 165);
        public static Color maviUnFocus = Color.FromArgb(94, 133, 163);
        public static Color maviYazi = Color.FromArgb(34, 87, 126);
    }
}

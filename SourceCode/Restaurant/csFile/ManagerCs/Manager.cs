using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2;

namespace Restaurant.ManagerCs
{
    class Manager
    {
        MY_DB mydb = new MY_DB();

        public bool addManager(string fname, string lname, string username, string password, DateTime bDate ,string phone, string address, MemoryStream picture)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO manager (fname, lname, username, bdate ,password, picture, phone, address) VALUES (@fname, @lname, @username, @bdate, @password, @picture, @phone, @address)", mydb.getConnection);

            cmd.Parameters.Add("@fname", System.Data.SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@lname", System.Data.SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@username", System.Data.SqlDbType.NVarChar).Value = username;
            cmd.Parameters.Add("@bdate", System.Data.SqlDbType.DateTime).Value = bDate;
            cmd.Parameters.Add("@phone", System.Data.SqlDbType.NVarChar).Value = phone;
            cmd.Parameters.Add("@address", System.Data.SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@password", System.Data.SqlDbType.NVarChar).Value = password;
            cmd.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool checkExis(string username)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM manager WHERE username=@username", mydb.getConnection);
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            mydb.openConnection();

            if(table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return false;

            } else {
                mydb.closeConnection();
                return true;

            }
        }
    }
}

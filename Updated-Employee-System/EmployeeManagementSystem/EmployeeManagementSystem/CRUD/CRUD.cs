using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace EmployeeManagementSystem.CRUD
{
    public static class CRUD
    {
        public static OleDbConnection con = connection.mysqldb();
        public static OleDbCommand cmd = new OleDbCommand();
        public static OleDbDataAdapter da = new OleDbDataAdapter();
        public static DataTable dt = new DataTable();
        public static DataSet ds = new DataSet();
        public static int resultSQL;
        public static Image getIMG = null;

        public static bool RETRIEVESINGLE(string SQL)
        {
            con.Open();
            cmd = new OleDbCommand(SQL, con);
            da = new OleDbDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();

            return dt.Rows.Count > 0;
        }

        public static bool RETRIEVESINGLELOGIN(string username, string password)
        {
            dt = new DataTable();

            using (OleDbConnection con = connection.mysqldb())
            {
                string sql = "SELECT [FullName], [Section], [Age] FROM Users WHERE [Username]=@user AND [Password]=@pass";
                using (OleDbCommand cmd = new OleDbCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt.Rows.Count > 0;
        }


        public static bool RETRIEVEDTG(DataGridView DTG, string SQL)
        {
            con.Open();
                cmd = new OleDbCommand();
            { 
                    var withBlock = cmd;
                    withBlock.Connection = con;
                    withBlock.CommandText = SQL;
               }
            da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            {
                var withBlock = DTG;
                withBlock.DataSource = dt;
            }
        if (dt.Rows.Count > 0)
        {
                con.Close();
                return true;

        }
        else
        {
                con.Close();
                return false;
        }
        }


        //public static bool RETRIEVECBO(ComboBox cbo, string SQL, string displayMember, string valueMember)
        //{
        //    con.Open();
        //    cmd = new OleDbCommand();
        //    {
        //        var withBlock = cmd;
        //        withBlock.Connection = con;
        //        withBlock.CommandText = SQL;
        //    }

        //    da = new OleDbDataAdapter();
        //    da.SelectCommand = cmd;
        //    dt = new DataTable();
        //    da.Fill(dt);

        //    {
        //        var withBlock = cbo;
        //        withBlock.DataSource = dt;
        //        withBlock.DisplayMember = displayMember; // Column to show in ComboBox
        //        withBlock.ValueMember = valueMember;     // Column to use as value
        //    }

        //    con.Close();

        //    return dt.Rows.Count > 0;
        //}

        public static bool CUD(string sql)
        { con.Open();
            {
                var withBlock = cmd;
                withBlock.Connection = con;
                withBlock.CommandText = sql;
                resultSQL = cmd.ExecuteNonQuery();
            }
            if (resultSQL > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
            con.Close();
        }

    }
}

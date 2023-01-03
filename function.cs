using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TJ_Lanka_PLC_PLM
{
    internal class function
    {
        protected SqlConnection getConnection()
        {
            //this is the connection for the database
            SqlConnection con = new SqlConnection();
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\kavindud\Pictures\Back up projects\TJ Lanka PLC PLM\MarketingDB.mdf"";Integrated Security=True");
            return con;

        }
        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Processed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}


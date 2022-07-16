using System.Data;
using System.Data.SqlClient;

namespace courseworkAD1
{
    public class dbConnection
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8GJF5BA\SQLEXPRESS;Initial Catalog=eShift;Integrated Security=True");

        public void createAndUpdate(string cmd)
        {
            con.Open();
            SqlCommand command = new SqlCommand(cmd, con);
            // updated the db with the lates data
            command.ExecuteNonQuery();
            con.Close();
        }

        public SqlDataAdapter readData(string cmd, DataTable dt)
        {
            //DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(cmd, con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            return adapter;
        }

        public SqlDataReader readRecord(string cmd)
        {
            con.Open();

            //DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand(cmd, con);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            return sqlDataReader;
        }

        public void deleteData(string cmd)
        {
            con.Open();
            SqlCommand command = new SqlCommand(cmd, con);
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}

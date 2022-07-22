using System.Data;
using System.Data.SqlClient;

namespace courseworkAD1
{
    public class dbConnection
    {
        // connection string
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8GJF5BA\SQLEXPRESS;Initial Catalog=eShift;Integrated Security=True");

        public void createAndUpdate(string cmd)
        {
         // open the connection
            con.Open();
            SqlCommand command = new SqlCommand(cmd, con);
            // updated the db with the lates data
            command.ExecuteNonQuery();
            // close the connection
            con.Close();
        }

        // read data from the db and return
        public SqlDataAdapter readData(string cmd, DataTable dt)
        {
            SqlCommand command = new SqlCommand(cmd, con);
            con.Open();
            // create an instance of sqldataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            con.Close();
            return adapter;
        }

        
        public SqlDataReader readRecord(string cmd)
        {
            con.Open();
            SqlCommand command = new SqlCommand(cmd, con);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            con.Close();
            return sqlDataReader;
        }
        // delete data
        public void deleteData(string cmd)
        {
            con.Open();
            SqlCommand command = new SqlCommand(cmd, con);
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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
    }
}

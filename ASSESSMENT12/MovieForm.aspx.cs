using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MovieApp2
{
    public partial class MovieForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // step 1 : establishing the connection 
            string connString = "Data Source=LAPTOP-3OO5TQVG\\SQLEXPRESS;Initial Catalog=MOVIE_DB;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);

            // step 2 : Open the connection 
            conn.Open();

            // step 3 : Execute the insert query 
            string query1 = "INSERT INTO MOVIE_TABLE VALUES(@MOVIE_ID, @MOVIE_NAME," +
                "@NO_TICKET, @THEATOR_NAME, @EMAIL_ID, @PHONE_NO)";
            SqlCommand insertCmd = new SqlCommand(query1, conn);

            insertCmd.Parameters.AddWithValue("@MOVIE_ID", TextBox1.Text);
            insertCmd.Parameters.AddWithValue("@MOVIE_NAME", TextBox2.Text);
            insertCmd.Parameters.AddWithValue("@NO_TICKET", TextBox3.Text);
            insertCmd.Parameters.AddWithValue("@THEATOR_NAME", TextBox4.Text);
            insertCmd.Parameters.AddWithValue("@EMAIL_ID", TextBox5.Text);
            insertCmd.Parameters.AddWithValue("@PHONE_NO", TextBox6.Text);

            insertCmd.ExecuteNonQuery();

            // step 4: close the connection 
            conn.Close();

            // output : 
            Response.Write("MOVIE DETAILS ARE INSERTED TO THE DB");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookApplication
{
    public partial class BookForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Establishing the connection between the Database and the code
            string connString = "Data Source=LAPTOP-3OO5TQVG\\SQLEXPRESS;Initial Catalog=BOOK_DB;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connString);

            // open the connection
            conn.Open();

            // executing the query 
            string query = "INSERT INTO BOOK_DETAILS(BOOKID,BOOKNAME,AuthorName,Publisher,YearOfPublication,Quantity) VALUES " +
                "(@BookId, @BookName, @AuthorName, @Publisher, @YearOfPublication, @Quantity)";
            SqlCommand insertCommand = new SqlCommand(query, conn);

            insertCommand.Parameters.AddWithValue("@BookId", TextBox1.Text);
            insertCommand.Parameters.AddWithValue("@BookName", TextBox2.Text);
            insertCommand.Parameters.AddWithValue("@AuthorName", TextBox3.Text);
            insertCommand.Parameters.AddWithValue("@Publisher", TextBox4.Text);
            insertCommand.Parameters.AddWithValue("@YearOfPublication", TextBox5.Text);
            insertCommand.Parameters.AddWithValue("@Quantity", TextBox6.Text);

            insertCommand.ExecuteNonQuery();


            // closing the connection
            conn.Close();

            Response.Write(TextBox1.Text + " Book Details are inserted Sucessfully");


        }
    }
}
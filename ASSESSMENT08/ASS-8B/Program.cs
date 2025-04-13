using System;
using System.Data.SqlClient;

class Programe {
    static void Main(string[] args){
         string connString = "Server=localhost,1433;Database=MYDB;User ID=SA;Password=MyPassword#321;Encrypt=True;TrustServerCertificate=True;";
        try {
        // step 1: establish connection : to sqlDatabase 
        SqlConnection conn = new SqlConnection(connString);

        // step 2: open Connection 
        conn.Open();

        // step 3: Update/Delete/Insertion command 
        // Q2: Update the DocName as “Dr. SeethaRam” for DocId = 5001
        string query2 = "UPDATE DOCTOR_INFO SET DOCTOR_NAME='Dr SeethaRam' WHERE DOCTOR_ID=5001";
        SqlCommand cmd2  = new SqlCommand(query2, conn);
        cmd2.ExecuteNonQuery();
        Console.WriteLine("Updation of Table has been done..");

        // Q3: Delete the row of DocId = 5005
        string query3 = "DELETE FROM DOCTOR_INFO WHERE DOCTOR_ID = 5005";
        SqlCommand cmd3  = new SqlCommand(query3, conn);
        cmd3.ExecuteNonQuery();
        Console.WriteLine("Deletion of Table has been done..");

        // Q4: Insert a new row to the table as follows: DocID = 5006, DocName = “Dr. Harish”,Specialization = “Neurologist”
        string query4 = "INSERT INTO DOCTOR_INFO VALUES (5006, 'Dr Harish', 'Neurologist')";
        SqlCommand cmd4  = new SqlCommand(query4, conn);
        cmd4.ExecuteNonQuery();
        Console.WriteLine("Insertion of Table has been done..");

        // step 4 : Select command using datareader
        // Q1: Display “Doctors” table using a Data reader
        string query1 = "SELECT * FROM DOCTOR_INFO";
        SqlCommand cmd1 = new SqlCommand(query1, conn);
        SqlDataReader reader = cmd1.ExecuteReader(); 

        while(reader.Read()){
            Console.WriteLine($"{reader[0]}  {reader[1]}  {reader[2]}");
        }
        // close : reader 
        reader.Close();

        // step 5: close the connection 
        conn.Close();
        }
        catch(Exception e){
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
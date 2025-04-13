using System;
using System.Data.SqlClient;

class Programme {
    static void Main(string[] args){

        try {
        // step 1 : Connecting the database to the programme 
        string connString = "Server=localhost,1433;Database=MYDB;User ID=SA;Password=MyPassword#321;Encrypt=True;TrustServerCertificate=True;";
        SqlConnection  conn = new SqlConnection(connString);

        // 2. Open the connection 
        conn.Open();

        // 3. update / delete / insert / create commands 

        // Create :  a Employee table 
        string query1 = "CREATE TABLE EMPLOYEE(emp_id INT PRIMARY KEY, emp_name VARCHAR(20), emp_salary INT)";
        SqlCommand cmd1 = new SqlCommand(query1, conn);
        cmd1.ExecuteNonQuery();

        // Inserting : some values into the employee table 
        string query2 = "INSERT INTO EMPLOYEE VALUES (1001,'Kiran MP',25000),(1002,'Girish',24000),(1003,'Madhu P',8900)";
        SqlCommand cmd2 = new SqlCommand(query2, conn);
        cmd2.ExecuteNonQuery();

        // 4. Data Reader : select & view the records of the database 
        string query3 = "SELECT * FROM EMPLOYEE";
        SqlCommand cmd3 = new SqlCommand(query3, conn);
        SqlDataReader reader = cmd3.ExecuteReader();

        Console.WriteLine($"Employee ID\tEMPLOYEE NAME\tEMPLOYEE SALARY");
        while(reader.Read()){
            Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");
        }
        // step 5: closing the reader
        reader.Close();

        // step 6: close the connection 
        conn.Close();
        }
        catch(Exception e){
            Console.WriteLine($"Error Occurs : {e.Message}");
        }
    }
}
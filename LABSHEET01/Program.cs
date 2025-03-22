/* 
LABSHEET 01
info : University wants to store the student details.
Read the user inputs using console. 
input : Get the student details such as Roll number, fname, lname, Semester, Specialization
output : display all details.
*/
namespace LABSHEET01 {
    class BasicConsoleApp {
        static void Main(string[] args){
            // inputs from user 
            Console.Write("Enter your RollNo: "); // roll number 
            int RollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your First Name: ");
            string FirstName = Console.ReadLine();
            Console.Write("Enter your Second Name: ");
            string LastName = Console.ReadLine();
            Console.Write("Enter your Semister: ");
            int Semister = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Specialisation: ");
            string Specialisation = Console.ReadLine();

            // print the student information 
            Console.WriteLine("Student Information: ");
            Console.WriteLine($"Enter the student RollNo: {RollNo}");
            Console.WriteLine($"Student First Name: {FirstName}");
            Console.WriteLine($"Student Last Name: {LastName}");
            Console.WriteLine($"Student Semister: {Semister}");
            Console.WriteLine($"Student Specialisation: {Specialisation}");
        }
    }
}
/* 
Assessment 01
info: XYZ company stores employee details such as 
input : empno, empname, designation.
output : display all details
*/
class EmployeeDetails {
    static void Main(string[] args){
        // inputs : empno, empname, designation 
        Console.Write("Enter your Number: ");
        int EmpNo = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your Name: ");
        string EmpName = Console.ReadLine();
        Console.Write("Enter your Designition: ");
        string Designition = Console.ReadLine();

        // print: outputs
        Console.WriteLine("\n\nEmployee Information");
        Console.WriteLine($"Employee Number: {EmpNo}");
        Console.WriteLine($"Employee Name: {EmpName}");
        Console.WriteLine($"Employee Designition: {Designition}");
    }
}
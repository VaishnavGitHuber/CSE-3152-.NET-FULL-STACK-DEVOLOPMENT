/* 
Assessment 01 B 
info : Calculate the total salary of an employee using console application. 
input : Provide the Basic salary input using console. (15% of basic is HRA and 30% of basic is DA)
ouput : print output salary 
Hint: Total Salary = Basic + HRA + DA
*/

class EmployeeSalary {
    static void Main(string[] args) {
        // input: basic salary 
        Console.Write("Enter your basic Salary: ");
        double BasicSalary = Convert.ToDouble(Console.ReadLine());

        // Calculating : HRA & DA
        double HRA = AmountConverter(BasicSalary, 0.15F);
        double DA = AmountConverter(BasicSalary, 0.30F);

        // Calculating : total salary
        int TotalSalary = (int)(BasicSalary + HRA + DA);

        // print: output 
        Console.WriteLine($"Total Salary: {TotalSalary}");

    }

    // function : generate amount based on percentage 
    static double AmountConverter(double Amount, float Percentage){
        return (double)(Amount * Percentage);
    }
}
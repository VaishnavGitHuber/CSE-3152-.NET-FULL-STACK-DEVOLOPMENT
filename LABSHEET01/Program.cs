/* Labsheet 01: claculate the total salary of the employee 
 provide the basic salary input using the console,
 - 15% of basic is HRA
 - 30% of basic is DA 
 Hint: TS = BS + HRA + DA
 */

// Information : calaculate the salary of the employee(ie, BS + HRA + DA)
// input: basic salary of the employee 
// output: total salary of the employee 

// input from the user 
Console.Write("Enter the Salary: ");
double BasicSalary = Convert.ToDouble(Console.ReadLine());

// calculations 
double HRA = 0.15 * BasicSalary;
double DA = 0.3 * BasicSalary;
double TotalSalary = BasicSalary + HRA + DA;

// output 
Console.WriteLine($"Total Salary of the employee: {TotalSalary}");
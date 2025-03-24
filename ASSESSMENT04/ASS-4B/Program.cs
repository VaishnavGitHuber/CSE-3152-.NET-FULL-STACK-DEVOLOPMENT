/* 
Create a class called Employee with id and salary. 
Employee class is inheriting from Human class. 
Name and age should be defined in Human class. 
Include display method in Employee class to display all details.
*/
namespace Assaignment4b {
public class Human {
    public string Name = "Vaishnav Krishna P";
    public int Age = 21;
}

class Employee : Human {
    public string EmpId = "EMP1967";
    public double Salary = 1250000;

    public void DisplayInfo(){
        Console.WriteLine($"Enployee Name: {this.Name} & Age: {this.Age}");
        Console.WriteLine($"Employee Salary: {this.Salary} & Employee ID: {this.EmpId}");
    }
    
}

class Programme {
    public static void Main(string[] args){
        Employee emp1 = new Employee();
        emp1.DisplayInfo();
    }
}

}
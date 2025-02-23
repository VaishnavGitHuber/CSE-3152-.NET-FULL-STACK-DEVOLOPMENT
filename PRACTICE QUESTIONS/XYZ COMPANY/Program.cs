/* 
info : xyz company want to store the employee information such as empno,empname, designation,salary
input : emp name, emp no, designation, salary 
output: display using class- object 
*/
class Programe {
    public static void Main(string[] args){
        XYZ emp1 = new XYZ(1001, "Vaishnav Krishna P", "HR", 120000);
    }
}
class XYZ {
    string employeeName,designation;
    int employeeNumber;
    double salary;

    public XYZ(int empNo, string empName, string desig, double salary){
        this.employeeNumber = empNo;
        this.employeeName = empName;
        this.designation = desig;
        this.salary = salary;
        displayInfo();
    }

    public void displayInfo(){
        Console.WriteLine($"Employee Number: {employeeNumber}\nEmployee Name: {employeeName}\nEmployee designition: {designation}\nSalary: {salary}");
    }
}
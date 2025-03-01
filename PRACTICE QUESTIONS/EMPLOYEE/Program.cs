class Programe{
    public static void Main(string[] args){
        Employee emp1 = new Employee("Sunil", 1001,150000,10);
        emp1.Display();
        emp1.IncrementSalary(15000);
        emp1.Display();
    }
}

class Employee {
    public string EmpName;
    public int EmpId;
    public double EmpSalary;
    public int LeaveBalance;

    // constructors 
    public Employee(string EmpName, int EmpId, double EmpSalary, int LeaveBalance){
        this.EmpName = EmpName;
        this.EmpId = EmpId;
        this.EmpSalary = EmpSalary;
        this.LeaveBalance = LeaveBalance;
    }

    // increment salary 
    public void IncrementSalary(double Amount){
        this.EmpSalary += Amount;
        Console.WriteLine($"Employee salary is incremented as: {EmpSalary}");
    }

    // display name- leave 
    public void Display(){
        Console.WriteLine($"Employee Name: {EmpName}  LeaveBalance: {LeaveBalance}");
    }
}
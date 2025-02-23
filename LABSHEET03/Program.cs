// Practice Questions:1
/* 
information:define a class student with data members student name, student age,include 
            default and parameterized constructors

input: std name, std age 
output: print name, age using objects 
*/

class programe {
    public static void Main(string[] args){
        Student student = new Student();// calling default constructor
        Student student2 = new Student("Pradeep", 21);

    }
}

class Student{
    string studentName;
    int studentAge;
    
    // default/non-parameterized constructor 
    public Student() {
        Console.WriteLine("Student Object created....");
    }
    //parametrized constructor
    public Student(string stdName, int stdAge) {
        studentName = stdName;
        studentAge = stdAge;
        displayDetails();
    }

    // display method 
    public void displayDetails(){
        Console.WriteLine($"Student Name: {studentName} & Student Age: {studentAge}");
    }
}
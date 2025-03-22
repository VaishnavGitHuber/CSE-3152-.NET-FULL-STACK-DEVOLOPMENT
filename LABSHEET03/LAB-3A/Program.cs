/*
LABSHEET 3A
info : Define a class ‘student’ with data members stno, stname and age. 
Also include following: Default Constructor and parameterized constructor. 
Display method to show all details.

input : None

output : Display details
*/

namespace Labsheet3a {
    class Student{
        // declaring varables 
        string StdName; 
        int StdNumber, StdAge;

        // Default constructor
        public Student(){
            this.StdName = "Rahul";
            this.StdNumber = 1201;
            this.StdAge = 21;
        }
        // parameterized Constructor 
        public Student(string Name, int Number, int Age){
            this.StdName = Name;
            this.StdNumber = Number;
            this.StdAge = Age;
        }

        // function : tp display details 
        public void DisplayInfo(){
            Console.WriteLine("Student Details");
            Console.WriteLine($"Student Name: {this.StdName}");
            Console.WriteLine($"Student Number: {this.StdNumber}");
            Console.WriteLine($"Student Age: {this.StdAge}");
        }
    }

    // Main class
    class Programme {
        public static void Main(string[] args){
            // class : invoke default constructor
            Student s1 = new Student();
            // class : invoke parametrized constructor 
            Student s2 = new Student("Vaishnav",1001,19);
            // calling display method 
            s1.DisplayInfo();
            s2.DisplayInfo();
        }
    }
}
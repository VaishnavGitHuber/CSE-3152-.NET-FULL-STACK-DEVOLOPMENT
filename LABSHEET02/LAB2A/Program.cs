/* 
LABSHEET02
info : Take the age and name of two students in a class.
Compare and display the oldest student name and age using if-else statement

input : age and name of two students

output : display the oldest student name
*/

class Labsheet02 {
    static void Main(string[] args){
        // array declaration : name & age 
        int SIZE = 2;
        string[] Name = new string[SIZE];
        int[] Age = new int[SIZE];

        // input age and marks of 2 persons
        for(int i = 0;i < SIZE;i++){ // SIZE === Name.Length or Age.Length
            Console.Write($"Enter {i+1}Person Name: ");
            Name[i] = Console.ReadLine();
            Console.Write($"Enter {i+1}Person Age: ");
            Age[i] = Convert.ToInt32(Console.ReadLine());
        }

        // find index: elder person 
        int ElderIndex = 0;

        if (Age[1] > Age[0]) {
            ElderIndex = 1;
            PrintDetails(Name[1], Age[1]);
        }else {
            PrintDetails(Name[0], Age[0]);
        }
    }

    // print(output): age & name of elder student 
    static void PrintDetails(string Name, int Age){
        Console.WriteLine($"\nElder Student Name: {Name}");
        Console.WriteLine($"Elder Student Age: {Age}");
    }
}
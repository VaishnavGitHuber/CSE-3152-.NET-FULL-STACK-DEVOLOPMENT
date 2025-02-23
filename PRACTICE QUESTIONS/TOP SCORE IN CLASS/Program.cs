/* 
info: take age of 3 students with name and print the oldest student 
input: age and name of the three student 
output: print the oldest student 
*/

class Programe {
    public static void Main(string[] args){
        string[] name = new string[3];
        double[] marks = new double[3];
        double highestMarks;
        int highestIndex;

        // input marks and name of 3 students 
        for(int i = 0; i < 3;i++){
            Console.Write("Enter the student name: ");
            name[i] = Console.ReadLine();
            Console.Write("Enter the student marks: ");
            marks[i] = Convert.ToDouble(Console.ReadLine());
        }

        // finding the index of student with higest marks 
        highestIndex = 0;
        highestMarks = marks[0];

        for(int i = 1;i < 3;i++){
            if(marks[i] > highestMarks){
                highestMarks = marks[i];
                highestIndex = i;
            }
        }
        //output 
        Console.WriteLine($"Topper of class\nName: {name[highestIndex]} Marks: {marks[highestIndex]}");

    }
}
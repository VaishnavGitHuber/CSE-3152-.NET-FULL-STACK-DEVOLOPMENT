/* 
info : Create a programme to award grade
input: 3 subject marks,name 
output: Grade

Hint: 0-100 Averge, 100-200 Good, 200-300 Excelent 
*/

class Programe {
    public static void Main(string[] args){
        string studentName;
        int[] marks = new int[3];
        double totalMarks = 0;
        string grade = "";

    // input from the user 
        Console.Write("Enter the student Name: ");
        studentName = Console.ReadLine();

        Console.WriteLine("Enter marks: ");
        for(int i = 0; i < 3; i++){
            Console.Write($"Enter marks of subject{i+1}: ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
            // total marks 
            totalMarks += marks[i];
        }

        // awarding grade 
        if(totalMarks > 200 && totalMarks <= 300){
            grade = "Exellent";
        }else if(totalMarks > 100 && totalMarks <= 200){
            grade = "Good";
        }else if(totalMarks > 0 && totalMarks <= 100){
            grade = "Average";
        }
        Console.WriteLine($"Total Marks: {totalMarks} Grade: {grade}");

    }
}
/*
Assessment 2A
Info : Write a code to award grade to a student. 
Get name of a student and three subjects marks. 
Calculate the total marks and award Excellent, Good and Average.
Range: Excellent : 200 to 300; Good : 100 to 200; Average: less than 100

input : name of a student and three subjects marks. 

output : Calculate the total marks and award Excellent(O), Good(G) and Average(A).
*/
class Assessment2A {
    static void Main(string[] args){
        // input name 
        Console.Write("Enter the name: ");
        string Name = Console.ReadLine();

        // input marks 
        int SIZE = 3;
        string[] Subjects = {"English", "Chemistry", "Maths"};
        int[] Marks = new int[SIZE];

        for(int i = 0; i < Marks.Length; i++){
            Console.Write($"Enter {Subjects[i]} Marks(100): ");
            Marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Calculate: Total marks, Grade 
        int Totalmarks = CalculateSum(Marks);

        // Award Grade 
        char Grade = AwardGrade(Totalmarks);

        // print : Grade 
        Console.WriteLine($"NAME: {Name} TOTAL MARKS: {Totalmarks} GRADE : {Grade}");
    }

    // Function: return sum of marks
    static int CalculateSum(int[] Marks){
        // calculate sum of array 
        int TotalMarks = 0;

        for(int i = 0;i < Marks.Length;i++){
            TotalMarks += Marks[i];
        }
        return TotalMarks;
    }

    // function: award grade 
    static char AwardGrade(int TotalMarks){
        // Awarding the grade 
        char Grade = 'X';

        if(TotalMarks <= 300 && TotalMarks > 200){
            Grade = 'O';
        }else if(TotalMarks <= 200 && TotalMarks > 100){
            Grade = 'G';
        }else if(TotalMarks < 100){
            Grade = 'A';
        }
        // return : award 
        return Grade;
    }
}
/* Write Code to award grade to the students.
- Get name of the student and three student marks.
- Claculate the total marks 
- award Excellent, good, average grades
Hint: 200-300 Excellent, 100-200 Good, less than 100 Average 
*/

// array to store the marks anf name of the students 
string[] Name = new string[3];
double[] Marks = new double[3];
string[] Grade = new string[3];

// input the marks and grade of the 3 students 
for (int i = 0; i < Name.Length; i++)
{
    Console.Write($"Enter {i + 1} person's name: ");
    Name[i] = Console.ReadLine();
    Console.Write($"Enter {i + 1} person's mark: ");
    Marks[i] = Convert.ToDouble(Console.ReadLine());

    // logic using to store the award
    if (Marks[i] > 200 && Marks[i] < 300)
    {
        Grade[i] = "Excellent";
    }
    else if (Marks[i] > 100 && Marks[i] < 200)
    {
        Grade[i] = "Good";
    }
    else if (Marks[i] < 100)
    {
        Grade[i] = "Average";
    }
}

// award the grade 
Console.WriteLine("\n");
for (int i = 0; i < Name.Length; i++)
{
    Console.WriteLine($"{Name[i]} got {Marks[i]}:Grade is {Grade[i]}");
}



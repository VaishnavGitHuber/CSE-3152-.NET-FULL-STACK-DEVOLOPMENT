/*
information: calculate the simple intrest 
input: principle(P), rate(r), time (t)
output: simple intrest (Si)

Hint: Si= P * r * t;
*/

class CalculateSimpleIntrest{
    public static void Main(string[] args){
        // variables for storing the data's
        double simpleIntrest, principle;
        int rate,time;

        // input from the user 
        Console.Write("Enter the principle Amount: ");
        principle = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the rate: ");
        rate = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the time(in hours): ");
        time = Convert.ToInt32(Console.ReadLine());
        // calculating the simple intrest 
        simpleIntrest = principle * rate * time;

        // printing to the user 
        Console.WriteLine($"\nSimple Intrest: {simpleIntrest}");

    }
}
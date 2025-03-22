/*
ASSESSMENT 2B 
Write a program in C# to display the multiplication table of a given integer using for loop.
*/

class Assessment2B {
    static void Main(string[] args){
        // input : value of n
        Console.Write("Enter the value of N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        // output : Multiplication table
        MultiplicationTable(N);
}

    static void MultiplicationTable(int N){
        // up to 10 multiplication table of a number 
        for(int i = 1;i <= 10;i++){
            Console.WriteLine($"{i} * {N} = {i*N}");
        }
    }
}
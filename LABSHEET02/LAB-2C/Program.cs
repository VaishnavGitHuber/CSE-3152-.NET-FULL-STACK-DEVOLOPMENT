/*
ASSESSMENT2B
info : Write a program in C# to display the multiplication table of a given integer using for loop.
input : an integer 
output : Multiplication table 
*/
class Assessment2B {
    static void Main(string[] args){
        // input : an integer 
        Console.Write("Enter an integer: ");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Sum of Odd Number till {N}: {OddSum(N)}");
       
    }

    // function : find sum of odd number till N 
    static int OddSum(int N){
         // finding the sum of odd Numbers till N 
        int Sum = 0;

        for(int i = 1;i <= N;i++){
            if (i % 2 == 1){
                Sum += i;
            }
        }
        return Sum;
    }
}
/*
LABSHEET 02 B
Write a C# code to calculate the sum of N numbers using for loop
*/
class LABSHEET02B {
    static void Main(string[] args){
        // Enter the Value of N 
        Console.Write("Enter the value of N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Sum of {N}number: {SumN(N)}");
    }

    // function : sum of N natural numbers 
    static int SumN(int N){
        int Sum = 0;
        // forloop : to find the sum 
        for(int i = 1;i <= N;i++){
            Sum += i;
        }
        return Sum;
    }
}
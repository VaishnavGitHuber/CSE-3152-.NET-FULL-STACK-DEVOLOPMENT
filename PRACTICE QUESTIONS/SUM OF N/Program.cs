/* 
info: find the sum of n natural numbers 
input: value of n 
output: sum of n natural numbers 
*/ 

class Programe {
    public static void Main(string[] args){
        int n, sum = 0;
        Console.Write("Enter value of n: ");
        n = Convert.ToInt32(Console.ReadLine());

        // calculating the sum of n values 
        for(int i = 1; i <= n; i++){
            sum += i;
        }

        Console.WriteLine($"Sum of {n} Numbers: {sum}");
    }
}
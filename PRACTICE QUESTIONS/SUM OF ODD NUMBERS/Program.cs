/* 
info: sum of n odd numbers 
input: value of n 
output: sum of all odd numbers till n 
*/

class Programe {
    public static void Main(string[] args){
        int n, sumOdd = 0;
        Console.Write("Enter the value of n: ");
        n = Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i <= n; i++){
            if(i % 2 != 0){
                Console.Write($"{i}  ");
                sumOdd += i;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Sum of Odd numbers till {n}: {sumOdd}");
    }
}
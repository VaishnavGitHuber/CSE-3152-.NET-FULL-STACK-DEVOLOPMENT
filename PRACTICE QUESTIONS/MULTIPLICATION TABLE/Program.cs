/* 
info: Create a multipliaction table
input: value of n 
output: multplication table of n 
*/

class Programe {
    public static void Main(string[] args){
        int n;
        Console.Write("Enter the value of n: ");
        n = Convert.ToInt32(Console.ReadLine());

        // multiplicatio table till 1-10
        for(int i = 1; i <= 10; i++){
            Console.WriteLine($"{n} * {i} = {n * i}");
        }
    }
}
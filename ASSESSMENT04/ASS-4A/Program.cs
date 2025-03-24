/* 
ASSESSMENT 4A 
Write a C# Program to find out the
multiplication of two, three and four operands 
using method overloading.
*/
class Programme {
    // function : Main 
    public static void Main(string[] args){
        // output : print the statements 
        Console.WriteLine($"Muliplication of (9,8): {Multiply(9,8)}");
        Console.WriteLine($"Muliplication of (9,8,7): {Multiply(9,8,7)}");
        Console.WriteLine($"Muliplication of (9,8,7,6): {Multiply(9,8,7,6)}");
    }
    // function : multiply 2 numbers
    public static int Multiply(int a, int b){
        return a * b;
    }
    // function : to multiply three numbers 
    public static int Multiply(int a, int b, int c){
        return a * b * c;
    }

    // function : to multiply four numbers 
    public static int Multiply(int a, int b, int c, int d){
        return a * b * c * d;
    }
}
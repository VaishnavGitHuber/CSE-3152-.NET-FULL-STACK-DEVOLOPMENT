namespace Labsheet6B {
    class Progarmme {
    // define delegate : calculator
    delegate int Calculator(int a, int b);
    // main function : Main 
    public static void Main(string[] args){
        // Object : delegates 
        Calculator CalAdd = new Calculator(Add);
        Calculator CalMul = new Calculator(Mul);
        // Method invoke : adddition & Multiplication 
        Console.WriteLine($"Addition of (9,8): {CalAdd.Invoke(9,8)}");
        Console.WriteLine($"Multiplication of (9,8): {CalMul.Invoke(9,8)}");
    }

    // function : adding 2 numbers
    public static int Add(int Num1, int Num2){
        return Num1 + Num2;
    }
    // function : multiplying 2 numbers
    public static int Mul(int Num1, int Num2){
        return Num1 * Num2;
    }
    }
}
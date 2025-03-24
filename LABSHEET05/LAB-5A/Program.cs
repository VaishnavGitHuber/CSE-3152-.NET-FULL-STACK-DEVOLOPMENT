/*
LABSHEET5A
Developer is writing code for dividing two numbers. 
If the user enters 0 in the second number, an exception should be raised. 
Handle the exception with the appropriate code.
*/
namespace Labsheet5a {
    class ExceptionHandling {
        public static void Main(string[] args){
            // variables: declaring 2 numbers 
        int Number1, Number2;
        // input : numbers 
        Console.Write("Enter the first number: ");
        Number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        Number2 = Convert.ToInt32(Console.ReadLine());

        try {
            // block of code where exception may rise 
            int Result = Number1 / Number2;
            Console.WriteLine($"Result is: {Result}");
        }catch (DivideByZeroException e){
            // block of code to handle the exception 
            Console.WriteLine(e.Message);
        }

        }
    }
} 
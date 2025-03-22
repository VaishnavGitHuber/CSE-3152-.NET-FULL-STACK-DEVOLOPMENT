/*
ASSESSMENT 2C
info : Write a C# code to check the given number is palindrome or not using while loop.
input : number 
output : palindrom / not palindrome (bool)
*/
class Assessment2C{
    static void Main(string[] args){
        // input : number 
        Console.Write("Enter the Number: ");
        string Number = Console.ReadLine();

        // output : is palindrom or not 
        bool IsPal = IsPalindrome(Number);
        if (IsPal){
            Console.WriteLine($"Number {Number} is Palindrome");
        }else {
            Console.WriteLine($"Number {Number} is Not Palindrome");
        }

    }

    // function : check palindrom or nor -> bool
    static bool IsPalindrome(string Number){
        // while loop : checking 
        int i = 0;

        while(i < Convert.ToInt32(Number.Length / 2)){
            if(Number[i] != Number[Number.Length-1-i]){
                return false;
            }
            i += 1;
        }
        return true;
    }
}
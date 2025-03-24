/* 
Raise the exception not eligible for voting if the age is less than 18.
*/
class Programme {
    public static void Main(string[] args){
        // input : age feature 
        Console.Write("Enter your Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // try - catch : to handle age < 18 
        try {
            if(age >= 18){
                Console.WriteLine("You Are not elibible for votting");
            }else {
                throw new Exception("You are not eligible for votting");
            }
        }
        catch(Exception e){
            Console.WriteLine($"NOTE: {e.Message}");
        }finally{
            Console.WriteLine("Excecution completed....");
        }
    }
}
/*
LABSHEET 5B
Admin executive of the university is entering the university name for the students.
If he enters the name wrongly, exception should be raised.
*/

namespace LABSHEET5B {
    public class Programme {
         public static void Main(string[] args){
            Console.Write("Enter the Unversity Name: ");
            string UniversityName = Console.ReadLine();

            try {
                if(UniversityName.ToUpper() == "PRESIDENCY"){
                    Console.WriteLine("Welcome to presidency university");
                }else {
                    throw new Exception("You Have entered Wrong input...");
                }
            }catch (Exception e){
                Console.WriteLine($"Exception {e.Message}");
            }

            
        }
    }
}
/* 
LABSHEET 4A 
Write a C# Program to find out the
area of the triangle, square, and rectangle 
using method overloading.

variables : container for storing the data 
function : block of code that can be reused again & again
class : template for creating
methodoverloading : same method name, difference in method signature 
*/
namespace LABSHEET4A {
    class MethodOverloading {
        // function : area of trangle 
        public int Area(int bredth, int height){ // parameter : 2 * int
            int area = (int)(bredth * height * 0.5);  // 7.56433 -> 8
            return area;
        } 
        // function : area of rectangle 
        public int Area(float length, float bredth){ // parameter : 2 * float 
            int area = (int)(length * bredth);
            return area;
        }
        // function : area of square 
        public int Area(int a){ // paramter : 1 * int 
            int area = a * a;
            return area;
        }
    }

    // class : progarmme 
    class Programme {
        // main function : Main 
        public static void Main(string[] args){
            // object : class Method Overloading 
            MethodOverloading class1 = new MethodOverloading();

            // print : output 
            Console.WriteLine($"Area of Trangle: {class1.Area(9,8)}");// 2 * int
            Console.WriteLine($"Area of Rectangle: {class1.Area(10F,5F)}");// 2 * float
            Console.WriteLine($"Area of Square: {class1.Area(15)}");// 1 * int
        }
    }
}
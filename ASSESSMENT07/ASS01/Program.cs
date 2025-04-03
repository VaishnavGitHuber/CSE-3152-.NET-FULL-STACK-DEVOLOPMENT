/* 
Write a C# Program to create 10 fruit list and later remove the last 3 names from the list.
*/

using System.Collections;

class Programe {
    public static void Main(string[] args){
        // Create a datastructure : stack 
        Stack stack = new Stack();

        // adding items : end 
        stack.Push("Apple");
        stack.Push("Mango");
        stack.Push("Orange");
        stack.Push("Pineapple");
        stack.Push("Guave");
        stack.Push("Grapes");
        stack.Push("Watermelon");
        stack.Push("sweet Mango");
        stack.Push("fruit9");
        stack.Push("fruit10");

        // removing the last 3 fruits 
        stack.Pop();
        stack.Pop();
        stack.Pop();

        // printint the remining 7 fruits 
        foreach(var fruit in stack){
            Console.Write(fruit + ", ");
        }Console.WriteLine();
    }
}
/*
7 b. Write a C# code to show the concept Stack
*/
using System.Collections;

class Programe {
    public static void Main(string[] args){
        // Create Object of the stack
        Stack stack = new Stack();

        // adding the element 
        stack.Push("Apple"); // top - Apple
        stack.Push("Orange"); // top - Orange
        stack.Push("Mango"); // top - Mango

        // Print: before pop()
        Console.WriteLine("Before Pop: ");
        foreach(var item in stack){
            Console.Write(item + ", "); // mango -> orange -> apple
        }Console.WriteLine();

        // Pop : remove the item from the last
        stack.Pop(); // mango is removed

        // Print: after pop()
        Console.WriteLine("Before Pop: ");
        foreach(var item in stack){
            Console.Write(item + ", "); // ornage, apple
        }Console.WriteLine();

    }
}
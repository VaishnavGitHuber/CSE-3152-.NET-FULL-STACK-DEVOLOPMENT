/* 
7 c. Write a C# code to show the concept Queue
*/
using System.Collections;

class Programe {
    public static void Main(string[] args){
        // Creating Object of Queue 
        Queue queue = new Queue();

        // adding elements : Enqueue(element)
        queue.Enqueue("Apple"); // Front - Apple : Rear - Apple
        queue.Enqueue("Orange"); // Front - Apple : Rear - Orange
        queue.Enqueue("Grapes"); // Front - Apple : Rear - Grapes
        queue.Enqueue("Mango"); // Frone - Apple : Rear - Mango

        // Printint : Before Dequeue 
        Console.WriteLine("Print Before Enqueue");
        foreach(var item in queue){
            Console.Write(item + ", ");
        }Console.WriteLine();

        // removing element : Dequeue()
        queue.Dequeue();// Front - Orange : Rear : Mango
        queue.Dequeue();// Front - Grapes : Rear : Mango

        // Printint : Before Dequeue 
        Console.WriteLine("Print After Enqueue");
        foreach(var item in queue){
            Console.Write(item + ", ");
        }Console.WriteLine();
        
    }
}
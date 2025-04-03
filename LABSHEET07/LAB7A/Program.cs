/*
7 a. Write a C# code to show the concept Array List
*/
using System.Collections;

class Programe {
    public static void Main(string[] args){
        // Object : creating an object of the arrayList
        ArrayList arraylist = new ArrayList();

        // adding elements(Add(element))
        arraylist.Add("Vaishnav Krishna P");
        arraylist.Add("Kiran M");
        arraylist.Add("Madhu Praneeth");
        arraylist.Add("Dhanush SN");

        // printing : before removing 
        Console.WriteLine("Before Removing");
        foreach(var ele in arraylist){
            Console.Write($"{ele} ->");
        }Console.WriteLine("NULL");


        // Removing elements 
        arraylist.Remove("Kiran M");

        // printing : after removing
        Console.WriteLine("After Removing");
        foreach(var ele in arraylist){
            Console.Write($"{ele} ->");
        }Console.WriteLine("NULL");
    }
}
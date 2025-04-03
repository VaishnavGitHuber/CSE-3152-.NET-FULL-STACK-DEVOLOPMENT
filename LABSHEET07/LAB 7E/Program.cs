/* 
7 e. Write a C# code to show the concept Sorted List
*/
using System.Collections;

class Programe {
    public static void Main(string[] args){
        // Creating a object : SortedList
        SortedList sortedlist = new SortedList();

        // Adding items 
        sortedlist.Add("ziran m", "A+");
        sortedlist.Add("Madhu p", "O-");
        sortedlist.Add("Vaishnav Kp", "B+");

        // Printing : items 
        foreach(DictionaryEntry item in sortedlist){
            Console.WriteLine($"Key: {item.Key}"+" : "+$"value: {item.Value}");
        }Console.WriteLine();
    }
}
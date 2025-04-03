/*
Write a C# program to create the sorted array of 5 students details with roll number and name.
*/
using System.Collections;
class Programe {
    public static void Main(string[] args){
        // SortedList : Create a object of the Datastructure 
        SortedList sortedlist = new SortedList();

        // adding the 5 student name & rollnumber 
        sortedlist.Add("Vaishnav Krishna P", "20221COM0040");
        sortedlist.Add("Dhanush SN", "20221COM0032");
        sortedlist.Add("Sunil Kumar Pandab", "20221COM0034");
        sortedlist.Add("Madhu Praneeth", "20221COM0036");
        sortedlist.Add("Danda Tarun Chaudary", "20221COM0055");

        // printing : sorted list 
        foreach(DictionaryEntry item in sortedlist){
            Console.WriteLine($"Name: {item.Key} Value: {item.Value}");
        }
    }
}
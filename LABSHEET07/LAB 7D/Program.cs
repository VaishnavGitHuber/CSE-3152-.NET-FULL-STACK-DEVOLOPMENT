using System.Collections;

class Programme {
    public static void Main(string[] args){
        // Creating object of the Hashmap
        Hashtable hashmap = new Hashtable();

        // adding the elements : Add(key, value)
        hashmap.Add("fname", "Vaishnav");
        hashmap.Add("lname", "Krishna");
        hashmap.Add("age", 21);


        // print : output 
        foreach(DictionaryEntry item in hashmap){
            Console.WriteLine(item.Key + " : " + item.Value);
        }Console.WriteLine();
    }
}
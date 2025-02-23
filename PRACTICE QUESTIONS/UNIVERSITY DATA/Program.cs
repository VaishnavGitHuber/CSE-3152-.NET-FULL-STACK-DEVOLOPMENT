/* 
info : uiversity wants to store infomation about the students such as
 fname, sname,semister, specialisation.
input: fname, sname,semister, specialisation.
ouput: printing the university 
*/
class Programe {
    public static void Main(string[] arg){
        UniveristyData data1 = new UniveristyData("Vaishnav", "Krishna", "Sem6", "AIML");
    }
}

class UniveristyData {
    // attributes 
    string firstName, secondName, semister, specialisation;

    // constructor 
    public UniveristyData(string fName, string sName, string semi, string special){
        firstName = fName;
        secondName = sName;
        semister = semi;
        specialisation = special;
        displayDetails();
    }

    public void displayDetails(){
        Console.WriteLine($"First Name: {firstName} \nSecond Name: {secondName}\nSemister: {semister}\nSepecialization: {specialisation}");
    }
}
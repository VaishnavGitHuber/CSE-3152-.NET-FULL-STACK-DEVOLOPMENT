class Programe {
    public static void Main(string[] args){
        TelecomDatabase tel = new TelecomDatabase();
        tel.CustomerName = "Vaishnav KP";
        tel.CustomerNumber = "+91 9765234323";
        tel.CallUsage =  15;
        tel.CalculateBillAmount();
    }
}
public class TelecomDatabase {
    public string CustomerName;
    public string CustomerNumber;
    public int CallUsage;

    // Calculate the bill amount
    public void CalculateBillAmount(){
        double TotalAmount = CallUsage * 2; // 15 * 2 <= 30
        Console.WriteLine($"Total Amount: {TotalAmount}");
    }
}

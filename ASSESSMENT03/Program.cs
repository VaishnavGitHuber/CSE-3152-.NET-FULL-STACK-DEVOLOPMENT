/*
Assessment 3:
Telecom company is storing consumer details.
Design a class to represent a consumer account.

Include the following data members: Name of the consumer, Consumer’s Mobile Number,
Call usage in minutes.
Calculate the bill amount to be paid. Bill amount = minutes * Rs. 2.

Write a C# program to demonstrate the method to calculate & display the consumer 
number along with the total amount to be paid.
*/
namespace Assaignment3B{
    class Telecom{
        string CustomerName, ConsumerNumber;
        int CallUsage;
        // constructor : initialising values  
        public Telecom(string CustomerName, string ConsumerNumber, int CallUsage){
            this.ConsumerNumber = ConsumerNumber;
            this.CustomerName = CustomerName;
            this.CallUsage = CallUsage;
        }
        // function: calculate the bill
        public decimal CalculateBill(){
            decimal BillAmount = CallUsage * 2;
            return BillAmount;
        }

        // function : display details 
        public void DisplayDetails(){
            Console.WriteLine($"Customer Name: {CustomerName}\nBILL AMOUNT: {CalculateBill()}");
        }
    }

    class Programme {
        public static void Main(string[] args){
            Telecom tel = new Telecom("Vaishnav","1001",20);
            tel.DisplayDetails();
        }
    }
} 
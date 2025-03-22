/*
LABSHEET 3B
Design a class to represent a bank account. 
Include the following members: 

Data Members: - Name of the depositor, Account Number, Type of Account, 
Balance amount in the account 

methods : To assign initial values, To deposit an amount, 
To withdraw an amount after checking balance, To display name and the balance.

Write a c# program to demonstrate the working of the various class members.
*/
namespace Labsheet3B {
    public class Bank{
        // data members : name, acc_number, type_account, balance_amount
        string DepositorName, AccountNumber, TypeAccount;
        decimal BalanceAmount;

        // constructor : to intialise the data members 
        public Bank(string DepositorName, string AccountNumber, string TypeAccount){
            this.BalanceAmount = 0;
            this.DepositorName = DepositorName;
            this.AccountNumber = AccountNumber;
            this.TypeAccount = TypeAccount;
        }

        // function : to deposit money 
        public void DepositAmount(int Amount){
            this.BalanceAmount += Amount;
            Console.WriteLine($"Account Credited: {Amount}\nBank Balance: {BalanceAmount}");
        }

        // function : withdraw amount 
        public void WithdrawAmount(int Amount){
            if(Amount <= BalanceAmount){
                BalanceAmount -= Amount;
                Console.WriteLine($"Account Debited: {Amount}\nBank Balance: {BalanceAmount}");
            }
        }

        // function : to show details 
        public void Display(){
            Console.WriteLine("\nBank Information: ");
            Console.WriteLine($"Account holder name: {this.DepositorName}\nAccount No: {this.AccountNumber}\nBank Type: {this.TypeAccount}\nBank Balance: {this.BalanceAmount}");
        }

    }

    class Programme {
        public static void Main(string[] args){
            Bank bank = new Bank("Vaishnav Krishna P", "SBI765812344321", "Saving");
            bank.DepositAmount(10000);
            bank.WithdrawAmount(200);
            bank.Display();
        }
    }
}
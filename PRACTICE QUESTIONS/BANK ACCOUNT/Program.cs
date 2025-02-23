class Program {
    public static void Main(string[] args){
        Bank bank = new Bank("SBI0029","VAISHNAV KRISHNA P");
        bank.bankDeposit(10000);
        bank.bankWithdraw(1000);

    }
}

class Bank {
    string accNumber;
    string accName;
    double balance;

    //constructor 
    public Bank(string accNum, string accName){
        this.accNumber = accNum;
        this.accName = accName;
        balance = 0;
    }
    // Deposit 
    public void bankDeposit(double amount){
        balance += amount;
        displayBalance();
    }

    // withdraw 
    public void bankWithdraw(double amount){
        if(amount <= this.balance){
            balance -= amount;
            displayBalance();
        }else {
            Console.WriteLine("Bank Balance Insufficent");
        }
    }

    // display balance 
    public void displayBalance(){
        Console.WriteLine($"Account Number: {accNumber} || Bank Balance: {balance}");
    }
}
namespace chatGpt2;

public class Account
{
    public int AccountNumber;
    public string OwnerName;
    public int Balance;
    
    // Account Constructors
    public Account(int accountNumber, string ownerName, int balance)
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = balance;
    }
    
    // Deposit Method
    public void Deposit(int amount)
    {
       Balance += amount;
    }
    
    // Withdraw Method
    public void withdraw(int amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds.");
        }
        else
        {
            Balance -= amount;
        }
    }
    
    // Display Info
    public void DisplayAccountInfo()
    {
        Console.WriteLine($"AccountNum: {AccountNumber}");
        Console.WriteLine($"OwnerName: {OwnerName}");
        Console.WriteLine($"Balance: {Balance}");
    }
}
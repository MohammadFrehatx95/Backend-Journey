public class Program
{
    public static void Main()
    {
        var account = new BankAccount("ACC-1001", "Mohammad");

        account.Deposit(1000);
        account.Withdraw(300);

        account.PrintInfo();
    }
}

public class BankAccount
{
    public string AccountNumber { get; }
    public string OwnerName { get; }
    public decimal Balance { get; private set; }

    public BankAccount(string accountNumber, string ownerName)
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
            Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
            Balance -= amount;
    }

    public void PrintInfo()
    {
        Console.WriteLine(
            $"Account: {AccountNumber}, Owner: {OwnerName}, Balance: {Balance}");
    }
}

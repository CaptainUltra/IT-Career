public class BankAccount
{
    private int id;
    private decimal balance;
    public BankAccount()
    {

    }
    public BankAccount(int id, decimal amount)
    {
        this.Balance = amount;
    }
    public void Deposit(decimal ammount)
    {
        this.Balance += ammount;
    }
    public void Withdraw(decimal ammount)
    {
        if(this.Balance - ammount >= 0)
        {
            this.Balance -= ammount;
        }
        else 
        {
            System.Console.WriteLine("Insufficient balance");
        }
    }
    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public decimal Balance
    {
        get { return this.balance; }
        set { this.balance = value; }
    }
    public override string ToString()
    {
        return $"Account {this.id}, balance {this.balance:F2}";
    }
}
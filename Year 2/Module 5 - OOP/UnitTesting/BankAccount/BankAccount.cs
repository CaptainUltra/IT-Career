namespace BankAccount
{
    public class BankAccount
    {
        public BankAccount()
        {

        }
        public decimal Ammount{get; private set;}
        public void Deposit(decimal ammount)
        {
            this.Ammount += ammount;
        }
        public void Withdraw(decimal ammount)
        {
            if(this.Ammount - ammount >= 0)
            {
                this.Ammount -= ammount;
            }
        }
    }
}
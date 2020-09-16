namespace BankV05
{
    /// <summary>
    /// This class represents a very simple bank account.
    /// Only the amount of money on the account is represented.
    /// </summary>
    public class BankAccount
    {
        private double _balance;
        private string _name;

        public BankAccount(string name)
        {
            _balance = 0.0;
            _name = name;
        }

        public double Balance
        {
            get { return _balance;}
        }

        public string GetName{
             get { return _name;}
        }

        public void Deposit(double amount)
        {
            _balance = _balance + amount;
        }

        public void Withdraw(double amount)
        {
            _balance = _balance - amount;
        }
    }
}
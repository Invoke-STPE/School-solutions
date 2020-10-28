namespace BankWithExceptions
{
    public class BankAccount
    {
        private double _balance;
        private double _interestRate;

        public BankAccount(double interestRate)
        {
            if (interestRate > 10)
            {
                throw new IllegalInterestRateException($"An interest of {interestRate} is ilegal!");
            }
            _interestRate = interestRate;
            _balance = 0.0;
        }

        /// <summary>
        /// Balance of the account; must not become negative
        /// </summary>
        public double Balance
        {
            get { return _balance; }
        }

        /// <summary>
        /// Interest rate of the account; must be between 0.0 and 20.0
        /// </summary>
        public double InterestRate
        {
            get { return _interestRate; }
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new NegativeAmountException($"You cannot deposit zero or a negative amount!");
            }
            _balance = _balance + amount;
        }

        public void Withdraw(double amount)
        {
            if (_balance < amount)
            {
                throw new WithdrawAmountTooLargeException($"Amount was {amount} kr., balance was {_balance} kr.");
            }
            if (amount <= 0)
            {
                throw new NegativeAmountException($"You cannot withdraw zero or a negative amount!");
            }

            _balance = _balance - amount;
        }
    }
}

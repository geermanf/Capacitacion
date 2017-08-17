using System;

namespace Class
{
    public class PremiumState : IState
    {
        private double lowerLimit;
        private double interestRate;


        public PremiumState()
        {
            this.lowerLimit = 10000;
            this.interestRate = 0.10;
            Console.WriteLine("Tu cuenta fue promovida a Premium");
            Console.WriteLine("");

        }
        public void Deposit(double amount, Account account)
        {
            account.Balance += amount;
            Console.WriteLine("Se deposito  = " + amount);
            this.StateCheck(account);
        }
        public void Withdraw(double amount, Account account)
        {

            account.Balance -= amount;
            Console.WriteLine("Se retiro = " + amount);
            this.StateCheck(account);

        }
        public void PayInterest(Account account)
        {
            account.Balance += account.Balance * this.interestRate;
            Console.WriteLine("Se pago un interes de "+ this.interestRate * 100 + "%");
            this.StateCheck(account);
        }
        public void StateCheck(Account account)
        {
            if (account.Balance <= this.lowerLimit)
            {
                account.State = new NormalState();
                account.State.StateCheck(account);

            }

        }

    }
}

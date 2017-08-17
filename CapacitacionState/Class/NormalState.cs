using System;

namespace Class
{
    public class NormalState : IState
    {
        private double lowerLimit;
        private double upperLimit;
        private double interestRate;

        public NormalState()
        {
            this.lowerLimit = 0;
            this.upperLimit = 9999;
            this.interestRate = 0.01;
            Console.WriteLine("Tu cuenta mantiene un estado normal");
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
            Console.WriteLine("Se pago un interes de " + this.interestRate * 100 + "%");
            this.StateCheck(account);
        }
        public void StateCheck(Account account)
        {
            if (account.Balance <= this.lowerLimit)
            {
                account.State = new RedState();

            }
            else if (account.Balance >= this.upperLimit)
            {
                account.State = new PremiumState();
                account.State.StateCheck(account);
            }

        }

    }
}

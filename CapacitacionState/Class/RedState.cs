using System;

namespace Class
{
    class RedState : IState
    {
        private double upperLimit;

        public RedState()
        {
            this.upperLimit = -1;
            Console.WriteLine("Tu cuenta esta en rojo!!");
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
            Console.WriteLine("No hay fondos disponibles para retirar");
        }
        public void PayInterest(Account account)
        {
            Console.WriteLine("No se paga ningun interes");
        }
        public void StateCheck(Account account)
        {
            if (account.Balance >= this.upperLimit)
            {
                account.State = new NormalState();
                account.State.StateCheck(account);

            }

        }
    }
}

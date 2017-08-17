using System;

namespace Class
{
    public class Account
    {

        private double balance;
        private IState state;
        private string owner;

        public Account(string owner)
        {
            // La cuenta comienza en estado normal por default
            this.owner = owner;
            Console.WriteLine("Cuenta creada con exito");
            Console.WriteLine("");
            this.state = new NormalState();
            this.balance = 0;
        }

        public double Balance
        {
            //property de balance
            get { return this.balance; }
            set { this.balance = value; }
        }

        public IState State
        {
            //property de state
            get { return this.state; }
            set { this.state = value; }
        }
        public void Deposit(double amount)
        {
            //El state se encarga de depositar recibiendo por parametro account
            this.state.Deposit(amount, this);

            //Muestra en pantalla los resultados 
            Console.WriteLine(" Balance = " + this.balance);
            Console.WriteLine(" Estado = " + this.state.GetType().Name);
            Console.WriteLine("");
        }

        public void Withdraw(double amount)
        {
            //El state se encarga de retirar recibiendo por parametro account
            this.state.Withdraw(amount, this);

            //Muestra en pantalla los resultados 
            Console.WriteLine(" Balance = " + this.balance);
            Console.WriteLine(" Estado = " + this.state.GetType().Name);
            Console.WriteLine("");
        }

        public void PayInterest()
        {
            //El state se encarga de pagar el interes recibiendo por parametro account
            this.state.PayInterest(this);

            //Muestra en pantalla los resultados 
            Console.WriteLine(" Balance = " + this.balance);
            Console.WriteLine(" Estado = " + this.state.GetType().Name);
            Console.WriteLine("");
        }

    }
}

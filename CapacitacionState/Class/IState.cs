using System;

namespace Class
{
    public interface IState
    {

        void Deposit(double amount, Account account);
        // Recibe dos parametros, un monto y un objeto account donde depositar
        
        /// <summary>
        /// realiza una sustraccion
        /// </summary>
        /// <param name="amount"> monto que se va a retirar</param>
        /// <param name="account">cuenta en la cual se va a retirar monto</param>
        void Withdraw(double amount, Account account);
        // Recibe dos parametros, un monto y un objeto account donde retirar
        void PayInterest(Account account);
        // Recibe solo un objeto Account donde aplica un % de interes definido en el state
        void StateCheck(Account account);
        // Metodo que comprueba si es necesario cambiar de estado despues de cada operacion

    }
}

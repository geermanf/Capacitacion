using System;
using Class;

namespace CapacitacionState
{
    class Program
    {
        static void Main(string[] args)
        {

            //Se crea una cuenta
            Account account = new Account("Sansa Stark");

            //Se deposita 100 manteniendo el mismo estado ( Normal )
            account.Deposit(100);

            //Se paga interes con cuenta en estado Normal
            account.PayInterest();

            //Se Retira 200 para bajar a un estado Rojo
            account.Withdraw(201);

            //Se intenta retirar en estado Rojo
            account.Withdraw(200);

            //Se paga interes con cuenta en Rojo
            account.PayInterest();

            //Se deposita para pasar a estado Premium
            account.Deposit(20100);

            //Se paga interes con cuenta en Premium
            account.PayInterest();


        }
    }
}

using BankAccount.Entities;
using BankAccount.Factory;
using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto!");
            Console.WriteLine("Scegli la tua operazione!");


            //Prova
            Account<IMovement> conto1 = new Account<IMovement>();
            conto1.Statement();

            Functions.MenuStart();

        }
    }
}

using BankAccount.Entities;
using BankAccount.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class Functions
    {
        //Menù Start
        public static void MenuStart()
        {
            Console.WriteLine("Digita 1 - per creare un nuovo conto bancario");
            Console.WriteLine("Digita 2 - per effettuare un movimento");
            Console.WriteLine("Digita 3 - per stampare i dati del tuo conto e i relativi movimenti");

            var operazione = Console.ReadLine();

            switch (operazione)
            {
                case "1":
                    newAccount(); //nuovo account
                    break;
                case "2":
                    MenuMovimenti(); //nuovi movimenti
                    break;
                case "3":
                    //stampa dati del conto e movimenti

                    Console.WriteLine("Inserisci il tuo numero di conto!");
                    var numeroConto = Console.ReadLine();
                    var conto = Account<IMovement>.GetAccount(numeroConto);
                    conto.Statement();
                    break;
                default:
                    Console.WriteLine("Operazione non disponibile!");
                    break;
            }
        }

        public static void MenuMovimenti()
        {
            Console.WriteLine("Digita Cash - per Movimenti di prelievo o deposito in contanti");
            Console.WriteLine("Digita Transfert - per Movimenti di Bonifico verso un'altra banca");
            Console.WriteLine("Digita Card - per Movimenti con la tua carta di credito");

            var tipoMovimento = Console.ReadLine();
            var movement = FactoryMovement.GetMovement(tipoMovimento);

            Console.WriteLine("Digita + per movimento di accredito");
            Console.WriteLine("Digita - per movimento di prelievo");
           
            var operazione = Console.ReadLine();

            if(operazione == "+")
            {
                //Account += movement
            }else if(operazione == "-")
            {
                //Account -= movement
            }

        }

        public static Account<IMovement> newAccount()
        {
            Console.WriteLine("Inserisci il numero del tuo nuovo conto");
            var numero = Console.ReadLine();
            Console.WriteLine("Inserisci il nome della tua banca");
            var banca = Console.ReadLine();
            Console.WriteLine("Inserisci l'importo del saldo iniziale!");
            var saldo = Double.Parse(Console.ReadLine());

            return new Account<IMovement>(numero, banca, saldo);
        }
    }
}

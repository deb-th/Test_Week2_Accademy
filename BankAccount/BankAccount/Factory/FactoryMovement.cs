using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.Factory
{
    /// <summary>
    ///     
    /// </summary>
    public static class FactoryMovement
    {
        public static IMovement GetMovement(string tipoMovimento)
        {
            IMovement newMovement = null;
            var importo = 0.0;

            switch (tipoMovimento)
            {
                case "Cash":
                    
                    Console.WriteLine("Inserisci l'importo:");
                    importo = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisci il nome dell'esecutore:");
                    var esecutore = Console.ReadLine();

                    newMovement = new CashMovement(importo, esecutore);
                    break;
                case "Transfer":

                    Console.WriteLine("Inserisci l'importo:");
                    importo = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisci il nome della Banca di Origine:");
                    var bancaOrigine = Console.ReadLine();
                    Console.WriteLine("Inserisci il nome della Banca di Destinazione:");
                    var bancaDestinazione = Console.ReadLine();

                    newMovement = new TransfertMovement(importo, bancaOrigine, bancaDestinazione); ;
                    break;
                case "Card":

                    Console.WriteLine("Inserisci l'importo:");
                    importo = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisci il tipo di carta (AMEX, VISA, MASTERCARD, OTHER:");
                    var tipo = Enum.Parse(typeof(Tipo), Console.ReadLine());
                    Console.WriteLine("Inserisci il numero della carta utilizzata:");
                    var numCarta = Console.ReadLine();

                    newMovement = new CreditCardMovement(importo, (Tipo)tipo, numCarta);
                    break;
                default:
                    Console.WriteLine("Operazione non valida!");
                    break;
            }
            return newMovement;
        }
    }
}

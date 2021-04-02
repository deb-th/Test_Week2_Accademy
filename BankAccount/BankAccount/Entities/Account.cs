using BankAccount.Factory;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.Entities
{
    /// <summary>
    ///     Classe che implementa un conto bancario 
    ///     e gestisce la lista dei movimenti
    /// </summary>
    /// <typeparam name="T">
    ///     tipo dei movimenti contenuti nella lista
    /// </typeparam>
    public class Account<T> : IEnumerable<T> where T : IMovement
    {
        //Proprietà
        public string NumeroConto { get; set; }
        public string NomeBanca { get; set; }
        public double Saldo { get; set; }
        public DateTime DataUltimaOperazione { get; set; }

        //Lista di Movimenti
        private List<T> movimenti = new List<T>();

        //Costruttori
        public Account() { }

        public Account(string numeroConto, string bank, double saldoIniziale)
        {
            NumeroConto = numeroConto;
            NomeBanca = bank;
            Saldo = saldoIniziale;
            //DataUltimaOperazione DateTIme di default
            //-> al momento della creazione account nessun movimento
        }

        //Metodi devivati da IEnumerable per la gestione della lista movimenti
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in movimenti)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //Metodo che stampa i dati del conto con la lista dei movimenti
        public void Statement()
        {
            Console.WriteLine($"Numero di Conto: {NumeroConto} - Banca: {NomeBanca}");
            Console.WriteLine($"Saldo: € {Saldo} - Data Ultima Operazione: {DataUltimaOperazione}");
            
            Console.WriteLine($"Lista dei tuoi Movimenti");
            foreach (var item in movimenti)
            {
                Console.WriteLine(item);
            }
        }

        public static Account<T> GetAccount(string num)
        {
            Account<T> conto = new Account<T>();
            if (conto.NumeroConto == num)
            {
                return conto;
            }
            return null;
        }



        //Overloading degli Operatori + e - per gestire i movimenti passivi e attivi
        //con il conseguente aggiornamento del saldo del conto e della data di ultima operazione

        //Movimenti in attivo
        public static Account<T> operator +(Account<T> conto, T movimento)
        {
            //aggiunta del movimento alla lista movimenti del conto indicato
            conto.movimenti.Add(movimento);
            //aggiornamento del saldo con incremento dell'importo indicato
            conto.Saldo += movimento.Importo;
            //aggiornamento della data dell'ultima operazione
            conto.DataUltimaOperazione = movimento.DataMovimento;

            //restituisco l'account aggiornato
            return conto;
        }

        //Movimenti in passivo
        public static Account<T> operator -(Account<T> conto, T movimento)
        {
            //aggiunta del movimento alla lista movimenti del conto indicato
            conto.movimenti.Add(movimento);
            //aggiornamento del saldo con un decremento dell'importo indicato
            conto.Saldo -= movimento.Importo;
            //aggiornamento della data dell'ultima operazione
            conto.DataUltimaOperazione = movimento.DataMovimento;

            //restituisco l'account aggiornato
            return conto;
        }
    }
}
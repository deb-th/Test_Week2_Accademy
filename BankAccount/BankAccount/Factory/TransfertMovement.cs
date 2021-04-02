using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.Factory
{
    /// <summary>
    ///     Classe concreta che implementa l'interfaccia IMovement
    ///     per i trasferimenti di denaro tra due diverse banche
    /// </summary>
    public class TransfertMovement : IMovement
    {
        //Proprietà
        public double Importo { get; set; }
        public DateTime DataMovimento { get; set; } = DateTime.Now; //registra al momento del movimento
        public string BancaOrigine { get; set; }
        public string BancaDestinazione { get; set; }

        //Costruttori
        public TransfertMovement() { }

        public TransfertMovement(double importo, string bancaOrigine, string bancaDestinazione)
        {
            Importo = importo;
            BancaOrigine = bancaOrigine;
            BancaDestinazione = bancaDestinazione;
            //DataMovimento l'ho impostata di default a DateTime.Now 
        }

        //Override del metodo ToString per visualizzare tutti i dati specifici di TransfertMovement
        public override string ToString()
        {
            return $"Transfert Movement - Data: {DataMovimento.ToShortDateString()} - Importo: € {Importo} - Banca di Origine: {BancaOrigine} - Banca di Destinazione: {BancaDestinazione};";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.Factory
{
    /// <summary>
    ///     Classe concreta che implementa l'interfaccia IMovement
    ///     per i movimenti bancari effettuati in contanti
    /// </summary>
    public class CashMovement : IMovement
    {
        //Proprietà
        public double Importo { get; set; }
        public DateTime DataMovimento { get; set; } = DateTime.Now;
        public string Esecutore { get; set; }

        //Costruttori
        public CashMovement() { }

        public CashMovement(double importo, string esecutore)
        {
            Importo = importo;
            Esecutore = esecutore;
            //DataMovimento l'ho impostata di default a DateTime.Now 
        }

        //Override del metodo ToString per visualizzare tutti i dati specifici di CashMovement
        public override string ToString()
        {
            return $"Cash Movement - Data: {DataMovimento.ToShortDateString()} - Importo: € {Importo} - Esecutore: {Esecutore};";
        }
    }
}

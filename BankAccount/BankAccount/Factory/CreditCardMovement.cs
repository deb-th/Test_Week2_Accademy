using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.Factory
{
    //Tipo enum per la tipolgia di card
    public enum Tipo
    {
        AMEX, VISA, MASTERCARD, OTHER
    }

    /// <summary>
    ///     Classe concreta che implementa l'interfaccia IMovement
    ///     per i movimenti bancari effettuati tramite Carta di Credito
    /// </summary>
    public class CreditCardMovement : IMovement
    {
        //Proprietà
        public double Importo { get; set; }
        public DateTime DataMovimento { get; set; } = DateTime.Now;
        public Tipo TipoCarta { get; set; }
        public string NumeroCarta { get; set; } //tipo string considerando eventuali zeri iniziali

        //Costruttori
        public CreditCardMovement() { }

        public CreditCardMovement(double importo, Tipo tipoCarta, string numeroCarta)
        {
            Importo = importo;
            TipoCarta = tipoCarta;
            NumeroCarta = numeroCarta;
            //DataMovimento l'ho impostata di default a DateTime.Now 
        }

        //Override del metodo ToString per visualizzare tutti i dati specifici di CreditCardMovement
        public override string ToString()
        {
            return $"Credit Card Movement - Data: {DataMovimento.ToShortDateString()} - Importo: € {Importo} - Tipo Carta: {TipoCarta} - Numero di Carta: {NumeroCarta};";
        }
    }

}

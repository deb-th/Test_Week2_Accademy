using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount.Factory
{
    /// <summary>
    ///     Interfaccia che rappresenta i movimenti bancari
    ///     e definisce le proprietà comuni alle diverse tipologie di movimenti
    ///     che sono implementano concretamente l'interfaccia IMovement
    /// </summary>
    public interface IMovement
    {
        double Importo { get; set; }
        DateTime DataMovimento { get; set; }
    }
}
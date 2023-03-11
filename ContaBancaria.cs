using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace NivelJunior
{
    class ContaBancaria
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria( int numero, string titular )
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria( int numero, string titular, double saldo): this(numero, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia )
        {
            Saldo += quantia;
        }
        public void Saque(double quantia )
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                +", Titular: "
                +Titular
                +", Saldo: $ "
                +Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

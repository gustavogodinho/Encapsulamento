﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course
{
    internal class Nubank
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }


        public Nubank(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Nubank(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

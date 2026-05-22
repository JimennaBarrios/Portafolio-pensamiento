using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace L14_IJBM_1059026
{
    internal class CuentaBancaria
    {
        private string titular;
        private string numeroCuenta;
        private decimal saldo;
        public CuentaBancaria(string titular, string numeroCuenta, decimal saldoInicial)
        {
            this.titular = titular;
            this.numeroCuenta = numeroCuenta;
            this.saldo = saldoInicial;
        }
        public void mostrarInformacion()
        {
            Console.WriteLine($"Titular: {titular} | No. Cuenta: {numeroCuenta} | Saldo: Q{saldo}");
        }

        public void depositar(decimal monto)
        {
            saldo += monto;
            Console.WriteLine($"Depositado: Q{monto}. Nuevo saldo: Q{saldo}");
        }

        public void retirar(decimal monto)
        {
            if (monto <= saldo)
            {
                saldo -= monto;
                Console.WriteLine($"Retirado: Q{monto}. Nuevo saldo: Q{saldo}");
            }
            else
            {
                Console.WriteLine("Fondos insuficientes.");
            }
        }
    }
}
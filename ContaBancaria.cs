using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class ContaBancaria
    {
        private double saldo;

        public void Depositar(double valor)
        {
            if (valor > 0)
                saldo += valor;
        }
        public void Sacar(double valor)
        {
            if (valor > 0)
                saldo -= valor;
        }

        public double ObterSaldo()
        {
            return saldo;
        }
    }
}
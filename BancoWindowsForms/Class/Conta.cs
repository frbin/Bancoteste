using System;
using System.Collections.Generic;
using System.Text;

namespace BancoWindowsForms
{
    public class Conta
    {   //propriedades
        public double Saldo { get; set; }
        public int NumeroConta { get; set; }
        public int Digito { get; set; }
        public string Agencia { get; set; }
        public Cliente Cliente { get; set; }


        //métodos
        public double Deposito(double valor)
        {
            double novosaldo = valor + Saldo;
            return novosaldo;
            
        }

        public double Saque(double valor1)
        {
            double novosaldo1 = Saldo - valor1;
            return novosaldo1;


        }

    }
}

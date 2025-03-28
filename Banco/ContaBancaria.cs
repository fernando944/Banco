using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaBancaria
    {
        private string _titular;
        private int _numeroDaConta;
        private double _saldo;
        private double _taxa;
        private double _bonus;

        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }
        public  int NumeroDaConta
        {
            get { return _numeroDaConta; }
            set { _numeroDaConta = value; }
        }
        public  double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        protected double Taxadesaque
        {
            get { return _taxa; }
            set { _taxa = value; }
        }

        protected double Bonusdedepossito
        {
            get { return _bonus; }
            set { _bonus = value; }
        }



        public ContaBancaria(string nome, int numeroConta, double saldo)
        {
            /*_titular = Titular;
            _numeroDaConta = NumeroDaConta;
            _saldo = Saldo;*/
            _titular = nome;
            _numeroDaConta = numeroConta;
            _saldo = saldo;
        }

        public double Saque(double valor)
        {
            if (valor > 0 && valor < Saldo) 
            {
                Saldo -= valor;
                Console.WriteLine($"saque de {valor} realizado");
            }
            else
            {
                Console.WriteLine("saque não autorizado");
            }
            return Saldo;
        }

        public double Deposito(double valor)
        {
            _saldo += valor;
            if (valor > 0)
            { 
                Console.WriteLine($"Deposito de R$ {valor}");
            }
            else
            {
                Console.WriteLine("Deposito invalido");
            }
            return Saldo;
        }
        public void MostrarSaldo()
        {
            Console.WriteLine("=========================BANCO===FXP=========================\n");
            Console.WriteLine($"ola {Titular}, sua saldo é {Saldo}");
            Console.WriteLine("=============================================================\n");
        }

    }
}


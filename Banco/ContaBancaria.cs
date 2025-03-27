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

        protected string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }
        protected int NumeroDaConta
        {
            get { return _numeroDaConta; }
            set { _numeroDaConta = value; }
        }
        protected double Saldo
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



        public ContaBancaria(string nome, int numeroDaConta, double saldo)
        {
            _titular = Titular;
            _numeroDaConta = NumeroDaConta;
            _saldo = Saldo;
        }

        public double saque(double valor)
        {
            return _saldo - (valor + Taxadesaque);
        }

        public double deposito(double valor)
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
            Console.WriteLine($"Conta - {NumeroDaConta} que tem como titular {Titular} tem saldo = {Saldo}");
            Console.WriteLine("=============================================================\n");
        }

    }
}


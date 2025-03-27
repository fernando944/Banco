using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaCorrente : ContaBancaria
    {

        private double _taxa;
        protected double Taxa
        {
            get { return _taxa; }
            set { _taxa = value; }
        }

        public ContaCorrente (string nome, int numeroDaConta, double saldo, double taxa) : base (nome, numeroDaConta, saldo)
        {
            Taxa = 5;
        }
    }
}

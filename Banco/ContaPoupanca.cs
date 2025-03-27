using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaPoupanca : ContaBancaria
    {

        private double _bonus;

        public double Bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }
      

        public ContaPoupanca (string nome, int numeroDaConta, double saldo, double bonus) : base(nome, numeroDaConta, saldo)
        {
           Bonus = 0.5;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int opsao = 1;
            while (opsao != 0)
            {
                    Console.WriteLine("Oque goatarias de fazer ");
                    Console.WriteLine("1 - Ver saldo Conta Corrente");
                    Console.WriteLine("2 - Fazer saque Conta Corrente");
                    Console.WriteLine("3 - Fazer deposito Conta Corrente");
                Console.WriteLine("4 - Ver saldo Conta Poupança");
                Console.WriteLine("5 - Fazer saque Conta Poupança");
                Console.WriteLine("6 - Fazer deposito Conta Poupança");

                Console.WriteLine("0 - Sair");
                    opsao = int.Parse(Console.ReadLine());
                ContaBancaria cc = new ContaBancaria(nome: "Fernando", numeroDaConta: 252713, saldo: 5000);
                ContaBancaria cp = new ContaBancaria(nome: "Larissa", numeroDaConta: 271312, saldo: 5000);



                switch (opsao)
                    {

                        case 1:
                        cc.MostrarSaldo();
                            break;
                        case 2:
                            {
                                Console.WriteLine($"Qual valor do saque");
                                double valorsaque = int.Parse(Console.ReadLine());
                                cc.saque(valorsaque);
                            }

                            break;
                        case 3:
                            {
                                Console.WriteLine($"Qual valor do Deposito");
                                double valorDeposito = int.Parse(Console.ReadLine());
                                cc.deposito(valorDeposito);
                        }
                            break;
                    case 4:
                        cp.MostrarSaldo();
                        break;

                        case 5:
                        {
                            Console.WriteLine($"Qual valor do saque");
                            double valorsaque = int.Parse(Console.ReadLine());
                            cc.saque(valorsaque);
                            Console.WriteLine($"");
                        }
                        break;

                    case 6:
                        {
                            Console.WriteLine($"Qual valor do Deposito");
                            double valorDeposito = int.Parse(Console.ReadLine());
                            cc.deposito(valorDeposito);
                        }
                        break;

                    case 0:
                            Console.WriteLine($"Adeus...");
                            break;
                    }
                }

            }
        }
    }


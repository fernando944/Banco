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

            ContaBancaria cc = new ContaBancaria("fernado", 1234, 500);
            ContaBancaria cp = new ContaBancaria(nome: "Larissa", numeroConta: 271312, saldo: 5000);

            int opcao = 1;
            while (opcao != 0)
            {
                    Console.WriteLine("Oque goatarias de fazer ");
                    Console.WriteLine("1 - Ver saldo Conta Corrente");
                    Console.WriteLine("2 - Fazer saque Conta Corrente");
                    Console.WriteLine("3 - Fazer deposito Conta Corrente");
                Console.WriteLine("4 - Ver saldo Conta Poupança");
                Console.WriteLine("5 - Fazer saque Conta Poupança");
                Console.WriteLine("6 - Fazer deposito Conta Poupança");

                Console.WriteLine("0 - Sair");
                    opcao = int.Parse(Console.ReadLine());

 

                switch (opcao)
                    {

                        case 1:
                        cc.MostrarSaldo();   
                            break;
                        case 2:
                            {
                                Console.WriteLine($"Qual valor do saque");

                                double valorsaque = int.Parse(Console.ReadLine());
                                double valorpossaque = cc.Saque(valorsaque);
                                Console.WriteLine($"Saldo atual é {valorpossaque}");

                            }

                            break;
                        case 3:
                            {
                                Console.WriteLine($"Qual valor do Deposito");
                                double valorDeposito = int.Parse(Console.ReadLine());
                                cc.Deposito(valorDeposito);
                            cc.Deposito(0.5);
                        }
                            break;
                    case 4:
                        cp.MostrarSaldo();
                        break;

                        case 5:
                        {
                            Console.WriteLine($"Qual valor do saque");
                            double valorsaque = int.Parse(Console.ReadLine());
                            cc.Saque(valorsaque);
                            cc.Saque(5);
                        }
                        break;

                    case 6:
                        {
                            Console.WriteLine($"Qual valor do Deposito");
                            double valorDeposito = int.Parse(Console.ReadLine());
                            cc.Deposito(valorDeposito);
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


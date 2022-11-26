using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int senha,r;

            Console.WriteLine("Digite seu nome...");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua senha");
            senha = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Digite sua senha...");
            r = Convert.ToInt32(Console.ReadLine());

            verificador(nome, r ,senha);
            Console.ReadKey();

            int op;

            Console.WriteLine("###################");
            Console.WriteLine("#                 #");
            Console.WriteLine("# Oque deseja?    #");
            Console.WriteLine("# Calculadora -1  #");
            Console.WriteLine("# Sair - 2        #");
            Console.WriteLine("#                 #");
            Console.WriteLine("###################");

            op = Convert.ToInt32(Console.ReadLine());
            if (op == 2)
            {
                sair();
            }

            switch (op){
                case 1:
                    double op1, n1, n2;
                    Console.WriteLine("Escolha sua operação");
                    Console.WriteLine("Soma - 1");
                    Console.WriteLine("Subtração - 2");
                    Console.WriteLine("Divisão - 3");
                    Console.WriteLine("Multiplicação - 4");
                    op1 = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine("Digite o primeiro número...");
                    n1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o segundo número...");
                    n2 = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    contas(n1, n2, op1);
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;


                   
            }

            Console.ReadKey();
            
        }
        public static void contas(double n1,double n2, double op1)
        {
            double resultado = 0;

            switch(op1) {
                case 1:
                    resultado = n1 + n2;
                    Console.WriteLine(resultado);
                    break;

                case 2:
                    resultado = n1 - n2;
                    Console.WriteLine(resultado);
                    break;

                case 3:
                    resultado = n1 / n2;
                    Console.WriteLine(resultado);
                    break;

                case 4:
                    resultado = n1 * n2;
                    Console.WriteLine(resultado);
                    break;

                default:
                    Console.WriteLine("Opção inválida...");
                    break;
            }
        }
    

        public static void verificador(string nome, int r, int senha)
        {
            

            if (r == senha)
            {
                Console.WriteLine("Acesso liberado");
            }
            else
            {
                Console.WriteLine("Acesso negado");
            }

            Console.WriteLine("");
            Console.WriteLine("Bem vindo " + nome + "\n");
            

        }
        public static void sair()
        {
            Console.WriteLine("Pressione qualquer botão para sair...");
            Console.ReadLine();
            Environment.Exit(1);
        }
    }
    
}

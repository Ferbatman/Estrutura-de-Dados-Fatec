using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Exercicios_2_ao_6
    {
        static int potencia(int x, int y)
        {
            if (y == 0)            
                return 1;
            else
                return x * potencia(x, y - 1);                
            
        }
        static void cubos(int n)
        {
            if (n >= 1)
            {
                cubos(n - 1);
                Console.WriteLine(n * n * n);                
            }            
        }
        static int mdc(int x, int y)
        {
            if (x == y)
                return x;
            else if (x < y)
                return mdc(y, x);
            else
                return mdc(x - y, y);
        }
        static int fib(int n)
        {
            if (n == 0 || n == 1)
                return n;
            if (n >= 2)
                return fib(n - 1) + fib(n - 2);
            return 0;
        }

        static void bin(int n)
        {
            if (n / 2 != 0)
            {
                bin(n / 2);
            }             
            Console.Write(n % 2);
        }
        static void Main(string[] args)
        {
            int op = 0;
            while (op != 6)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1- Exercício 2 (Calcular potência)");
                Console.WriteLine("2- Exercício 3 (Elevar os números ao cubo)");
                Console.WriteLine("3- Exercício 4 (Algoritmo de Euclides)");
                Console.WriteLine("4- Exercício 5 (Fibonacci)");
                Console.WriteLine("5- Exercício 6 (Converter para binário)");
                Console.WriteLine("6- Sair");
                Console.WriteLine("\nSelecione a opção desejada: ");
                op = Convert.ToInt32(Console.ReadLine());

                if (op == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira um número base: ");
                    int nb = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insira um número pra ser o expoente: ");
                    int ne = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nO resultado da potência é de " + potencia(nb, ne));
                    Console.WriteLine();
                }

                else if (op == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira um número: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    cubos(n);
                    Console.WriteLine();
                }

                else if (op == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira o primeiro número: ");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insira o segundo número: ");
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nO máximo divisor comum entre esses dois números é " + mdc(n1, n2));
                    Console.WriteLine();
                }

                else if (op == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira um número: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine(fib(n));
                    Console.WriteLine();
                }


                else if (op == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira um número: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    bin(n);                   
                    Console.WriteLine();
                    Console.WriteLine();
                    
                }
            }
        }
    }
}

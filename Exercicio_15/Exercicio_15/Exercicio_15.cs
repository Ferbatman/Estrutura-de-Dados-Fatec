using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_15
{
    internal class Exercicio_15
    {
        const int MAX = 20;

        static void Insere(int[] q, ref int f, int v)
        {
            q[f] = v;
            f = f + 1;
        }

        static int Remove(int[] q, ref int i)
        {
            return (q[i++]);
        }

        static bool EstaVazia(int i, int f)
        {
            if (i == f)
                return true;
            else
                return false;
        }

        static bool EstaCheia(int f)
        {
            if (f == MAX)
                return true;
            else
                return false;
        }

        static int QtdAvioes(int f, int i)
        {
            return f - i;
        }

        static void ListaAvioes(int[] q, int i,int f)
        {
            int j;
            for (j = i; j < f; j++)
            Console.WriteLine(q[j]);
        }

        static int PrimeiraDaFila(int[] q, int i)
        {
            return q[i];
        }

        static void Main(string[] args)
        {
            int[] fila = new int[MAX];
            int inicio = 0, fim = 0;
            string op = "0";

            while (op != "6")
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1 - Adiciona na fila");
                Console.WriteLine("2 - Consulta a quantidade de aviões");
                Console.WriteLine("3 - Autoriza a decolagem");
                Console.WriteLine("4 - Lista os aviões");
                Console.WriteLine("5 - Consulta o primeiro da fila");
                Console.WriteLine("6 - Sair");
                Console.WriteLine("\nDigite a opção desejada:");
                op = Console.ReadLine();

                if (op == "1")
                {
                    Console.WriteLine("\nNumero do avião: ");
                    int aviao;
                    aviao = int.Parse(Console.ReadLine());
                    if (EstaCheia(fim) == false)
                        Insere(fila, ref fim, aviao);
                    else
                        Console.WriteLine("Fila Cheia");
                }

                else if (op == "2")
                {
                    int qtd = QtdAvioes(fim, inicio);
                    Console.WriteLine("A quantidade de aviões é " + qtd);
                }

                else if (op == "3")
                {
                    int aviao;
                    aviao = Remove(fila, ref inicio);
                    Console.WriteLine("\nAvião que decolou " + aviao);
                }

                else if (op == "4")
                {
                    ListaAvioes(fila, inicio, fim);
                }

                else if (op == "5")
                {
                    Console.WriteLine(PrimeiraDaFila(fila, inicio));
                }
            }

        }
    }
}

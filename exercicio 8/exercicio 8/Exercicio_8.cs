using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_8
{
    internal class Exercicio_8
    {
        const int MAX = 20;

        static void Insere(int[] p, ref int t, int v)
        {
            p[t] = v;
            t = t + 1;
        }

        static int Remove(int[] p, ref int t)
        {
            t = t - 1;
            return (p[t]);
        }

        static bool EstaVazia(int t)
        {
            if (t == 0)
                return true;
            else
                return false;
        }

        static bool EstaCheia(int t)
        {
            if (t == MAX)
                return true;
            else
                return false;
        }



        static void Main(string[] args)
        {
            int[] pilha = new int[MAX];
            int topo = 0, n;

            Console.WriteLine("Digite um número: ");
            n = Convert.ToInt32(Console.ReadLine());

            while(n != 0)
            {
                Insere(pilha, ref topo, n % 2);
                n /= 2;
            }

            string bin = "";
            while(EstaVazia(topo) == false)
            {
                bin += Remove(pilha, ref topo);
            }
            Console.WriteLine(bin);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_14
{
    internal class Exercicio_14
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

        static void Main(string[] args)
        {
            int[] fila = new int[MAX];
            int inicio = 0, fim = 0, maior = -999, menor = 999; 
            double soma = 0;

            Console.WriteLine("Quantos numeros quer adicionar? ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine("\nInsira um valor: ");
                int n1 = int.Parse(Console.ReadLine());
                Insere(fila, ref fim, n1);
            }
            
            for (int i = inicio; i < fim; i++)
            {
                int n2 = Remove(fila, ref inicio);
                if (maior < n2)
                    maior = n2;
                
                if (menor > n2)
                    menor = n2;
                
                soma += n2;
            }
            double media = soma / numero;
            Console.WriteLine($"\nO maior número da fila é {maior}");
            Console.WriteLine($"\nO menor número da fila é {menor}");
            Console.WriteLine($"\nA média dos número da fila é {media:F2}");
            Console.ReadKey();
        }
    }
}

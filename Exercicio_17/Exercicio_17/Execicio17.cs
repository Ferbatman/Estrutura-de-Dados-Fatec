using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_17
{
    internal class Execicio17
    {
        class tp_no
        {
            public int valor;
            public tp_no prox;
        }

        static void Insere(ref tp_no t, int v)
        {
            tp_no no = new tp_no();
            no.valor = v;
            if (t != null)
                no.prox = t;
            t = no;
        }

        static tp_no Remove(ref tp_no t)
        {
            tp_no no = null;
            if (t != null)
            {
                no = t;
                t = t.prox;
                no.prox = null;
            }
            return no;
        }

        static void Main(string[] args)
        {
            tp_no topo = null;
            int op = 0;

            while (op != 3)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1- Inserir");
                Console.WriteLine("2- Remover");
                Console.WriteLine("3- Sair");
                Console.WriteLine("\nSelecione a opção desejada: ");
                op = Convert.ToInt32(Console.ReadLine());


                if (op == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira um valor");
                    int valor = Convert.ToInt32(Console.ReadLine());
                    Insere(ref topo, valor);
                }

                else if (op == 2)
                {
                    tp_no no = Remove(ref topo);
                    if (no != null)
                        Console.WriteLine($"O valor removido foi de {no.valor}");
                    else
                        Console.WriteLine("O valor está nulo");
                }
            }
        }
    }
}

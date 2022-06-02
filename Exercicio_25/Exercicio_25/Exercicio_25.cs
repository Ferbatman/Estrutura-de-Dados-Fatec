using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_25
{
    internal class Exercicio_25
    {
        class tp_no
        {
            public int valor;
            public tp_no esq, dir;
        }

        static void Insere(ref tp_no r, int x)
        {
            if (r == null)
            {
                r = new tp_no();
                r.valor = x;
            }
            else if (x < r.valor)
                Insere(ref r.esq, x);
            else
                Insere(ref r.dir, x);
        }

        static tp_no Busca(tp_no r, int x)
        {
            if (r == null)
            {
                Console.WriteLine("Valor não encontrado!");
                Console.ReadKey();
                return null;
            }
            else if (x == r.valor)
            {
                Console.WriteLine("Valor encontrado!");
                Console.ReadKey();
                return r;
            }
            else if (x < r.valor)
                return Busca(r.esq, x);
            else
                return Busca(r.dir, x);
        }

        static tp_no RetornaMaior(ref tp_no r)
        {
            if (r.dir == null)
            {
                tp_no p = r;
                r = r.esq;
                return p;
            }
            else
                return RetornaMaior(ref r.dir);
        }

        static tp_no Remove(ref tp_no r, int x)
        {
            if (r == null)
            {
                Console.WriteLine("Valor não encontrado!");
                Console.ReadKey();
                return null;
            }
            else if (x == r.valor)
            {
                tp_no p = r;
                if (r.esq == null)        // nao tem filho esquerdo
                    r = r.dir;
                else if (r.dir == null)  // nao tem filho direito
                    r = r.esq;
                else                          // tem ambos os filhos
                {
                    p = RetornaMaior(ref r.esq);
                    r.valor = p.valor;
                }
                Console.WriteLine("Valor encontrado!");
                Console.ReadKey();
                return p;
            }
            else if (x < r.valor)
                return Remove(ref r.esq, x);
            else
                return Remove(ref r.dir, x);
        }

        static void EmOrdem(tp_no r)
        {
            if (r != null)
            {
                EmOrdem(r.esq);
                Console.Write(r.valor + " ");
                EmOrdem(r.dir);
            }
        }


        static void Main(string[] args)
        {
            tp_no raiz = null;
            int numero;
            int op = 0;

            while (op != 5)
            {
                Console.Clear();

                Console.WriteLine("MENU");
                Console.WriteLine("1- Inserir");
                Console.WriteLine("2- Pesquisar");
                Console.WriteLine("3- Remover");
                Console.WriteLine("4- Exibir todos valores");
                Console.WriteLine("5- Sair");
                Console.WriteLine("\nSelecione a opção desejada: ");
                op = Convert.ToInt32(Console.ReadLine());


                if (op == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira um valor: ");
                    numero = int.Parse(Console.ReadLine());
                    Insere(ref raiz, numero);
                }

                else if (op == 2)
                {
                    Console.WriteLine("\nInsira um valor para pesquisar: ");
                    numero = int.Parse(Console.ReadLine());
                    Busca(raiz, numero);
                }

                else if (op == 3)
                {
                    Console.WriteLine("\nInsira um valor para remover");
                    numero = int.Parse(Console.ReadLine());
                    Remove(ref raiz, numero);                    
                }

                else if (op == 4)
                {
                    Console.WriteLine("\nValores em ordem:");
                    Console.WriteLine();
                    EmOrdem(raiz);
                    Console.ReadKey();
                }

            }
        }
    }
}

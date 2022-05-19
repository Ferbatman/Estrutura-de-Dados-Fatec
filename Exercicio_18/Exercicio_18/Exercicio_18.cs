using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_18
{
    internal class Exercicio_18
    {
        class tp_no
        {
            public string nome;
            public string idade;
            public string sexo;
            public tp_no prox;
        }

        static void Insere(ref tp_no t, string n, string i, string s)
        {
            tp_no no = new tp_no();
            no.nome = n;
            no.idade = i;
            no.sexo = s;
            if (t != null)
                no.prox = t;
            t = no;
        }

        static void consulta(tp_no t, string n, ref tp_no atu, ref tp_no ant)
        {
            atu = t;
            ant = null;
            while (atu != null && n!= atu.nome)
            {
                ant = atu;
                atu = atu.prox;
            }
        }

        static void alterar(tp_no t, string n)
        {
            tp_no atu = null;
            tp_no ant = null;

            consulta(t, n, ref atu, ref ant);
            if (atu != null)
            {
                Console.WriteLine("\nDados atuais:");
                Console.WriteLine($"Nome {atu.nome}");
                Console.WriteLine($"Idade {atu.idade}");
                Console.WriteLine($"Sexo {atu.sexo}");
                Console.WriteLine("\nDigite novos dados");
                Console.WriteLine("Nome:");
                atu.nome = Console.ReadLine();
                Console.WriteLine("Idade:");
                atu.idade = Console.ReadLine();
                Console.WriteLine("Sexo:");
                atu.sexo = Console.ReadLine();
            }
            else
                Console.WriteLine("Não encontrado");
        }

        static void excluir(ref tp_no t, string n)
        {
            tp_no atu, ant;
            ant = null;
            atu = null;
            
            consulta(t, n, ref atu, ref ant);
            if(atu != null)
            {
                if (t == atu)
                {
                    t = atu.prox;
                    atu.prox = null;
                }

                else if (atu.prox == null)
                    ant.prox = null;

                else
                {
                    ant.prox = atu.prox;
                    atu.prox = null;
                }

            }

            else
                Console.WriteLine("Não encontrado");
        }

        static void exibir(tp_no t)
        {
            tp_no aux = t;
            while (aux != null)
            {
                Console.WriteLine($"\nNome {aux.nome}");
                Console.WriteLine($"Idade {aux.idade}");
                Console.WriteLine($"Sexo {aux.sexo}");
                aux = aux.prox;
            }
        }


        static void Main(string[] args)
        {
            tp_no topo = null;
            int op = 0;

            while (op != 5)
            {
                Console.Clear();

                Console.WriteLine("MENU");
                Console.WriteLine("1- Inserir");
                Console.WriteLine("2- Alterar");
                Console.WriteLine("3- Excluir");
                Console.WriteLine("4- Exibir todos valores");
                Console.WriteLine("5- Sair");
                Console.WriteLine("\nSelecione a opção desejada: ");
                op = Convert.ToInt32(Console.ReadLine());


                if (op == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Insira um Nome");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Insira uma Idade");
                    string idade = Console.ReadLine();
                    Console.WriteLine("Insira um Sexo");
                    string sexo = Console.ReadLine();
                    Insere(ref topo, nome, idade, sexo);
                }

                else if (op == 2)
                {
                    Console.WriteLine("Insira um nome para alterar");
                    string nome = Console.ReadLine();
                    alterar(topo, nome);
                }

                else if (op == 3)
                {
                    Console.WriteLine("\nInsira um nome para excluir");
                    string nome = Console.ReadLine();
                    excluir(ref topo, nome);
                    Console.ReadKey();
                }

                else if (op == 4)
                {
                    exibir(topo);
                    Console.ReadKey();
                }

            }
        }
    }
}

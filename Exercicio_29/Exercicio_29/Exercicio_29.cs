using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_29
{
    internal class Exercicio_29
    {
        const int N = 5;
             
        class tpno
        {
            public int idade;
            public string nome, sexo;
            public tpno prox;
        }

        static int Hash (int c)
        {
            return (c % N);
        }

        static void CriaNos(tpno[] v)
        {
            int i;
            for (i = 0; i < N; i++)
                v[i] = new tpno();
        }

        static void InserirSemTratamento(tpno[] v)
        {
            Console.WriteLine("Insira um nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira o sexo: ");
            string sexo = Console.ReadLine();
            Console.WriteLine("Insira a idade: ");
            int idade = int.Parse(Console.ReadLine());

            v[Hash(idade)].nome = nome;
            v[Hash(idade)].sexo = sexo;
            v[Hash(idade)].idade = idade;
        }

        static void ConsultaSemTratamento(tpno[] v)
        {
            Console.WriteLine("Digite a idade que deseja buscar: ");
            int busca = int.Parse(Console.ReadLine());
            int posicao = Hash(busca);

            if (v[posicao].idade == busca)
            {
                Console.WriteLine($"Nome: {v[posicao].nome}");
                Console.WriteLine($"Idade: {v[posicao].idade}");
                Console.WriteLine($"Sexo: {v[posicao].sexo}");
            }

            else
            {
                Console.WriteLine("Não encontrado");
            }

            Console.ReadKey();
        }

        static void AlterarSemTratamento(tpno[] v)
        {
            Console.WriteLine("Digite a idade que deseja alterar o nome e sexo: ");
            int busca = int.Parse(Console.ReadLine());
            int posicao = Hash(busca);

            if (v[posicao].idade == busca)
            {
                Console.WriteLine("Insira um nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Insira o sexo: ");
                string sexo = Console.ReadLine();

                v[posicao].nome = nome;
                v[posicao].sexo = sexo;
            }

            else
            {
                Console.WriteLine("Não encontrado");
                
                Console.ReadKey();
            }

        }

        static void InserirLinear(tpno[] v)
        {
            Console.WriteLine("Insira um nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira o sexo: ");
            string sexo = Console.ReadLine();
            Console.WriteLine("Insira a idade: ");
            int idade = int.Parse(Console.ReadLine());

            int q = 0;
            int pos = Hash(idade);
            while (v[pos].idade !=0 && q <= N)
            {
                pos++;
                pos = pos % N;
                q += 1;
            }

            v[pos].nome = nome;
            v[pos].sexo = sexo;
            v[pos].idade = idade;
        }

        static void ConsultaLinear(tpno[] v)
        {
            Console.WriteLine("Insira a idade: ");
            int idade = int.Parse(Console.ReadLine());
            int pos = Hash(idade);
            int cont = 0;

            while (v[pos].idade != idade && cont <= N)
            {
                pos++;
                pos = pos % N;
                cont++;
            }
            
            if (cont <= N)
            {
                Console.WriteLine($"Nome: {v[pos].nome}");
                Console.WriteLine($"Idade: {v[pos].idade}");
                Console.WriteLine($"Sexo: {v[pos].sexo}");
            }

            else
                Console.WriteLine("Não encontrado");

            Console.ReadKey();
        }

        static void AlterarLinear(tpno[] v)
        {
            Console.WriteLine("Insira a idade que deseja alterar o nome e sexo: ");
            int idade = int.Parse(Console.ReadLine());
            int pos = Hash(idade);
            int cont = 0;

            while (v[pos].idade != idade && cont <= N)
            {
                pos++;
                pos = pos % N;
                cont++;
            }

            if (cont <= N)
            {
                Console.WriteLine("Insira um nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Insira o sexo: ");
                string sexo = Console.ReadLine();

                v[pos].nome = nome;
                v[pos].sexo = sexo;
            }

            else
            {
                Console.WriteLine("Não encontrado");
                Console.ReadKey();
            }
        }

        static void Relatar(tpno[] v)
        {
            for (int i = 0; i < N; i++)
            {
                if (v[i].idade != 0)
                {
                    Console.WriteLine($"Nome: {v[i].nome}");
                    Console.WriteLine($"Idade: {v[i].idade}");
                    Console.WriteLine($"Sexo: {v[i].sexo}");
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }

        static void InserirEncadeado(tpno[] v)
        {
            tpno pessoa = new tpno();

            Console.WriteLine("Insira um nome: ");
            pessoa.nome = Console.ReadLine();
            Console.WriteLine("Insira o sexo: ");
            pessoa.sexo = Console.ReadLine();
            Console.WriteLine("Insira a idade: ");
            pessoa.idade = int.Parse(Console.ReadLine());
            int pos = Hash(pessoa.idade);
            tpno v2 = v[pos];

            while (v[pos].prox != null)
            {
                v[pos] = v[pos].prox;
            }

            v[pos].prox = pessoa;
            v[pos] = v2;
        }

        static void ConsultaEncadeado(tpno[] v)
        {
            Console.WriteLine("Insira a idade: ");
            int idade = int.Parse(Console.ReadLine());
            int pos = Hash(idade);
            tpno v2 = v[pos];

            while (v[pos].idade != idade && v[pos].prox != null)
            {
                v[pos] = v[pos].prox;
            }

            if (v[pos].idade == idade)
            {
                Console.WriteLine($"Nome: {v[pos].nome}");
                Console.WriteLine($"Idade: {v[pos].idade}");
                Console.WriteLine($"Sexo: {v[pos].sexo}");
            }

            else
                Console.WriteLine("Não encontrado!");

            v[pos] = v2;
            Console.ReadKey();
        }

        static void AlterarEncadeado(tpno[] v)
        {
            Console.WriteLine("Insira a idade que deseja alterar o nome e sexo: ");
            int idade = int.Parse(Console.ReadLine());
            int pos = Hash(idade);
            tpno v2 = v[pos];

            while (v[pos].idade != idade && v[pos].prox != null)
            {
                v[pos] = v[pos].prox;
            }

            if (v[pos].idade == idade)
            {
                Console.WriteLine("Insira um nome: ");
                v[pos].nome = Console.ReadLine();
                Console.WriteLine("Insira o sexo: ");
                v[pos].sexo = Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Não encontrado!");
                Console.ReadKey();
            }

            v[pos] = v2;
        }

        static void RelatarEncadeado(tpno[] v)
        {
            for (int i = 0; i < N; i++)
            {
                tpno v2 = v[i];
                while (v[i].prox != null)
                {
                    v[i] = v[i].prox;

                    if (v[i].idade != 0)
                    {
                        Console.WriteLine($"Nome: {v[i].nome}");
                        Console.WriteLine($"Idade: {v[i].idade}");
                        Console.WriteLine($"Sexo: {v[i].sexo}");
                        Console.WriteLine();
                    }
                }
                v[i] = v2;
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            tpno[] vetor = new tpno[5];
            int op = 0, op2 =0;            

            while (op != 4)
            {
                CriaNos(vetor);
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("1 - Sem tratamento de colisão");
                Console.WriteLine("2 - Tratamento de colisão linear");
                Console.WriteLine("3 - Tratamento de colisão com Lista Encadeada");
                Console.WriteLine("4 - Sair");

                Console.WriteLine("\nSelecione a opção desejada: ");
                op = Convert.ToInt32(Console.ReadLine());


                if (op == 1)
                {                    
                    op2 = 0;
                    while (op2 != 5)
                    {
                        Console.Clear();
                        Console.WriteLine("MENU");
                        Console.WriteLine("1 - Inserir");
                        Console.WriteLine("2 - Consultar");
                        Console.WriteLine("3 - Alterar");
                        Console.WriteLine("4 - Relatar");
                        Console.WriteLine("5 - Sair");
                        Console.WriteLine("\nSelecione a opção desejada: ");
                        op2 = Convert.ToInt32(Console.ReadLine());

                        if (op2 == 1)
                        {
                            InserirSemTratamento(vetor);
                        }

                        else if (op2 == 2)
                        {
                            ConsultaSemTratamento(vetor);
                        }

                        else if (op2 == 3)
                        {
                            AlterarSemTratamento(vetor);
                        }

                        else if (op2 == 4)
                        {
                            Relatar(vetor);
                        }
                    }
                }

                else if (op == 2)
                {
                    op2 = 0;
                    while (op2 != 5)
                    {
                        Console.Clear();
                        Console.WriteLine("MENU");
                        Console.WriteLine("1 - Inserir");
                        Console.WriteLine("2 - Consultar");
                        Console.WriteLine("3 - Alterar");
                        Console.WriteLine("4 - Relatar");
                        Console.WriteLine("5 - Sair");
                        Console.WriteLine("\nSelecione a opção desejada: ");
                        op2 = Convert.ToInt32(Console.ReadLine());


                        if (op2 == 1)
                        {
                            InserirLinear(vetor);
                        }

                        else if (op2 == 2)
                        {
                            ConsultaLinear(vetor);
                        }

                        else if (op2 == 3)
                        {
                            AlterarLinear(vetor);
                        }

                        else if (op2 == 4)
                        {
                            Relatar(vetor);
                        }
                    }
                }

                else if (op == 3)
                {
                    op2 = 0;
                    while (op2 != 5)
                    {
                        Console.Clear();
                        Console.WriteLine("MENU");
                        Console.WriteLine("1 - Inserir");
                        Console.WriteLine("2 - Consultar");
                        Console.WriteLine("3 - Alterar");
                        Console.WriteLine("4 - Relatar");
                        Console.WriteLine("5 - Sair");
                        Console.WriteLine("\nSelecione a opção desejada: ");
                        op2 = Convert.ToInt32(Console.ReadLine());

                        if (op2 == 1)
                        {
                            InserirEncadeado(vetor);
                        }

                        else if (op2 == 2)
                        {
                            ConsultaEncadeado(vetor);
                        }

                        else if (op2 == 3)
                        {
                            AlterarEncadeado(vetor);
                        }

                        else if (op2 == 4)
                        {
                            RelatarEncadeado(vetor);
                        }
                    }
                }
            }
        }
    }
}

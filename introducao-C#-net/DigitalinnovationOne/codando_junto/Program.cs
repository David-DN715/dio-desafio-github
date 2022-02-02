using System;
using codando_junto;

namespace Revisao
{
    class Progam
    {   
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indice_aluno = 0;

            string opcaousuario = obteropcaousuario();

            while (opcaousuario.ToUpper() != "X")
            {
                switch (opcaousuario)
                {
                    case "1":
                    //TODO: adicionar aluno!
                    Console.WriteLine("Informe o nome do aluno: ");
                    Aluno aluno = new Aluno();
                    aluno.nome = Console.ReadLine();

                    Console.WriteLine("Informe a nota do aluno:");
//passamos o tryparse para verificar se podemos passar para decimalanota do aluno.
                    if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                    {   
                        aluno.nota = nota;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("A nota deve ser passadaem valor decimal!");
                    }
                    alunos[indice_aluno] = aluno;
                    indice_aluno++;

                        break;
                    case "2":
                    //TODO: Listar alunos!
                        foreach(var a in alunos)
                        //se a string nao for nula ou vazia 
                        {   if(!string.IsNullOrEmpty(a.nome))
                            {   
                                Console.WriteLine($"ALUNO: {a.nome} NOTA: {a.nota}");
                            }
                        }

                        break;
                    case "3":
                    //TODO: Calcular media geral!
                        decimal NotaTotal = 0;
                        var Nralunos = 0;

                        for(int i=0; i<alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].nome))
                            {
                                NotaTotal = NotaTotal + alunos[i].nota;
                                Nralunos++;

                            }
                        }
                        var mediaGeral = NotaTotal/Nralunos;
                        ConceitoEnum  Conceitogeral;

                        if(mediaGeral < 2)
                        {
                            Conceitogeral = ConceitoEnum.E;
                        }
                        else if (mediaGeral < 4)
                        {
                            Conceitogeral = ConceitoEnum.D;
                        }
                        else if (mediaGeral < 6)
                        {
                            Conceitogeral = ConceitoEnum.C;

                        }
                        else if (mediaGeral < 8)
                        {
                            Conceitogeral = ConceitoEnum.B;

                        }
                        else 
                        {
                            Conceitogeral = ConceitoEnum.A;

                        }

                        Console.WriteLine($"Media Geral: {mediaGeral} ------ Conceito {Conceitogeral}");

                        break; 
                    default:
                        throw new ArgumentOutOfRangeException();

                }   

                    opcaousuario = obteropcaousuario();
            }

        }
        private static string obteropcaousuario()
        {   
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - listar alunos");
            Console.WriteLine("3 - calcular media geral");
            Console.WriteLine("x - sair");
            Console.WriteLine();

            string opcaousuario = Console.ReadLine();
            Console.WriteLine();
            return opcaousuario;
        }   
    }   
}
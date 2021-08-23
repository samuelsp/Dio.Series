using System;
using Dio.Series.Classes;
using Dio.Series.Repository;

namespace Dio.Series
{
    class Program
    {
        static SerieRepositorio repository = new SerieRepositorio();

        static void Main(string[] args)
        {
            string opcao = ObterOpcaoDoUsuario();

            while(opcao.ToUpper() != "X")
            {
                switch (opcao)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSeries();
                        break;
                    case "3":
                        AtualizarSeries();
                        break;
                    case "4":
                        ExcluirSeries();
                        break;
                    case "5":
                        VisualizarSeries();
                        break;
                    case "C":
                        Console.Clear();
                        break;    
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcao = ObterOpcaoDoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
        }

        private static void AtualizarSeries()
        {
           
           Console.WriteLine("Digite o id da série: ");
           int id = int.Parse(Console.ReadLine());

           foreach (int i in Enum.GetValues(typeof(GeneroEnum)))
           {
               Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(GeneroEnum), i));
           }

           Console.Write("Digite o genêro entre as opções acima: ");
           int genero = int.Parse(Console.ReadLine());

           Console.Write("Digite o título da série: ");
           string titulo = Console.ReadLine();

           Console.Write("Digite o ano de início da série: ");
           int ano = int.Parse(Console.ReadLine());

           Console.Write("Digite a descrição da série: ");
           string descricao = Console.ReadLine();

           Serie serieAtualizada = new Serie
           (
               id: repository.NextId(),
               genero: (GeneroEnum)genero,
               titulo: titulo,
               ano: ano,
               descricao: descricao
           );

           repository.Update(id, serieAtualizada);

        }

        private static void VisualizarSeries()
        {
            Console.WriteLine("Digite o id da série: ");
            int id = int.Parse(Console.ReadLine());

            var serie = repository.GetById(id);
            Console.WriteLine(serie);

        }

        private static void ExcluirSeries()
        {
            Console.WriteLine("Digite o id da série: ");
            int id = int.Parse(Console.ReadLine());

            repository.Delete(id);
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");

            var lista = repository.List();

            if(lista.Count == 0) {
                Console.WriteLine("Nenhuma série cadastrada");
                return;
            }

            foreach (var serie in lista)
            {
                var ativo = serie.getAtivo();
                Console.WriteLine("#ID {0}: - {1} - {2}", serie.getId(), serie.getTitulo(), (ativo ? "*Ativo" : "*Inativo"));                
            }
        }

        private static void InserirSeries()
        {
           Console.WriteLine("Inserir nova série:");

           foreach (int i in Enum.GetValues(typeof(GeneroEnum)))
           {
               Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(GeneroEnum), i));
           }

           Console.Write("Digite o genêro entre as opções acima: ");
           int genero = int.Parse(Console.ReadLine());

           Console.Write("Digite o título da série: ");
           string titulo = Console.ReadLine();

           Console.Write("Digite o ano de início da série: ");
           int ano = int.Parse(Console.ReadLine());

           Console.Write("Digite a descrição da série: ");
           string descricao = Console.ReadLine();

           Serie novaSerie = new Serie
           (
               id: repository.NextId(),
               genero: (GeneroEnum)genero,
               titulo: titulo,
               ano: ano,
               descricao: descricao
           );

           repository.Insert(novaSerie);
        }

        private static string ObterOpcaoDoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries!!!");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");

            string opcao = Console.ReadLine().ToUpper();
            return opcao;            
        }
    }
}

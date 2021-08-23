
using System;
using Dio.Series.Classes;
using Dio.Series.Interfaces;
using Dio.Series.Repository;

namespace Dio.Series.Application {  
    public class AppServiceSerie : IService<Serie> {

        IRepository<Serie> repositorio = new SerieRepositorio();        
        
        public void Atualizar()
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
               id: repositorio.NextId(),
               genero: (GeneroEnum)genero,
               titulo: titulo,
               ano: ano,
               descricao: descricao
           );

           repositorio.Update(id, serieAtualizada);

        }

        public void Visualizar()
        {
            Console.WriteLine("Digite o id da série: ");
            int id = int.Parse(Console.ReadLine());

            var serie = repositorio.GetById(id);
            Console.WriteLine(serie);

        }

        public void Excluir()
        {
            Console.WriteLine("Digite o id da série: ");
            int id = int.Parse(Console.ReadLine());

            repositorio.Delete(id);
        }

        public void Listar()
        {
            Console.WriteLine("Listar séries");

            var lista = repositorio.List();

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

        public void Inserir()
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
               id: repositorio.NextId(),
               genero: (GeneroEnum)genero,
               titulo: titulo,
               ano: ano,
               descricao: descricao
           );

           repositorio.Insert(novaSerie);
        }

        public string ObterOpcaoDoUsuario()
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


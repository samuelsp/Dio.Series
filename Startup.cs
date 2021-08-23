using System;
using Dio.Series.Application;

namespace Dio.Series.Classes
{
    public static class Startup
    {       
       public static void Run() {
           AppServiceSerie service = new AppServiceSerie();
           string opcao = service.ObterOpcaoDoUsuario();

           while(opcao.ToUpper() != "X")
            {
                switch (opcao)
                {
                    case "1":
                        service.Listar();
                        break;
                    case "2":
                        service.Inserir();
                        break;
                    case "3":
                        service.Atualizar();
                        break;
                    case "4":
                        service.Excluir();
                        break;
                    case "5":
                        service.Visualizar();
                        break;
                    case "C":
                        Console.Clear();
                        break;    
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcao = service.ObterOpcaoDoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();

       }
            

    }

}
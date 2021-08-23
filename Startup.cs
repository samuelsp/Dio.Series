using System;
using Dio.Series.Interfaces;

namespace Dio.Series.Classes
{
    public class Startup
    {
       private readonly IServiceSerie service;
        
       public Startup(IServiceSerie service)
       {
           this.service = service;
       }       
       public void Run() {
           
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
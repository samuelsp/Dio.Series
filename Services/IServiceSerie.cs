using Dio.Series.Models;

namespace Dio.Series.Interfaces {
    public interface IServiceSerie : IService<Serie> {
        string ObterOpcaoDoUsuario();
    }
}
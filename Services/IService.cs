namespace Dio.Series.Interfaces
{
    public interface IService<T>
    {
         void Atualizar();
         void Visualizar();
         void Excluir();
         void Listar();
         void Inserir();
        
    }
}
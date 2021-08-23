using System.Collections.Generic;

namespace Dio.Series.Repository {
    public interface IRepository<T> {
        List<T> List();
        T GetById(int id);
        void Insert(T entity);
        void Delete(int id);
        void Update(int id, T entity);
        int NextId();
    }

}
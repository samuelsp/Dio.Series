using System.Collections.Generic;
using Dio.Series.Classes;
using Dio.Series.Interfaces;

namespace Dio.Series.Repository {
    public class SerieRepositorio : IRepository<Serie> {
        
        private List<Serie> list = new List<Serie>();
        
        public void Delete(int id)
        {
            list[id].setAtivo();
        }

        public  Serie GetById(int id)
        {
            return list[id];
        }

        public  void Insert(Serie entity)
        {
            list.Add(entity);
        }

        public List<Serie> List()
        {
            return list;
        }

        public int NextId()
        {
            return list.Count;
        }

        public void Update(int id, Serie entity)
        {
           list[id] = entity;
        }
    }
}
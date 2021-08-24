using System;
using System.Collections.Generic;
using System.Linq;
using Dio.Series.Infra;
using Dio.Series.Models;

namespace Dio.Series.Repository {
    public class SerieRepository : IRepositorySerie {
        
        private readonly Context context;

        public SerieRepository(Context context)
        {
            this.context = context;
        }
              
        public void Delete(int id)
        {
            try 
            {
                var serie = context.Serie.Find(id);
                
                if(serie != null) 
                {
                    context.Serie.Remove(serie);
                    context.SaveChanges();
                }
            }

            catch (Exception e) {
                throw new Exception(e.Message);
            }
        }

        public  Serie GetById(int id)
        {
            try 
            {
                var serie = context.Serie.Find(id);
                return serie;
            }
            catch (Exception e) {
                throw new Exception(e.Message);
            }
        }

        public  void Insert(Serie entity)
        {
            try 
            {
                context.Serie.Add(entity);
                context.SaveChanges();
            }
            catch (Exception e) {
                throw new Exception(e.Message);
            }
        }

        public List<Serie> List()
        {
           return context.Serie.ToList();
        }

        public int NextId()
        {
            return List().Count;
        }

        public void Update(int id, Serie entity)
        {
            try
            {
                var serie = context.Serie.Find(id);
                    
                if(serie != null) 
                {
                    context.Serie.Update(serie);
                    context.SaveChanges();
                }
                
            }
            catch (Exception e)
            {                
                throw new Exception(e.Message);
            }
           
        }
    }
}
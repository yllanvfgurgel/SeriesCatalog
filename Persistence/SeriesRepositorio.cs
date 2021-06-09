using System.Collections.Generic;
using SeriesCatalog.Models;
using SeriesCatalog.Persistence;

namespace Persistence {
    class SeriesRepositorio : IRepository<Serie>
    { 
        private List<Serie> ListaSeries = new List<Serie>();
        public void Create(Serie entity)
        {
            ListaSeries.Add(entity);
        }

        public List<Serie> GetAll()
        {
            return ListaSeries;
        }

        public Serie GetById(int id)
        {
            return ListaSeries[id];
        }

        public int NextId()
        {
            return ListaSeries.Count;
        }

        public void Remove(int id)
        {
            ListaSeries[id].Excluir();
        }

        public void Update(int id, Serie entity)
        {
            ListaSeries[id] = entity;
        }
    }
}
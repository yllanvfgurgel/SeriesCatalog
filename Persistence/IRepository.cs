using System.Collections.Generic;

namespace SeriesCatalog.Persistence
{
    public interface IRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
        void Update(int id, T entity);
        void Create(T entity);
        void Remove(int id);
        int NextId();
    }
}
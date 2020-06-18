using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
         void Add(TEntity obj);

        TEntity GetById(long id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);
        
        void Remove(TEntity obj);
        
        void Dispose();
    }
}

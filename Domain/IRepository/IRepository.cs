using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);

       Task<IEnumerable<T>> GetAll(string includeProperties = null);

        void Update(T entity);

        void Add(T entity);

        void Remove(int id);
    }
}

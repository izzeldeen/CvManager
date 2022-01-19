using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IService
{
   public  interface IService<T> where T : class
    {
        T Get(int id);

        Task<IEnumerable<T>> GetAll();

        bool Update(T entity);

        bool Add(T entity);

        bool Remove(int id);

    }
}

using Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class Repositroy<T> : IRepository<T> where T : class
    {

        private readonly StoreContext _db;
        internal DbSet<T> dbSet;

        public Repositroy(StoreContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();


        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        public async  Task<IEnumerable<T>> GetAll(string includeProperties = null)
        {
            IQueryable<T> query = dbSet;

            if (includeProperties != null)
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);

                }
            }

            return await query.ToListAsync();
        }

        public void Remove(int id)
        {
            T entity = dbSet.Find(id);
             dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }
    }
}

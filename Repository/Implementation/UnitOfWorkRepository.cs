using Domain.IRepository;
using Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {

        private readonly StoreContext _context;

        public UnitOfWorkRepository(StoreContext context)
        {
            _context = context;
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

using Domain.Entities;
using Domain.IRepository;
using Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class CvRepository : Repositroy<Cv>, ICvRepository
    {
        public CvRepository(StoreContext context) : base(context)
        {
        }
    }
}

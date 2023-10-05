using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data.Configuration;

namespace Infrastructure.Repositories
{
    public class PaisRepo : GenericRepository<Pais>, IPais
    {
        private readonly AnimalContext _context;

        public PaisRepo(AnimalContext context) : base(context)
        {
            _context = context;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data.Configuration;

namespace Infrastructure.Repositories
{
    public class ClienteRepo : GenericRepository<Cliente>, ICliente
    {
        private readonly AnimalContext _context;

        public ClienteRepo(AnimalContext context) : base(context)
        {
            _context = context;
        }
    }
}
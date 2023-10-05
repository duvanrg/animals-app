using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data.Configuration;

namespace Infrastructure.Repositories
{
    public class MascotaRepo : GenericRepository<Mascota>, IMascota
    {
        private readonly AnimalContext _context;

        public MascotaRepo(AnimalContext context) : base(context)
        {
            _context = context;
        }
    }
}
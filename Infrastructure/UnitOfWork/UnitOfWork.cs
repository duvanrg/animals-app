using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure.Data.Configuration;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public AnimalContext _context { get; }

        public UnitOfWork(AnimalContext context)
        {
            _context = context;
        }
        
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<int> saveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
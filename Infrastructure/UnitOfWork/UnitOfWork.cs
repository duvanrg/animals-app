using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure.Data.Configuration;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly AnimalContext _context;
    private PaisRepo _paises;

    public UnitOfWork(AnimalContext context)
    {
        _context = context;

    }

    public IPais Paises
    {
        get
        {
            if (_paises == null)
            {
                _paises = new PaisRepo(_context);
            }
            return _paises;
        }
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}

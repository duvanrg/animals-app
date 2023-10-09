using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data.Configuration;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly AnimalContext _context;
    private CitaRepo _Citas;
    private CiudadRepo _Ciudades;
    private ClienteRepo _Clientes;
    private ClienteDireccionRepo _ClienteDirecciones;
    private ClienteTelefonoRepo _ClienteTelefonos;
    private DepartamentoRepo _Departamentos;
    private MascotaRepo _Mascotas;
    private PaisRepo _paises;
    private RazaRepo _Razas;
    private ServicioRepo _Servicios;

    public UnitOfWork(AnimalContext context)
    {
        _context = context;

    }

    public ICita Citas
    {
        get
        {
            if (_Citas == null)
            {
                _Citas = new CitaRepo(_context);
            }
            return _Citas;
        }
    }
    public ICiudad Ciudades
    {
        get
        {
            if (_Ciudades == null)
            {
                _Ciudades = new CiudadRepo(_context);
            }
            return _Ciudades;
        }
    }
    public ICliente Clientes
    {
        get
        {
            if (_Clientes == null)
            {
                _Clientes = new ClienteRepo(_context);
            }
            return _Clientes;
        }
    }
    public IClienteDireccion ClienteDirecciones
    {
        get
        {
            if (_ClienteDirecciones == null)
            {
                _ClienteDirecciones = new ClienteDireccionRepo(_context);
            }
            return _ClienteDirecciones;
        }
    }
    public IClienteTelefono ClienteTelefonos
    {
        get
        {
            if (_ClienteTelefonos == null)
            {
                _ClienteTelefonos = new ClienteTelefonoRepo(_context);
            }
            return _ClienteTelefonos;
        }
    }
    public IDepartamento Departamentos
    {
        get
        {
            if (_Departamentos == null)
            {
                _Departamentos = new DepartamentoRepo(_context);
            }
            return _Departamentos;
        }
    }
    public IMascota Mascotas
    {
        get
        {
            if (_Mascotas == null)
            {
                _Mascotas = new MascotaRepo(_context);
            }
            return _Mascotas;
        }
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
    public IRaza Razas
    {
        get
        {
            if (_Razas == null)
            {
                _Razas = new RazaRepo(_context);
            }
            return _Razas;
        }
    }
    public IServicio Servicios
    {
        get
        {
            if (_Servicios == null)
            {
                _Servicios = new ServicioRepo(_context);
            }
            return _Servicios;
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

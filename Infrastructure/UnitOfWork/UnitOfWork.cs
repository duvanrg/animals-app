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
    private CitaRepo _citas;
    private CiudadRepo _ciudades;
    private ClienteRepo _clientes;
    private ClienteDireccionRepo _clienteDirecciones;
    private ClienteTelefonoRepo _clienteTelefonos;
    private DepartamentoRepo _departamentos;
    private MascotaRepo _mascotas;
    private PaisRepo _paises;
    private RazaRepo _razas;
    private ServicioRepo _servicios;

    public UnitOfWork(AnimalContext context)
    {
        _context = context;

    }

    public ICita Citas
    {
        get
        {
            if (_citas == null)
            {
                _citas = new CitaRepo(_context);
            }
            return _citas;
        }
    }
    public ICiudad Ciudades
    {
        get
        {
            if (_ciudades == null)
            {
                _ciudades = new CiudadRepo(_context);
            }
            return _ciudades;
        }
    }
    public ICliente Clientes
    {
        get
        {
            if (_clientes == null)
            {
                _clientes = new ClienteRepo(_context);
            }
            return _clientes;
        }
    }
    public IClienteDireccion ClienteDirecciones
    {
        get
        {
            if (_clienteDirecciones == null)
            {
                _clienteDirecciones = new ClienteDireccionRepo(_context);
            }
            return _clienteDirecciones;
        }
    }
    public IClienteTelefono ClienteTelefonos
    {
        get
        {
            if (_clienteTelefonos == null)
            {
                _clienteTelefonos = new ClienteTelefonoRepo(_context);
            }
            return _clienteTelefonos;
        }
    }
    public IDepartamento Departamentos
    {
        get
        {
            if (_departamentos == null)
            {
                _departamentos = new DepartamentoRepo(_context);
            }
            return _departamentos;
        }
    }
    public IMascota Mascotas
    {
        get
        {
            if (_mascotas == null)
            {
                _mascotas = new MascotaRepo(_context);
            }
            return _mascotas;
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
            if (_razas == null)
            {
                _razas = new RazaRepo(_context);
            }
            return _razas;
        }
    }
    public IServicio Servicios
    {
        get
        {
            if (_servicios == null)
            {
                _servicios = new ServicioRepo(_context);
            }
            return _servicios;
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

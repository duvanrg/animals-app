namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        ICita Citas { get; }
        ICiudad Ciudades { get; }
        ICliente Clientes { get; }
        IClienteDireccion ClienteDirecciones { get; }
        IClienteTelefono ClienteTelefonos { get; }
        IDepartamento Departamentos { get; }
        IMascota Mascotas { get; }
        IPais Paises { get; }
        IRaza Razas { get; }
        IServicio Servicios { get; }
        Task<int> SaveAsync();
    }
}
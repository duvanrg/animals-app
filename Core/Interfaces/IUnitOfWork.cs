namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        IPais Paises { get; }
        Task<int> SaveAsync(); 
    }
}
namespace ST.Infraestructure.Persistencies.Interfaces
{
    public interface IUnityOfWork : IDisposable
    {
        ILibrosRepositories libros { get; }
        Task SaveChangesAsync();
    }
}

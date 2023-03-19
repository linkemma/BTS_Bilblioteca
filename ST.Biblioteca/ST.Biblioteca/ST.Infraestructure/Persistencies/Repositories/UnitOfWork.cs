using ST.Infraestructure.Persistencies.Context;
using ST.Infraestructure.Persistencies.Interfaces;

namespace ST.Infraestructure.Persistencies.Repositories
{
    public class UnitOfWork : IUnityOfWork
    {
        private readonly BD_Browser_TravelContext _context;

        public ILibrosRepositories libros { get; private set; }

        public UnitOfWork(BD_Browser_TravelContext context)
        {
            _context = context;
            libros = new LibrosRepositories(_context);
        }


        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

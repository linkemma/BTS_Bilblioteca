using ST.Infraestructure.Commons.Base.Request;
using ST.Infraestructure.Commons.Base.Response;

namespace ST.Infraestructure.Persistencies.Interfaces
{
    public interface ILibrosRepositories
    {
        Task<IEnumerable<LibroResponse>> ListaLibros();
        Task<LibroResponse> LibroId(Int64 libroId);
    }
}

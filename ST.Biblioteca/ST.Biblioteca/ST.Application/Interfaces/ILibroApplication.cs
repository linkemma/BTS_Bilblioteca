using ST.Application.Commons.Base;
using ST.Application.DTOs.Libro.Request;
using ST.Application.DTOs.Libro.Response;

namespace ST.Application.Interfaces
{
    public interface ILibroApplication
    {
        Task<BaseResponse<IEnumerable<LibroResponseDTo>>> ListaLibros();
        Task<BaseResponse<LibroResponseDTo>> LibroId(LibroRequestDTo requestDTo);
    }
}

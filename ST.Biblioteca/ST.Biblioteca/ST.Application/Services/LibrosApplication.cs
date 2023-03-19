using AutoMapper;
using ST.Application.Commons.Base;
using ST.Application.DTOs.Libro.Request;
using ST.Application.DTOs.Libro.Response;
using ST.Application.Interfaces;
using ST.Application.Validator;
using ST.Infraestructure.Persistencies.Interfaces;
using ST.Utilities.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST.Application.Services
{
    public class LibrosApplication : ILibroApplication
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;
        private readonly LibroValidator _validationRules;

        public LibrosApplication(IUnityOfWork unityOfWork, IMapper mapper, LibroValidator validationRules)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
            _validationRules = validationRules;
        }

        public async Task<BaseResponse<IEnumerable<LibroResponseDTo>>> ListaLibros()
        {
            var response = new BaseResponse<IEnumerable<LibroResponseDTo>>();
            var libros = await _unityOfWork.libros.ListaLibros();

            if (libros is not null)
            {
                response.IsSuccess = true;
                response.Data = _mapper.Map<IEnumerable<LibroResponseDTo>>(libros);
                response.Message = ReplyMessage.MESSAGE_QUERY;
            }
            else
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_QUERY_EMPY;
            }
            return response;
        }

        public async Task<BaseResponse<LibroResponseDTo>> LibroId(LibroRequestDTo requestDTo)
        {
            var response = new BaseResponse<LibroResponseDTo>();
            var validationResult = await _validationRules.ValidateAsync(requestDTo);

            if (!validationResult.IsValid)
            {
                response.Message = ReplyMessage.MESSAGE_VALIDATE;
                response.Errors = validationResult.Errors;
                return response;
            }

            var libro = await _unityOfWork.libros.LibroId(requestDTo.Isbn);

            if (libro is not null)
            {
                response.IsSuccess = true;
                response.Data = _mapper.Map<LibroResponseDTo>(libro);
                response.Message = ReplyMessage.MESSAGE_QUERY;
            }
            else
            {
                response.IsSuccess = false;
                response.Message = ReplyMessage.MESSAGE_QUERY_EMPY;
            }
            return response;
        }
    }
}

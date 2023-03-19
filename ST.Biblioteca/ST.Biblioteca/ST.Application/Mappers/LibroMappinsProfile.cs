using AutoMapper;
using ST.Application.DTOs.Libro.Response;
using ST.Infraestructure.Commons.Base.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST.Application.Mappers
{
    public class LibroMappinsProfile: Profile
    {
        public LibroMappinsProfile()
        {
            CreateMap<LibroResponse, LibroResponseDTo>();
            CreateMap<LibroResponseDTo, LibroResponse>();
        }
    }
}

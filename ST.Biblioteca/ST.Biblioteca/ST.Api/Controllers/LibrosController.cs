using Microsoft.AspNetCore.Mvc;
using ST.Application.DTOs.Libro.Request;
using ST.Application.Interfaces;

namespace ST.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private readonly ILibroApplication _librosApplication;

        public LibrosController(ILibroApplication librosApplication)
        {
            _librosApplication = librosApplication;
        }

        [HttpGet("Lista")]
        public async Task<IActionResult> ListaLibros()
        {
            try
            {
                var response = await _librosApplication.ListaLibros();
                return Ok(response);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> LibroId([FromBody] LibroRequestDTo request)
        {
            try
            {
                var response = await _librosApplication.LibroId(request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }
}

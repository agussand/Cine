using CineBack.Entidades;
using CineBack.Fachada.Implementacion;
using CineBack.Fachada.Interfaz;
using Microsoft.AspNetCore.Mvc;

namespace CineAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : Controller
    {
        IClientesAplicacion app = null;

        public ClientesController()
        {
            app = new ClientesAplicacion();
        }

        [HttpPost ("/RegistrarCliente/")]

        public IActionResult RegistrarCliente(Usuario cliente)
        {
            try
            {
                if (cliente == null) 
                {
                    return BadRequest("Cliente incorrecto");
                }
                return Ok(app.RegistrarCliente(cliente));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno. Intente luego");
            }
        }

        [HttpGet ("/usuario")]

        public IActionResult UsuarioExistente(string usuario)
        {
            try
            {
                if (string.IsNullOrEmpty(usuario))
                {
                    return BadRequest("Usuario mal ingresado");
                }
                return Ok(app.UsuarioExistente(usuario));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno. Intente luego nuevamente");
            }
        }

        [HttpGet ("/login")]

        public IActionResult LogearCliente(string usuario, string pass)
        {
            try
            {
                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(pass))
                {
                    return BadRequest("Datos incorrectos");
                }
                return Ok(app.LogearCliente(usuario, pass));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno. Intente luego nuevamente");
            }
        }
    }
}

using CineBack.Entidades;
using CineBack.Fachada.Implementacion;
using CineBack.Fachada.Interfaz;
using Microsoft.AspNetCore.Mvc;

namespace CineAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionesController : Controller
    {
        private IFuncionesAplicacion app;

        public FuncionesController()
        {
            app = new FuncionesAplicacion();
        }

        [HttpPost ("/nuevaVenta")]
        public IActionResult ConfirmarVenta(Venta venta)
        {
            try
            {
                if (venta == null)
                {
                    return BadRequest("Venta incorrecta!");
                }
                return Ok(app.ConfirmarVenta(venta));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno. Intente nuevamente");
            }
        }

        [HttpGet("/peliculas")]

        public IActionResult GetPeliculas()
        {
            List<Pelicula> lPeliculas;
            try
            {
                lPeliculas = app.GetPeliculas();
                return Ok(lPeliculas);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno. Intente nuevamente");
            }
        }

        [HttpGet("/funciones/")]

        public IActionResult GetFunciones([FromQuery] int pelicula)
        {
            List<Funcion> lFunciones;
            try
            {
                lFunciones = app.GetFunciones(pelicula);
                return Ok(lFunciones);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno. Intente nuevamente");
            }
        }

        [HttpGet("/butacas/")]

        public IActionResult GetButacas([FromQuery] int sala, [FromQuery] int funcion)
        {
            List<Butaca> lButacas;
            try
            {
                lButacas = app.GetButacas(sala, funcion);
                return Ok(lButacas);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno. Intente nuevamente");
            }
        }

        [HttpGet("/butacas/estado")]
        public IActionResult ButacasDisponibles([FromQuery] int id_funcion, [FromQuery] int cantidad)
        {
            bool resultado;
            try
            {
                resultado = app.ButacasDisponibles(id_funcion, cantidad);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno. Intente nuevamente");
            }
        }

        [HttpPost("/peliculaNueva/")]

        public IActionResult NuevaFuncion(Funcion oFuncion)
        {
            try
            {
                if (oFuncion == null)
                {
                    return BadRequest("Funcion Invalida!!!");
                }
                return Ok(app.CrearFuncion(oFuncion));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno!! Intente mas tarde...");
            }
        }

    }
}

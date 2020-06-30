using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Reflection;
using WebApi.Logica;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        string mensajeError = "";

        // GET: api/Producto
        [HttpGet]
        public ActionResult<List<ProductoEN>> GetProductos()
        {
            ProductoLN productoLN = new ProductoLN();

            List<ProductoEN> lista = productoLN.ListarProductos(out mensajeError);

            if (!string.IsNullOrWhiteSpace(mensajeError))
            {
                Console.WriteLine(mensajeError + "\r\n" + GetType() + " - " + MethodBase.GetCurrentMethod().Name);

                return BadRequest();
            }

            return Ok(lista);
        }

        // GET: api/Producto/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<ProductoEN> Get(Int64 id)
        {
            ProductoLN productoLN = new ProductoLN();

            ProductoEN productoEN = productoLN.ObtenerProducto(out mensajeError, id);

            if (productoEN == null)
            {
                Console.WriteLine(mensajeError + "\r\n" + GetType() + " - " + MethodBase.GetCurrentMethod().Name);

                return NotFound();
            }
            return Ok(productoEN);
        }

    }
}

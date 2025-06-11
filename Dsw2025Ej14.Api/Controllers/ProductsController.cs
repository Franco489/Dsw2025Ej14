using Dsw2025Ej14.Api.Data;
using Microsoft.AspNetCore.Mvc;

namespace Dsw2025Ej14.Api.Controllers
{
    [ApiController]
    [Route("api/product")]

    public class ProductsController : ControllerBase
    {
        private readonly IPersistencia _persistencia;

        public ProductsController (IPersistencia persistencia)
        {
            _persistencia = persistencia;
        }
        [HttpGet()]

        public IActionResult GetProducts()
        {
            return Ok(_persistencia.GetProducts());
        }

        // GET api/products/{sku}
        [HttpGet("{sku}")]
        public IActionResult GetBySku(string sku)
        {
            var producto = _persistencia
                .GetProducts()
                .FirstOrDefault(p => string.Equals(p.Sku, sku, StringComparison.OrdinalIgnoreCase));

            if (producto != null)
                return Ok(producto);

            return NotFound(); // 404
        }
    }



}


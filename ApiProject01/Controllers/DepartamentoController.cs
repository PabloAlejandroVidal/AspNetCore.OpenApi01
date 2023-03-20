using ApiProject01.Datos;
using ApiProject01.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<DepartamentoDto>> GetDepartamentos()
        {
            return Ok(Tienda.DtoDepartamentos);
        }

        [HttpGet("id:int")]
        public ActionResult<DepartamentoDto?> GetDepartamento(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var dep = Tienda.GetDtoDepartamentos(id);

            if( dep == null)
            {
                return NotFound();
            }
            return Ok(dep);
        }
    }
}

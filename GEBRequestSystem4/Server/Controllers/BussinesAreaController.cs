using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GEBRequestSystem4.Shared;

namespace GEBRequestSystem4.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BussinesAreaController : ControllerBase
    {
        public static List<BussinesDirection> bussinesDirections = new List<BussinesDirection>
        {
            
        };
        public static List<BussinesArea> bussinesAreas = new List<BussinesArea>
        {
            
        };

        [HttpGet]
        public async Task<ActionResult<List<BussinesArea>>> GetBussinesAreas()
        {
            return Ok(bussinesAreas);
        }

        [HttpGet("bussinesDirections")]
        public async Task<ActionResult<List<BussinesDirection>>> GetBussinesDirections()
        {
            return Ok(bussinesDirections);
        }

        [HttpGet("{IdBussinesArea}")]
        public async Task<ActionResult<BussinesArea>> GetSingleAreas(int IdBussinesArea)
        {
            var area = bussinesAreas.FirstOrDefault(a => a.IdBussinesArea == IdBussinesArea);
            if (area == null)
            {
                return NotFound("Losiento, Area no encontrada");
            }
            return Ok(area);
        }
    }
}

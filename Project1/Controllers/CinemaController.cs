using Microsoft.AspNetCore.Mvc;
using Project1.Dtos;

namespace Project1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CinemaController : ControllerBase
    {
        private List<CinemaDto> list = new List<CinemaDto>()
        {
            new CinemaDto("null","null","null","null")
        };



        [HttpGet]
        public List<CinemaDto> Get()
        {
            return list;
        }
    }
}

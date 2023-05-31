using Backend.Interface;
using Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JabatansController : ControllerBase
    {
        private readonly IJabatan _Jabatan;

        public JabatansController(IJabatan Jabatan)
        {
            _Jabatan = Jabatan;
        }
        [HttpGet("View")]
        public IEnumerable<Jabatan> Get()
        {
            return _Jabatan.Gets();
        }
    }
}
